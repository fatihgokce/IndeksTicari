using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Views.Models;
namespace Indeks.Views {
    public partial class frmBaslangic : Form {
        
        public frmBaslangic() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Settings set = Engine.FindSettings();
                if (rbSqlLite.Checked)
                    set.DataBase = "SqlLite";
                else
                    set.DataBase = "MsSql";
                Engine.SaveSettings(set);
                this.Close();
                frmLogin frm = (frmLogin)this.Owner;
                frm.Visible = true;
                this.Close();

            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
