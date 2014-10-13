using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Indeks.Views.App_Code
{
  class ControlPosition
  {
    private List<Control> _listControls = new List<Control>();
    private ViewConrol _view=new ViewConrol();
    public ViewConrol HideControls(params Control[] controls)
    {
      _view.HideContols(controls);
      return _view;
    }
    public ViewConrol ShowControls(params Control[] controls)
    {
      _view.ShowControls(controls);
      return _view;
    }
    
  }
}
