using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Base;
namespace Indeks.Views
{
  public class BaseForm:Form
  {   
    protected int SimdikiWidth = 1280;
    protected int SimdikiHeight = 800;
    
    float yukseklikOran = new float();
    float genislikOran = new float();
    protected BaseForm() : base() { }
    public void formBoyutlandır(Form ObjForm, int paramYukseklik, int paramGenislik)
    {
        int tasYukseklik = paramYukseklik; //Tasarım anındaki ekran yüksekliği
        int tasGenislik = paramGenislik;//Tasarım anındaki ekran genişliği

        int cozYukseklik = Screen.PrimaryScreen.Bounds.Height;//kullanıcı ekran yüksekliği
        int cozGenislik = Screen.PrimaryScreen.Bounds.Width;// kullanıcı ekran genişliği
        // alttaki iki satırda kullanıcı ekranıyla tasarımdaki ekranın oranları alınıyor.
        yukseklikOran = (float)((float)cozYukseklik / (float)tasYukseklik);
        genislikOran = (float)((float)cozGenislik / (float)tasGenislik);
        ObjForm.AutoScaleMode = AutoScaleMode.None;
        ObjForm.Scale(new SizeF(genislikOran, yukseklikOran));
        foreach (Control c in ObjForm.Controls)
        {
            if (c.HasChildren)
            {
                kontrolBoyutlandır(c);
            }
            else
            {
                c.Font = new Font(c.Font.FontFamily, c.Font.Size * yukseklikOran, c.Font.Style, c.Font.Unit, ((byte)(0)));
            }
        }
        ObjForm.Font = new Font(ObjForm.Font.FontFamily, ObjForm.Font.Size * yukseklikOran, ObjForm.Font.Style, ObjForm.Font.Unit, ((byte)(0)));
        
    }
    /// <summary>
    /// bu kısım kontrollerin fontları ve boyutlarını orana göre değiştirir.
    /// </summary>   
    private void kontrolBoyutlandır(Control objKontrol)
    {
        if (objKontrol.HasChildren)
        {
            foreach (Control controlChildren in objKontrol.Controls)
            {
                if (controlChildren.HasChildren)
                {
                    kontrolBoyutlandır(controlChildren);
                }
                else
                {
                    controlChildren.Font = new Font(controlChildren.Font.FontFamily, controlChildren.Font.Size * yukseklikOran, controlChildren.Font.Style, controlChildren.Font.Unit, ((byte)(0)));
                }
            }
            objKontrol.Font = new Font(objKontrol.Font.FontFamily, objKontrol.Font.Size * yukseklikOran, objKontrol.Font.Style, objKontrol.Font.Unit, ((byte)(0)));
        }
        else
        {
            objKontrol.Font = new Font(objKontrol.Font.FontFamily, objKontrol.Font.Size * yukseklikOran, objKontrol.Font.Style, objKontrol.Font.Unit, ((byte)(0)));
        }

    }

    public ViewConrol ViewConrol
    {
      get
      {
        return new ViewConrol();
      }
    }
    protected ClearerControl CleareForm
    {
      get
      {
        return new ClearerControl();
      }
      
    }
    private void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // BaseForm
      // 
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Name = "BaseForm";

      this.ResumeLayout(false);

    }
    protected void BeginTransaction()
    {
      NHibernateSessionManager.Instance.BeginTransaction();
    }
    protected void CommitTransaction()
    {
      try
      {
        NHibernateSessionManager.Instance.CommitTransaction();
      }       
      finally
      {
        NHibernateSessionManager.Instance.CloseSession();
      }
    }
    protected void ClearFormData(Control control)
    {
      int sayi = control.Controls.Count;
      for (int i = 0; i < sayi; i++)
      {
        Control cCntr=control.Controls[i];
        if (cCntr != null && cCntr.HasChildren)
        {
          Kontrol(cCntr);
        }        
        else if (cCntr!=null && cCntr is TextBox)
        {
          TextBox txtbox = cCntr as TextBox;
          if (txtbox != null)
            txtbox.Text = "";
        }
        else if(cCntr != null && cCntr is ComboBox) 
        {
          ComboBox cmb = cCntr as ComboBox;
          cmb.Text = "";

        }
        else if (cCntr != null && cCntr is CheckBox)
        {
          ((CheckBox)cCntr).Checked = false;

        }
      }
    }
    void Kontrol(Control c)
    {
      if (c.HasChildren)
      {
        foreach (Control ch in c.Controls)
        {
          if (ch.HasChildren)
            Kontrol(ch);
          else
          {
            if (ch is TextBox)
            {
              TextBox txt = ch as TextBox;
              if (txt != null)
                txt.Text = "";
            }
            else if (ch is ComboBox)
            {
              ComboBox cmb = ch as ComboBox;
              //if (cmb != null)
              //    cmb.SelectedIndex = -1;
              cmb.Text = "";
            }
            else if (ch is CheckBox)
            {
              ((CheckBox)ch).Checked = false;
            }
          }
        }
      }
      else
      {
        if (c is TextBox)
        {
          TextBox txt = c as TextBox;
          if (txt != null)
            txt.Text = "";
        }
        else if (c is ComboBox)
        {
          ComboBox cmb = c as ComboBox;
          //if (cmb != null)
          //    cmb.SelectedIndex = -1;
          cmb.Text = "";
        }
        else if (c is CheckBox)
        {
          ((CheckBox)c).Checked = false;
        }
      }
    }
    protected bool IsNullObject(object obj)
    {
      if (obj == null)
        return true;
      else
        return false;
    }
  
  }
}
