using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Indeks.Views.Controller {
    public partial class FilterDataGridView : UserControl {
        [Browsable(true)]
        public DataGridView Grid { get { return grd; } private set{grd=value;} }
        public FilterDataGridView() {
            InitializeComponent();
        }
        private int _kayitSayisi;
        public int KayitSayisi { get { return _kayitSayisi; }
            set { _kayitSayisi = value; statLblRecordCount.Text =string.Format("Kayıt Sayısı:{0}",_kayitSayisi); }
        }
    }
}
