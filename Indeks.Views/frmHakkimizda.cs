using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Indeks.Views {
    public partial class frmHakkimizda : Form {
        public frmHakkimizda() {
            InitializeComponent();
            labVersi.Text = string.Format("Versiyon:{0}",Engine.Versiyon());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                Process prc = new Process();
                prc.StartInfo.FileName = linkLabel1.Text;
                prc.Start();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
