using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndeksControl
{
    public class AutoCompleteTextBox : TextBox
    {
        //ListBox _listBox;
        //public delegate TResult Func<TResult>();
        Func<List<string>> _dataSource;
        int _widthAutoComplete;


        private string _nextTabControlName;
        private ListBox _listBox;
        private Form _form;
        private Color _listItemColor = Color.FromKnownColor(KnownColor.DarkOrange);
        private Color _listForeColor;

        bool _listBoxAdded;
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Tab) return true;
            return base.IsInputKey(keyData);
        }
        public AutoCompleteTextBox()
        {
            _widthAutoComplete = 0;
            this.KeyUp += new KeyEventHandler(MhsTextBox_KeyUp);
            this.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
                {
                    RemoveListBox();
                    //SendKeys.Send("{TAB}");
                    if (!string.IsNullOrEmpty(NextTabControlName))
                    {

                        Control cnt = this.FindForm().Controls.Find(NextTabControlName, true)[0];
                        if (cnt != null)
                            cnt.Focus();
                    }
                }
            };
            this.LostFocus += new EventHandler(FAutoComplete_LostFocus);
        }

        void FAutoComplete_LostFocus(object sender, EventArgs e)
        {
            if (!this.Focused)
            {
                if (_form != null)
                {
                    if (!_form.Focused && !this._listBox.Focused)
                        RemoveListBox();
                }
            }
        }
        public virtual void CloseAutoComplete()
        {
            RemoveListBox();
        }
        private void SetLocationForm()
        {

            Point PopupOffset = new Point(0, 0);
            Point p = this.PointToScreen(new Point(0, 0));
            p.X += PopupOffset.X;
            p.Y += this.Height - 1 + PopupOffset.Y;
            this._form.Location = p;
        }
        void InitiliazeListBox(List<string> data)
        {
            _form = new Form();
            _form.Name = "formStokListesi";
            _listBox = new ListBox();
            _listBox.Name = "lstStokKoduBox";
            _form.FormBorderStyle = FormBorderStyle.None;

            _form.TopMost = true;
            _listBox.BorderStyle = BorderStyle.None;
            _listBox.BackColor = _listItemColor;
            _listBox.ForeColor = _listForeColor;
            _listBoxAdded = false;
            _listBox.Dock = DockStyle.Fill;

            _listBox.Items.AddRange(data.ToArray());
            _form.Size = new Size(_widthAutoComplete, 13 * data.Count);
            _form.StartPosition = FormStartPosition.Manual;
            _form.Controls.Add(_listBox);
            _form.ShowInTaskbar = false;
            SetLocationForm();
            _listBox.KeyDown += (o, y) =>
            {
                if (y.KeyCode == Keys.Enter || y.KeyCode == Keys.Tab)
                {
                    this.Focus();
                    string deger = _listBox.SelectedItem.ToString();
                    if (AyracBoslukKullan)
                        this.Text = deger.Substring(0, WidthKod).TrimEnd();
                    else if (!string.IsNullOrEmpty(Ayirac))
                        this.Text = deger.Split(Ayirac.ToCharArray())[0].TrimEnd();
                    else
                        this.Text = deger.TrimEnd();
                    this.SelectionStart = this.Text.Length;
                    RemoveListBox();
                    _listBoxAdded = true;
                }
                else if (_listBox.SelectedIndex == 0 && y.KeyCode == Keys.Up)
                {
                    this.Focus();
                }


            };

        }
        void RemoveListBox()
        {
            if (_form != null)
            {
                _form.Close();
                _form.Dispose();
            }
        }
        void LoadDataListBox()
        {
            if (DataSource != null)
            {
                List<string> liste = DataSource();

                if (liste != null && liste.Count > 0)
                {

                    InitiliazeListBox(liste);
                    _form.Shown += (o, e) =>
                    {
                        this.Focus();
                    };
                    _form.Show();

                }
                else
                {
                    RemoveListBox();
                }
            }
        }
        void MhsTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //RemoveListBox();
            //LoadDataListBox();
            //if (e.KeyCode == Keys.Tab)
            //{
            //  RemoveListBox();
            //  if (!string.IsNullOrEmpty(NextTabControlName))
            //  {
            //    Control cnt= this.FindForm().Controls.Find(NextTabControlName,true)[0];
            //    cnt.Focus();
            //  }
            //}
            if (string.IsNullOrEmpty(this.Text))
            {
                RemoveListBox();
            }
            else if (_listBoxAdded)
            {
                RemoveListBox();
                _listBoxAdded = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (_listBox != null)
                {
                    _listBox.Focus();
                    if (_listBox.Items.Count > 0)
                        _listBox.SelectedIndex = 0;
                }
            }

            else
            {
                RemoveListBox();
                LoadDataListBox();
            }
        }

        public Func<List<string>> DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; }
        }


        //[Description("Tab next control name).")]
        //[Browsable(true)]

        public string NextTabControlName
        {
            get { return _nextTabControlName; }
            set { _nextTabControlName = value; }
        }
        [Description("")]
        [Browsable(true)]
        public Color ListItemColor
        {
            get { return _listItemColor; }
            set { _listItemColor = value; }
        }
        [Description("")]
        [Browsable(true)]
        public Color ListForeColor
        {
            get { return _listForeColor; }
            set { _listForeColor = value; }
        }
        [Description("")]
        [Browsable(true)]
        public string Ayirac
        {
            get;
            set;
        }
        [Description("")]
        [Browsable(true)]
        public int WidthKod
        {
            get;
            set;
        }
        [Description("")]
        [Browsable(true)]
        public bool AyracBoslukKullan
        {
            get;
            set;
        }
        [Description("")]
        [Browsable(true)]
        public int WidthAutoComplete
        {
            get
            {
                if (_widthAutoComplete == 0)
                    return this.Size.Width;
                else
                    return _widthAutoComplete;
            }
            set
            {
                _widthAutoComplete = value;
            }
        }
    }
}
