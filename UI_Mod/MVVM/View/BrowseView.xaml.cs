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
        private Art_texts current_art;
        public BrowseView()
        {
            InitializeComponent();

            Art_texts_ = new ObservableCollection<Art_texts>
            {
                new Art_texts {Title="Unleashing the Power of Creativity: Path to Innovation", Description="In our current rapidly evolving world, innovation has emerged as the driving force behind the progress." +
                   "\r\nIn this article we will delve into the dynamic landscape of innovation, exploring how organizations and individuals push boundaries and shape our future." +
                   "\r\nDiscover the strategies, mindsets, and stories that inspire the next wave of groundbreaking advancements."},
                new Art_texts {Title="Mysteries Unveiled:Journey into Science", Description="From how our brain works to the newest discoveries about the universe and cosmos, the world of science captivates mankinds imagination and expands our understanding." +
                   "\r\nIn this article we will explore the latest scientific breakthroughs and show the inner details of research work done by scientists." +
                   "\r\nRead this article to find out about revolutionary technologies, and awe-inspiring revelations that propel humanity's quest for knowledge." },
                new Art_texts {Title="Earth alarm: Navigating the Global Environmental Landscape",Description="Our planet ecosystems is at a critical juncture, prompting an urgent call for collective action." +
                    "\r\nIn this article, we delve into the pressing environmental challenges that span continents and impact every living being." +
                    "\r\nAmidst the challenges we will meet communities, innovators, and policymakers who address issues such as climate change, conservation, and sustainable living." +
                    "\r\nJoin us as we shed light on both the dire realities and the inspiring initiatives that are shaping the future of our environment."},
                new Art_texts {Title="Trends Of Prosperity: Insights in the Financial World", Description="The world of finance is non stop evolving and changing influenced by global markets, technological advancements, and shifting consumer behaviors." +
                    "\r\nThis article provides a comprehensive analysis of the financial landscape, offering insights into investment strategies, economic trends, and the transformative potential of financial technologies." +
                    "\r\nWhether you're an investor, entrepreneur, or simply intrigued by the forces shaping economies, this exploration will provide a deeper understanding of the complex web that drives global prosperity." }
            };

            foreach (Art_texts art_ in Art_texts_)
            {
                art_.ArtClicked += Inno_clikc;
            }
            
            DataContext = this;

            
        }
        
        private void Inno_clikc(object sender, EventArgs e)
        {
            if (sender is Art_texts article)
            {
                current_art = article;
                innov_txt.Text = current_art.Title;

                if (innov_txt.Visibility == Visibility.Collapsed)
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

    class Art_texts
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public EventHandler ArtClicked;
        public void ONArtClicked()
        {
            ArtClicked.Invoke(this, EventArgs.Empty);
        }

    }
}
