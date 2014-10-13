using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Indeks.Views.Helper {
    class ConfigureSecreen {
        public ConfigureSecreen Visible(bool state, params Control[] cnts) {
            foreach(Control cnt in cnts)
                cnt.Visible=state;
            return this;
        }
        public ConfigureSecreen SetLocation(Point point, params Control[] cnts) {
            foreach (Control cnt in cnts)
                cnt.Location = point;
            return this;
        }
        public ConfigureSecreen SetSize(Size size, params Control[] cnts) {
            foreach (Control cnt in cnts)
                cnt.Size = size;
            return this;
        }


    }
}
