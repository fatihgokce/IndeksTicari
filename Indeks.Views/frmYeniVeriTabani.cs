using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Indeks.Views {
    public partial class frmYeniVeriTabani : Form {
        const string SqlLiteDbName = "MainSource.db";
        public frmYeniVeriTabani() {
            InitializeComponent();
        }

        private void btnSqlLiteSave_Click(object sender, EventArgs e) {
            try {
                string sqllitefolderpath = Engine.SqlLitePath();
                string sourceDbName = Path.Combine(sqllitefolderpath,SqlLiteDbName);
                string desDbName = Path.Combine(Engine.DataBasePath(), txtSqlLiteDb.Text + ".db");
                 
                if (File.Exists(desDbName)) 
                {
                    MessageBox.Show("{0} isminde veri tabanı var başka bir isim giriniz".With(txtSqlLiteDb.Text));
                    txtSqlLiteDb.Focus();
                    return;
                }
               
                File.Copy(sourceDbName,desDbName);

            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
