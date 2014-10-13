using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Views.Models;
namespace Indeks.Views.Helper {
    class ScreenState {
        private IDictionary<CekDurum, ControlState> stateTable = new Dictionary<CekDurum, ControlState>();
        private IDictionary<SenetDurum, ControlState> stateTableSenet = new Dictionary<SenetDurum, ControlState>();
        private IDictionary<IndeksPaket, ControlState> stateTabLissans = new Dictionary<IndeksPaket, ControlState>();
        public ControlState WhenStateIs(CekDurum durum) {
            ControlState state = new ControlState();
            stateTable.Add(durum, state);
            return state;
        }

        
        public ControlState WhenStateIs(SenetDurum durum) {
            ControlState state = new ControlState();
            stateTableSenet.Add(durum, state);
            return state;
        }
        public ControlState WhenStateIs(IndeksPaket durum) {
            ControlState state = new ControlState();
            stateTabLissans.Add(durum, state);
            return state;
        }
        public void ChangeTo(CekDurum durum) {
            if (stateTable.ContainsKey(durum))
                stateTable[durum].Activate();
        }
        public void ChangeTo(SenetDurum durum) {
            if (stateTableSenet.ContainsKey(durum))
                stateTableSenet[durum].Activate();
        }
        public void ChangeTo(IndeksPaket durum) {
            if (stateTabLissans.ContainsKey(durum))
                stateTabLissans[durum].Activate();
        }
    }
}
