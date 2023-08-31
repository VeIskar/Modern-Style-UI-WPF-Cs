using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Art_texts> Art_texts_ { get; set; }        
        public BrowseView()
        {
            InitializeComponent();
           
            Art_texts_ = new ObservableCollection<Art_texts>
            {
                new Art_texts {Title="Creativity: Path to Innovation", Description="In a rapidly evolving world, innovation is the key." +                   
                   "\r\nExplore the innovation landscape, strategies," +
                   "\rmindsets and stories behind advancements.\n" +
                   "\nDiscover the Cutting Edge "},
                new Art_texts {Title="Unveiling: Science's Journey", Description="From the brain to cosmos, science is fascinating. " +
                   "\r\nExplore the latest breakthroughs, scientists'" +
                   "\rresearch, and revolutionary tech in this article.\n" +
                   "\nRead more to find out about revolutionary tech"},
                new Art_texts {Title="Earth alarm: Our Environment",Description="Our planet's ecosystems demands urgent action." +                   
                    "\r\nDelve into pressing environmental challenges" +
                    "\rand illuminating initiatives in this article.\n" +              
                    "\nJoin us as in this ecological journey" },
                new Art_texts {Title="Prosperity Trends: Finance", Description="Finance evolves, shaped by markets and public." +
                    "\r\nThis article comprehensively analyzes the" +
                    "\rfinancial landscape, offering insights into it.\n" +
                    "\nExplore web that drives global prosperity" }
                               
            };
            //can as well create new objects corresponding to the Art_texts class and put them in ObservableCollection
           
            DataContext =this;
            
        }
        
        private void Inno_clikc(object sender, EventArgs e)
        {
            grid_Ino.DataContext = Art_texts_[0];

            if (innov_txt.Visibility == Visibility.Collapsed && innov_desc.Visibility==Visibility.Collapsed)
            {
                innov_txt.Visibility = Visibility.Visible;
                innov_desc.Visibility = Visibility.Visible;
                innov_title.Visibility = Visibility.Collapsed;
            }
            else
            {
                innov_txt.Visibility = Visibility.Collapsed;
                innov_desc.Visibility = Visibility.Collapsed;
                innov_title.Visibility = Visibility.Visible;
            }          

        }
        private void Scien_click(object sender, EventArgs e)
        {
            grid_Scien.DataContext = Art_texts_[1];
            if (scien_txt.Visibility == Visibility.Collapsed && scien_desc.Visibility == Visibility.Collapsed)
            {
                scien_txt.Visibility = Visibility.Visible;
                scien_desc.Visibility = Visibility.Visible;
                scien_title.Visibility = Visibility.Collapsed;
            }
            else
            {
                scien_txt.Visibility = Visibility.Collapsed;
                scien_desc.Visibility = Visibility.Collapsed;
                scien_title.Visibility = Visibility.Visible;
            }
        }

        private void Env_click(object sender, MouseButtonEventArgs e)
        {
            grid_Env.DataContext = Art_texts_[2];
            if (env_txt.Visibility == Visibility.Collapsed && env_desc.Visibility == Visibility.Collapsed)
            {
                env_txt.Visibility = Visibility.Visible;
                env_desc.Visibility = Visibility.Visible;
                env_title.Visibility = Visibility.Collapsed;
            }
            else
            {
                env_txt.Visibility = Visibility.Collapsed;
                env_desc.Visibility = Visibility.Collapsed;
                env_title.Visibility = Visibility.Visible;
            }
        }

        private void Fina_click(object sender, MouseButtonEventArgs e)
        {
            grid_Fina.DataContext= Art_texts_[3];
            if (fina_txt.Visibility == Visibility.Collapsed && fina_desc.Visibility == Visibility.Collapsed)
            {
                fina_txt.Visibility = Visibility.Visible;
                fina_desc.Visibility = Visibility.Visible;
                fina_title.Visibility = Visibility.Collapsed;
            }
            else
            {
                fina_txt.Visibility = Visibility.Collapsed;
                fina_desc.Visibility = Visibility.Collapsed;
                fina_title.Visibility = Visibility.Visible;
            }
        }
    }

    class Art_texts
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
    }
}
