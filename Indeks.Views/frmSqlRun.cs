using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Indeks.Views {
    public partial class frmSqlRun : Form {
        public frmSqlRun() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                ProcessDataBase prc = new ProcessDataBase(Engine.GetConString());
                prc.ExecuteNonQueries(textBox1.Text);
                MessageBox.Show("Komutlar çalıştırıldı.Lütfen programı kapatıp tekrar açın");
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
