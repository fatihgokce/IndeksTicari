using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
namespace Indeks.Views
{
  //public delegate TResult Func<T, TResult>(T arg);
  public class ViewConrol
  {
    public ViewConrol ShowControls(params Control[] controls)
    {
      foreach (Control c in controls)
        c.Visible = true;
      return this;
    }
    public ViewConrol HideContols(params Control[] controls)
    {
      foreach (Control c in controls)
        c.Visible = false;
      return this;
    }
    public ViewConrol IncerementPosHeight(int value, params Control[] controls)
    {
      foreach (Control c in controls)
        c.Location=new System.Drawing.Point(c.Location.X,c.Location.Y+value);
      return this;
    }
    public ViewConrol IncerementPosHeight(int value,Control grbox ,params Control[] notIncrementControls)
    {
      if (grbox.HasChildren)
      {
        int sayi = grbox.Controls.Count;
        for (int i = 0; i < sayi; i++)
        {
          Control cCntr = grbox.Controls[i];
          if (notIncrementControls != null)
          {
            if (notIncrementControls.Contains(cCntr))
              continue;
          }
          cCntr.Location = new System.Drawing.Point(cCntr.Location.X, cCntr.Location.Y + value);
        }
      }     
      return this;
    }
    public ViewConrol IncerementPosWidth(int value, Control grbox, params Control[] notIncrementControls)
    {
      
      if (grbox.HasChildren)
      {
        int sayi = grbox.Controls.Count;
        for (int i = 0; i < sayi; i++)
        {
          Control cCntr = grbox.Controls[i];
          if (notIncrementControls != null)
          {
            if (notIncrementControls.Contains(cCntr))
              continue;
          }
          cCntr.Location = new System.Drawing.Point(cCntr.Location.X, cCntr.Location.Y + value);
        }
      }
      return this;
    }
    public ViewConrol IncerementPosWidth(int value, params Control[] controls)
    {
      foreach (Control c in controls)
        c.Location = new System.Drawing.Point(c.Location.X+value, c.Location.Y);
      return this;
    }

  }
}
