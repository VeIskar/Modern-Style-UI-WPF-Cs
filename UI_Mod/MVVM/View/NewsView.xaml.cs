using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace UI_Mod.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy NewsView.xaml
    /// </summary>
    public partial class NewsView : UserControl
    {

        private DispatcherTimer timer;

        public NewsView()
        {
            InitializeComponent();

            timer= new DispatcherTimer();
            timer.Interval=TimeSpan.FromSeconds(1);
            timer.Tick+= Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClockTxt.Text=DateTime.Now.ToString("G");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
