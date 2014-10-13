using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Indeks.Data.BusinessObjects;

namespace Indeks.Views.Helper {
    
    public class ControlState{
        public List<Action> actionsToDo = new List<Action>();
  
        private List<Control> disabledControls = new List<Control>();
        private List<Control> enabledControls = new List<Control>();
        private List<ToolStripItem> disableMenus = new List<ToolStripItem>();
        private IDictionary<Point, List<Control>> setLocationCnts = new Dictionary<Point,List<Control>>();
        private IDictionary<Size,List<Control>> setSizeCnts = new Dictionary< Size,List<Control>>();
        public ControlState EnableControls(params Control[] controls)
        {
            enabledControls.AddRange(controls);
            return this;
        }

        public ControlState DisableControls(params Control[] controls)
        {
            disabledControls.AddRange(controls);
            return this;
        }
        public ControlState DisableToolStripItem(params ToolStripItem[] menus) {
            disableMenus.AddRange(menus);
            return this;
        }
        public ControlState SetLocation(Point point,params Control[] controls) {
            setLocationCnts.Add(point, controls.ToList());
            return this;        
        }
        public ControlState SetSize(Size size, params Control[] controls) {
            setSizeCnts.Add(size,controls.ToList());
            return this;
        }
        public void Do(params Action[] actions) {
            actionsToDo.AddRange(actions);
        }
      
       
        public void Activate()
        {
            for (int i = 0; i < disableMenus.Count; i++) {
                disableMenus[i].Visible = false;
            }
                for (int i = 0; i < enabledControls.Count; i++) {
                    enabledControls[i].Visible = true;
                }

            for (int i = 0; i < disabledControls.Count; i++)
            {
                disabledControls[i].Visible = false;
            }
            foreach (KeyValuePair<Size, List<Control>> pair in setSizeCnts) {
                List<Control> liste = pair.Value;
                foreach (Control c in liste)
                    c.Size = pair.Key;
            }
            foreach (KeyValuePair<Point, List<Control>> pair in setLocationCnts) {
                List<Control> liste = pair.Value;
                foreach (Control c in liste)
                    c.Location = pair.Key;
            }
            for (int i = 0; i < actionsToDo.Count; i++) {
                Action action = actionsToDo[i];
                action();
            }
            

        }
    }
}
