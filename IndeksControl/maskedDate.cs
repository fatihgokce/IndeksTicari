using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndeksControl
{
    public class maskedDate : MaskedTextBox
    {
        DateTimePicker _timePicker;

        public void initializeTimePiceker()
        {

            Point PopupOffset = new Point(0, 0);
            Point p = this.Parent.PointToScreen(new Point(0, 0));
            p.X += this.Width + PopupOffset.X;

            p.Y += PopupOffset.Y;
            this.Mask = "00.00.0000";
            _timePicker = new DateTimePicker();
            _timePicker.Name = "timeMaskedPicker";
            _timePicker.Size = new Size(17, this.Height);
            _timePicker.TabStop = false;
            _timePicker.ValueChanged += (o, e) =>
            {
                this.Text = _timePicker.Value.ToShortDateString();
            };
            _timePicker.Visible = this.Visible;

            _timePicker.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            this.VisibleChanged += (o, e) =>
            {
                _timePicker.Visible = this.Visible;
            };
            Control parent = this.Parent;
            if (parent != null)
                parent.Controls.Add(_timePicker);
            else
            {
                Form frm = this.FindForm();
                if (frm != null)
                {
                    frm.Controls.Add(_timePicker);
                }
            }
        }



    }
}
