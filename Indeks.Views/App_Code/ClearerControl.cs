using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Indeks.Views
{
  public class ClearerControl
  {
    private Control _clrCnt;
    private Control[] _notClearCnts;
    //private List<Control> _notClearCnts;
    public ClearerControl ClearThisConrol(Control cnt)
    {
      _clrCnt = cnt;      
      return this;
    }
    public ClearerControl NotClearTheseConrols(params Control[] cntls)
    {
      _notClearCnts =cntls;
      return this;
    }
    public void BeginClear()
    {
      int sayi =_clrCnt.Controls.Count;
      for (int i = 0; i < sayi; i++)
      {
       
        Control cCntr =_clrCnt.Controls[i];
        if(_notClearCnts!=null)
        {
        if (_notClearCnts.Contains(cCntr))
          continue;
        }
        if (cCntr != null && cCntr.HasChildren)
        {
          Kontrol(cCntr);
        }
        else if (cCntr != null && cCntr is TextBox)
        {
          TextBox txtbox = cCntr as TextBox;
          if (txtbox != null)
            txtbox.Text = "";
        }
        else if (cCntr != null && cCntr is MaskedTextBox)
        {
          MaskedTextBox txtbox = cCntr as MaskedTextBox;
          if (txtbox != null)
            txtbox.Text = "";
        }
        else if (cCntr != null && cCntr is ComboBox)
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
          if(_notClearCnts!=null)
          {
          if (_notClearCnts.Contains(ch))
            continue;
          }
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
            else if (ch is MaskedTextBox)
            {
              MaskedTextBox txt = ch as MaskedTextBox;
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
        else if (c is MaskedTextBox)
        {
          MaskedTextBox txt = c as MaskedTextBox;
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
  }
}
