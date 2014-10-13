using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.Base;
using Indeks.Data.ManagerObjects;

namespace Indeks.Views {
    public partial class frmCariBakiye : Form {

        public frmCariBakiye(string cariKodu) {
            InitializeComponent();
            try {
                ICariHareketManager mngCahar = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType()).GetCariHareketManager();
                labAlacak.Text = cariKodu + " Alacağı:";
                labBorc.Text = cariKodu + " Borçu:";
                double borc=mngCahar.GetCariToplamBorc(UserInfo.Sube.Id,cariKodu);
                double alacak= mngCahar.GetCariToplamAlacak(UserInfo.Sube.Id, cariKodu);
                double bakiye = alacak - borc;
                txtAlacakMiktar.Text = alacak.ToString(2);
                txtBorcMiktar.Text = borc.ToString(2);
                txtBakiyeMiktar.Text = bakiye.ToString(2);
               
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
