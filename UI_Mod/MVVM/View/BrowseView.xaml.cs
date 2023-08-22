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

namespace UI_Mod.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy BrowseView.xaml
    /// </summary>
    public partial class BrowseView : UserControl
    {
        public BrowseView()
        {
            InitializeComponent();
        }

        private void Inno_clikc(object sender, EventArgs e)
        {
            if (innov_txt.Visibility==Visibility.Collapsed)
            {
                innov_txt.Visibility = Visibility.Visible;
                innov_title.Visibility = Visibility.Collapsed;
            }
            else
            {
                innov_txt.Visibility = Visibility.Collapsed;
                innov_title.Visibility = Visibility.Visible;
            }
        }

    }
}
