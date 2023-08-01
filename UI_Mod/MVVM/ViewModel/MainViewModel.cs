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

        public RelayCommand OverViewCommand { get; set; }
        public RelayCommand BrowseViewCommand { get; set; }
        public RelayCommand NewsViewCommand { get; set; }

        public OverViewModel Over_V_M { get; set; }
        public BrowseViewModel Browse_V_M { get; set; }
        public NewsViewModel News_V_M { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {_currentView = value; 
                OnPropertyChanged(); 
            }
        }

        public MainViewModel()
        {
            Over_V_M = new OverViewModel();
            Browse_V_M = new BrowseViewModel();
            News_V_M = new NewsViewModel();

            CurrentView = Over_V_M;

            OverViewCommand=new RelayCommand(obj => { CurrentView = Over_V_M; });

            BrowseViewCommand = new RelayCommand(obj => { CurrentView = Browse_V_M; });

            NewsViewCommand = new RelayCommand(obj => { CurrentView= News_V_M; });

        }
    }
}
