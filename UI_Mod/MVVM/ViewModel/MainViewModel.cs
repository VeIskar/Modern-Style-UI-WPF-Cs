using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Mod.Core;

namespace UI_Mod.MVVM.ViewModel
{
    internal class MainViewModel:ObservableObj
    {
        public OverViewModel Over_V_M { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            Over_V_M = new OverViewModel();
            CurrentView = Over_V_M;
                
        }
    }
}
