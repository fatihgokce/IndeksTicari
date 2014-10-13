using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using Indeks.Data.Report;
namespace Indeks.Views
{
  public partial class frmKasaKayitlari : BaseForm
  {
    string _selectedKasaKodu = string.Empty;
    IManagerFactory mng;    
    IKasaHarManager mngKasaHar;
    IKasaManager mngKasa;
    ICariManager mngCari;
    ICariHareketManager mngCariHar;
    int? _selectedCahar=null;
    int? _selectedKasaHar = null;
    int? _selectedOzelKasaHar = null;
    public frmKasaKayitlari()
    {
      InitializeComponent();
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngKasa = mng.GetKasaManager();
      mngKasaHar = mng.GetKasaHarManager();
      mngCari = mng.GetCariManager();
      mngCariHar = mng.GetCariHareketManager();
      LoadKasa();
      TapGelirGider();
      txtCariKod.DataSource = () =>
      {
          try {
              return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKod.Text).ToStringList(15, txtCariKod.Ayirac);
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
          return null;
      };
      txtCariKod.DataSource = () =>
      {
        try
        {
          return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKod.Text).ToStringList(15,txtCariKod.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };     
    }  
    void LoadKasa()
    {
      try
      {
        bool first = true;
        List<Kasa> kasalar = mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
        foreach (Kasa kas in kasalar)
        {
          cmboxKasalar.Items.Add(kas.Id);
          if (first)
          {
            cmboxKasalar.Text = kas.Id;
            first = false;
          }   
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void SetKasaGenelGider()
    {
      try
      {
        _selectedKasaKodu = cmboxKasalar.Text;
        if (!string.IsNullOrEmpty(_selectedKasaKodu))
        {
          double gelir = mngKasaHar.GetKasaGelirGiderBySubeKoduAndKasaKodu(UserInfo.Sube.Id, _selectedKasaKodu, KasaGelirGider.Gelir);
          double gider = mngKasaHar.GetKasaGelirGiderBySubeKoduAndKasaKodu(UserInfo.Sube.Id, _selectedKasaKodu, KasaGelirGider.Gider);
          Kasa kasa = mngKasa.GetById(_selectedKasaKodu,false);
          double devir = kasa.SonDevirTutar.GetValueOrDefault(0);
            double bakiye = (gelir+devir) - gider;
            txtDevir.Text = devir.ToString("F2");
          txtToplamGelir.Text = gelir.ToString("F2");
          txtToplamGider.Text = gider.ToString("F2");
          txtDevreden.Text = bakiye.ToString("F2");
          tslabTopGelir.Text = gelir.ToString("F2");
          tslabTopGider.Text = gider.ToString("F2");
          tsLabBakiye.Text = bakiye.ToString("F2");
          this.Text = string.Format("KasaKodu:{0};Tarih:{1}", cmboxKasalar.Text, dateIslemTarih.Value.ToString("d"));
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void cmboxKasalar_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(cmboxKasalar.Text) && _selectedKasaKodu != cmboxKasalar.Text)
      {
        SetKasaGenelGider();
      }
    }

    private void btnCariKaydet_Click(object sender, EventArgs e)
    {
      CariTabKalemKaydet();
    }

    private void txtCariKod_KeyUp(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtCariKod.Text) && (e.KeyCode==Keys.Tab || e.KeyCode==Keys.Enter))
      {
        try
        {
          Cari cari = mngCari.GetById(txtCariKod.Text, false);
          if (cari != null)
          {
            txtCariIsim.Text = cari.CariIsim;
            double bakiye=mngCariHar.GetCariHesapBakiyesi(UserInfo.Sube.Id, txtCariKod.Text);
            if(bakiye<0)
            {
              double d = bakiye * -1;
              labCariBakiye.Text= d.ToString("F2")+" Borçlu";
              
            }
            else
              labCariBakiye.Text=bakiye.ToString("F2")+" Alaçaklı";
            txtHesapBakiyesi.Text =bakiye.ToString("F2") ;
            txtCariTel.Text = cari.CariTel;
            txtCariAdres.Text = cari.CariAdres;
            txtCariVergiDairesi.Text = cari.VergiDairesi;
            txtCariVergiNumarasi.Text = cari.VergiNumarasi;
            txtCariGrup1.Text = cari.Grup1.ProperyToStringOrEmpty(x => x.Id);
            txtCariGrup2.Text = cari.Grup2.ProperyToStringOrEmpty(x => x.Id);
            txtCariFisNo.Focus();
          }
        }
        catch (Exception exc)
        {
          LogWrite.Write(exc);
          MessageBox.Show(exc.Message);

        }
      }
    }
    void CariTabKalemKaydet()
    {
      try
      {
          BeginTransaction();
        if (_selectedCahar == null && _selectedKasaHar == null)
        {
          CariHareket cahar = new CariHareket();
          if (rbGelir.Checked)
          {
            cahar.Alacak = txtCariTutar.Text.ParseStruct(x => double.Parse(x));
            cahar.HareketTuru = CariHarTuru.NakitTahsilat;
          }
          else
          {
            cahar.Borc = txtCariTutar.Text.ParseStruct(x => double.Parse(x));
            cahar.HareketTuru = CariHarTuru.NakitOdeme;
          }
          cahar.Cari = mngCari.GetById(txtCariKod.Text, false);
          cahar.FisNo = txtCariFisNo.Text;
          // A-Devir,B-Fatura,C-IadeFatura,D-Kasa,E-MüsteriSeneti,F-BorçSeneti,G-MüşteriÇeki,
          //L-Muhtelif,K-Dekont,J-KarşılıksızÇek,I-ProtestoluSenet,J-KarşılıksızÇek,I-PretostuluSenet,H-BorçÇeki
          
          cahar.Sube = UserInfo.Sube;
          cahar.Tarih = dateIslemTarih.Value.JustDate();         
    
          mngCariHar.Save(cahar);
          KasaHareket kasahar = new KasaHareket();
          kasahar.Aciklama = txtCariKasaAciklama.Text;
          kasahar.FisNo = txtCariFisNo.Text;
          if (rbGelir.Checked)
          {
            kasahar.GelirGider = "G";
            //kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.CariTahsil);
          }
          else
          {
            kasahar.GelirGider = "C";
            //kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.CariOdeme);
          }
          kasahar.Kasa = mngKasa.GetById(cmboxKasalar.Text, false);
          kasahar.Sube = UserInfo.Sube;
          kasahar.Tarih = dateIslemTarih.Value.JustDate();
          kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.Cari);
          kasahar.Tutar = txtCariTutar.Text.ParseStruct(x => double.Parse(x));
          kasahar = mngKasaHar.Save(kasahar);        
    
          txtHesapBakiyesi.Text = mngCariHar.GetCariHesapBakiyesi(UserInfo.Sube.Id, txtCariKod.Text).ToString("F2");

          List<string> listeRow = new List<string>();
          listeRow.Add(kasahar.Id.ToStringOrEmpty());
          listeRow.Add(cahar.Id.ToStringOrEmpty());
          listeRow.Add(kasahar.Kasa.Id);
          listeRow.Add(kasahar.GelirGider=="G"?"Gelir":"Gider");
          listeRow.Add(cahar.Cari.Id);
          listeRow.Add(cahar.Cari.CariIsim);
          listeRow.Add(txtHesapBakiyesi.Text);
          listeRow.Add(txtCariTel.Text);
          listeRow.Add(txtCariAdres.Text);
          listeRow.Add(txtCariVergiNumarasi.Text);
          listeRow.Add(txtCariVergiDairesi.Text);
          listeRow.Add(txtCariGrup1.Text);
          listeRow.Add(txtCariGrup2.Text);
          listeRow.Add(txtCariFisNo.Text);
          listeRow.Add(txtCariTutar.Text);
          listeRow.Add(txtCariKasaAciklama.Text);
          dataGridViewCari.Rows.Add(listeRow.ToArray());         
        }
        else
        {
          DataGridViewRow dr = dataGridViewCari.SelectedRows[0];
          KasaHareket kasahar = mngKasaHar.GetById(int.Parse(dr.Cells["clKasaHarId"].Value.ToString()),false);
          kasahar.FisNo = txtCariFisNo.Text;
          kasahar.Tutar = txtCariTutar.Text.ParseStruct(x=>double.Parse(x));
          kasahar.Aciklama = txtCariKasaAciklama.Text;
          if (rbGelir.Checked)
          {
            kasahar.GelirGider = "G";
            //kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.CariTahsil);
          }
          else
          {
            kasahar.GelirGider = "C";
            //kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.CariOdeme);
          }
          kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.Cari);
      
          mngKasaHar.SaveOrUpdate(kasahar);
          CariHareket cahar = mngCariHar.GetById(int.Parse(dr.Cells["clCariHarId"].Value.ToString()),false);
          cahar.Cari = mngCari.GetById(txtCariKod.Text,false);
          cahar.FisNo = txtCariFisNo.Text;
         
          if (rbGelir.Checked)
          {
            cahar.Alacak = txtCariTutar.Text.ParseStruct(x => double.Parse(x));
            cahar.HareketTuru = CariHarTuru.NakitTahsilat;
          }
          else
          {
            cahar.Borc = txtCariTutar.Text.ParseStruct(x => double.Parse(x));
            cahar.HareketTuru = CariHarTuru.NakitOdeme;
          }
          mngCariHar.SaveOrUpdate(cahar);
 
          txtHesapBakiyesi.Text = mngCariHar.GetCariHesapBakiyesi(UserInfo.Sube.Id, txtCariKod.Text).ToString("F2");
          dr.Cells["clCariKod"].Value = txtCariKod.Text;
          dr.Cells["clCariIsim"].Value = txtCariIsim.Text;
          dr.Cells["clHesapBakiyesi"].Value = txtHesapBakiyesi.Text;
          dr.Cells["clTel"].Value = txtCariTel.Text;
          dr.Cells["clAdres"].Value = txtCariAdres.Text;
          dr.Cells["clVergiNumarasi"].Value = txtCariVergiNumarasi.Text;
          dr.Cells["clVergiDairesi"].Value = txtCariVergiDairesi.Text;
          dr.Cells["clGrup1"].Value = txtCariGrup1.Text;
          dr.Cells["clGrup2"].Value = txtCariGrup2.Text;
          dr.Cells["clFisNo"].Value = txtCariFisNo.Text;
          dr.Cells["clTutar"].Value = txtCariTutar.Text;
          dr.Cells["clKasaAciklama"].Value = txtCariKasaAciklama.Text;         
        }
        YeniCariTabKalem();
        SetKasaGenelGider();
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      } finally {
          try {
              CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    void YeniCariTabKalem()
    {
      _selectedCahar = null;
      _selectedKasaHar = null;
      CleareForm.ClearThisConrol(groupBox5).BeginClear();
      labCariBakiye.Text = "";
      txtCariKod.Focus();
    }
    void CariTabKalemSil()
    { DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
    if (re == DialogResult.Yes) {
        try {

            if (_selectedCahar != null) {
                CariHareket cahar = mngCariHar.GetById(_selectedCahar.Value, true);
                BeginTransaction();
                mngCariHar.Delete(cahar);
                KasaHareket kasahar = mngKasaHar.GetById(_selectedKasaHar.Value, true);
                mngKasaHar.Delete(kasahar);

                DataGridViewRow dr = dataGridViewCari.SelectedRows[0];
                dataGridViewCari.Rows.Remove(dr); ;
                YeniCariTabKalem();
                SetKasaGenelGider();
            }
        } catch (Exception) {
        } finally {
            try {
                CommitTransaction();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
    }

    private void btnCariSil_Click(object sender, EventArgs e)
    {
      CariTabKalemSil();
    }

    private void btnCariYeni_Click(object sender, EventArgs e)
    {
      YeniCariTabKalem();
    }

    private void frmKasaKayitlari_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) {
            SendKeys.Send("{TAB}");
        } else if (e.KeyCode == Keys.F5 && tabControl1.SelectedTab.Name == "tpCari")
            CariTabKalemKaydet();
        else if (e.KeyCode == Keys.F7 && tabControl1.SelectedTab.Name == "tpCari")
            CariTabKalemSil();
        else if (e.KeyCode == Keys.F3 && tabControl1.SelectedTab.Name == "tpCari")
            YeniCariTabKalem();
        else if (e.KeyCode == Keys.F5 && tabControl1.SelectedTab == tpOzelGelirGider)
            OzelKalemKaydet();
        else if (e.KeyCode == Keys.F7 && tabControl1.SelectedTab == tpOzelGelirGider)
            OzelKalemSil();
        else if (e.KeyCode == Keys.F3 && tabControl1.SelectedTab == tpOzelGelirGider)
            OzelYeniKayit();
    }
    void OzelKalemKaydet() {
        try {
            if (string.IsNullOrEmpty(txtOzelGelirGiderKodu.Text) || string.IsNullOrEmpty(txtOzelKdvHaric.Text)
                  ) {
                MessageBox.Show("gelir gider kodu ve kdv hariç tutar  boş olamaz");
                return;
            }        
               
            KasaHareket kasahar =null;
            if (_selectedOzelKasaHar != null)
                kasahar = mngKasaHar.GetById(_selectedOzelKasaHar.Value, false);
            else
                kasahar = new KasaHareket();
            kasahar.Aciklama = txtOzelAciklama.Text;
            kasahar.FisNo = txtOzelFisNo.Text;
            if (rbGelir.Checked) {
                kasahar.GelirGider = "G";
                //kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.CariTahsil);
            } else {
                kasahar.GelirGider = "C";
                //kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.CariOdeme);
            }
            kasahar.Kasa = mngKasa.GetById(cmboxKasalar.Text, false);
            kasahar.Sube = UserInfo.Sube;
            kasahar.Tarih = dateIslemTarih.Value.JustDate();
            kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.Ozel);
            kasahar.Tutar = txtOzelKdvDahilTutar.Text.ParseStruct(x => double.Parse(x));
            kasahar.KdvOrani = txtOzelKdvOrani.Text.ParseNullable<double>(x => double.Parse(x));
            kasahar.KdvTutar = kasahar.Tutar - GetOzelKdvHaricFiyat();
            kasahar.OzelGelirGiderKod = txtOzelGelirGiderKodu.Text;
            mngKasaHar.BeginTransaction();
            kasahar = mngKasaHar.SaveOrUpdate(kasahar);
          
            if (_selectedOzelKasaHar == null) {
                List<string> listeRow = new List<string>();
                listeRow.Add(kasahar.Id.ToStringOrEmpty());
                listeRow.Add(cmboxKasalar.Text);
                listeRow.Add(kasahar.GelirGider == "G" ? "Gelir" : "Gider");
                listeRow.Add(txtOzelGelirGiderKodu.Text);
                listeRow.Add(txtOzelGelirGiderAdi.Text);
                listeRow.Add(kasahar.FisNo);
                listeRow.Add(txtOzelKdvDahilTutar.Text);
                listeRow.Add(txtOzelKdvOrani.Text);
                listeRow.Add(txtOzelKdvHaric.Text);
                listeRow.Add(txtOzelAciklama.Text);
                dataGridViewOzel.Rows.Add(listeRow.ToArray());
            } else {
                DataGridViewRow dr = dataGridViewOzel.SelectedRows[0];
                dr.Cells[clOzelGelirGider.Name].Value = kasahar.GelirGider=="G"?"Gelir":"Gider";
                dr.Cells[clOzelGelirGider.Name].Value = kasahar.OzelGelirGiderKod;
                dr.Cells[clOzelGelirGiderIsmi.Name].Value = txtOzelGelirGiderAdi.Text;
                dr.Cells[clOzelFisNo.Name].Value = kasahar.FisNo;
                dr.Cells[clOzelKdvDahilTutar.Name].Value = txtOzelKdvDahilTutar.Text;
                dr.Cells[clOzelKdvOrani.Name].Value = txtOzelKdvOrani.Text;
                dr.Cells[clOzelKdvHaricTutar.Name].Value = txtOzelKdvHaric.Text;
                dr.Cells[clOzelAciklama.Name].Value = kasahar.Aciklama;
            }
            SetKasaGenelGider();
          
            OzelYeniKayit();

        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        } finally {
            try {
                mngKasaHar.CommitTransaction();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
    void OzelKalemSil() {
           DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
           if (re == DialogResult.Yes) {
               try {

                   if (_selectedOzelKasaHar != null) {

                       KasaHareket kasahar = mngKasaHar.GetById(_selectedOzelKasaHar.Value, true);
                       mngKasaHar.BeginTransaction();
                       mngKasaHar.Delete(kasahar);

                       DataGridViewRow dr = dataGridViewOzel.SelectedRows[0];
                       dataGridViewOzel.Rows.Remove(dr); ;
                       OzelYeniKayit();
                       SetKasaGenelGider();
                   }

               } catch (Exception) {
               } finally {
                   try {
                       mngKasaHar.CommitTransaction();
                   } catch (Exception exc) {
                       MessageBox.Show(exc.Message);
                       LogWrite.Write(exc);
                   }
               }
           }
    }
    void OzelYeniKayit() {
       
        _selectedOzelKasaHar = null;
        CleareForm.ClearThisConrol(groupBox7).BeginClear();
       
        txtOzelGelirGiderKodu.Focus();
    }
    private void dataGridViewCari_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try {

            DataGridViewRow dr = dataGridViewCari.CurrentRow;
            if (dr != null) {
                txtCariKod.Text = dr.Cells["clCariKod"].Value.ToStringOrEmpty();
                txtCariIsim.Text = dr.Cells["clCariIsim"].Value.ToStringOrEmpty();
                txtHesapBakiyesi.Text = dr.Cells["clHesapBakiyesi"].Value.ToStringOrEmpty();
                txtCariTel.Text = dr.Cells["clTel"].Value.ToStringOrEmpty();
                txtCariAdres.Text = dr.Cells["clAdres"].Value.ToStringOrEmpty();
                txtCariVergiNumarasi.Text = dr.Cells["clVergiNumarasi"].Value.ToStringOrEmpty();
                txtCariVergiDairesi.Text = dr.Cells["clVergiDairesi"].Value.ToStringOrEmpty();
                txtCariGrup1.Text = dr.Cells["clGrup1"].Value.ToStringOrEmpty();
                txtCariGrup2.Text = dr.Cells["clGrup2"].Value.ToStringOrEmpty();
                txtCariFisNo.Text = dr.Cells["clFisNo"].Value.ToStringOrEmpty();
                txtCariTutar.Text = dr.Cells["clTutar"].Value.ToStringOrEmpty();
                txtCariKasaAciklama.Text = dr.Cells["clKasaAciklama"].Value.ToStringOrEmpty();
                _selectedCahar = dr.Cells["clCariHarId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
                _selectedKasaHar = dr.Cells["clKasaHarId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
                txtCariKod.Focus();
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }

    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tabControl1.SelectedTab.Name == "tpSorgulama")
        SetKasaGenelGider();
    }

    private void rbGelir_Click(object sender, EventArgs e) {
        tslabGelirGider.Text = ((RadioButton)sender).Name.Substring(2);
    }

    private void frmKasaKayitlari_Load(object sender, EventArgs e) {
        if (rbGelir.Checked)
            tslabGelirGider.Text = "Gelir";
        else
            tslabGelirGider.Text = "Gider";
        this.Text = string.Format("KasaKodu:{0};Tarih:{1}",cmboxKasalar.Text,dateIslemTarih.Value.ToString("d"));
    }

    private void btnRehberOzelGelirGider_Click(object sender, EventArgs e) {
        GelirGider en = rbGelir.Checked ? GelirGider.Gelir : GelirGider.Gider;
        frmOzelGelirGiderListe frm = new frmOzelGelirGiderListe(en);
        frm.Owner = this;
        frm.ShowDialog();
        txtOzelFisNo.Focus();
    }

    private void txtOzelKdvDahilTutar_TextChanged(object sender, EventArgs e) {
        
        txtOzelKdvHaric.Text = GetOzelKdvHaricFiyat().ToString(2);
        txtOzelAciklama.Text = string.Format("{0};Tutar:{1}", tslabGelirGider.Text, txtOzelKdvDahilTutar.Text);
    }
    double GetOzelKdvHaricFiyat() {
        try {
            double fiyat = txtOzelKdvDahilTutar.Text.ParseStruct<double>(x => double.Parse(x));
            double kdv = txtOzelKdvOrani.Text.ParseStruct<double>(x => double.Parse(x));
            double d = fiyat - ((fiyat * kdv) / 100);
            return d;
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
        return 0;
    }
    private void btnOzelKaydet_Click(object sender, EventArgs e) {
        OzelKalemKaydet();
    }

    private void dataGridViewOzel_CellClick(object sender, DataGridViewCellEventArgs e) {
        try {
            DataGridViewRow dr = dataGridViewOzel.CurrentRow;
            if(dr!=null){
            txtOzelGelirGiderKodu.Text = dr.Cells[clGelirGiderKodu.Name].Value.ToStringOrEmpty();
            txtOzelGelirGiderAdi.Text = dr.Cells[clOzelGelirGiderIsmi.Name].Value.ToStringOrEmpty();
            txtOzelFisNo.Text = dr.Cells[clOzelFisNo.Name].Value.ToStringOrEmpty();
            txtOzelKdvDahilTutar.Text = dr.Cells[clOzelKdvDahilTutar.Name].Value.ToStringOrEmpty();
            txtOzelKdvOrani.Text = dr.Cells[clOzelKdvOrani.Name].Value.ToStringOrEmpty();
            txtOzelKdvHaric.Text = dr.Cells[clOzelKdvHaricTutar.Name].Value.ToStringOrEmpty();
            txtOzelAciklama.Text = dr.Cells[clOzelAciklama.Name].Value.ToStringOrEmpty();

            _selectedOzelKasaHar = dr.Cells[clOzelKasaHarId.Name].Value.ToString().ParseNullable<int>(x => int.Parse(x));
            txtCariKod.Focus();
        }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

    private void btnOzelYeni_Click(object sender, EventArgs e) {
        OzelYeniKayit();
    }

    private void btnCariRehber_Click(object sender, EventArgs e) {
        frmCariRehber frm = new frmCariRehber();
        frm.Owner = this;
        frm.ShowDialog();
        txtCariKod.Focus();
    }

    private void btnOzelSil_Click(object sender, EventArgs e) {
        OzelKalemSil();
    }
    void TapGelirGider() {
        if (rbGelir.Checked) {
            tpCari.Text = "Cariden Kasaya Gelir";
            tpOzelGelirGider.Text = "Kasaya Özel Gelir";
        } else {
            tpCari.Text = "Kasadan Cariye Gider";
            tpOzelGelirGider.Text = "Kasadan Özel Gider";
        }
    }
    private void rbGelir_CheckedChanged(object sender, EventArgs e) {
        TapGelirGider(); 
    }

    private void frmKasaKayitlari_FormClosing(object sender, FormClosingEventArgs e) {
        txtCariKod.CloseAutoComplete();
    }


  }
}
