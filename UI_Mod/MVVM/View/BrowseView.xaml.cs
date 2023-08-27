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
                new Art_texts {Title="Power of Creativity: Path to Innovation", Description="In our current rapidly evolving world, innovation " +
                 "\rhas emerged as the driving force of progress." +
                   "\r\nIn this article we will delve into innovation" +
                   "\rlandscape exploring its organizations and peoples.\n" +               
                   "\nDiscover the strategies, mindsets, and stories " +
                   "\rbehind groundbreaking advancements."},
                new Art_texts {Title="Unveiling: Science's Journey", Description="From how our brain works to the newest" +
                   "\rdiscoveries about the universe and cosmos, the" +
                   "\rworld of science still fascinates and amazes." +
                   "\r\nIn this article we will explore the latest scientific" +
                   "\rbreakthroughs and details of scientists research.\n" +
                   "\nRead more to find out about revolutionary tech."},
                new Art_texts {Title="Earth alarm: Our Environment",Description="Our planet ecosystems is at a critical juncture, " +
                    "\rprompting an urgent call for collective action." +
                    "\r\nIn this article, we delve into the pressing environ." +
                    "\rchallenges that span continents and impact lives.\n" +               
                    "\nJoin us as we shed light on both the dire realities" +
                    "\rand the initiatives that shape our future."},
                new Art_texts {Title="Trends Of Prosperity: Financial World", Description="The world of finance is non stop evolving and" +
                    "\rchanging influenced by global markets, tech. advancements, consumers." +
                    "\r\nThis article provides a comprehensive analysis of the financial landscape," +
                    "\roffering insights into its many fields\n" +                    
                    "\nExploration done in article provides a deeper understanding" +
                    "\rof the complex web that drives global prosperity." }
                               
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
