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
using System.Windows.Threading;
using UI_Mod.Core;
using UI_Mod.MVVM.ViewModel;

namespace UI_Mod.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy NewsView.xaml
    /// </summary>
    public partial class NewsView : UserControl
    {
        private int index = 0;
        SliderImage slideImgs = new SliderImage();

        private List<string> slideDescriptions = new List<string>
        {
            "Largest defense system tender in europe", "Greenhouse gas emissions. What are the factories solutions?",
            "Explore nature: the quietest place in Europe","Learn about the positive impact of group work"

        };

        private DispatcherTimer timer;

        public NewsView()
        {
            InitializeComponent();

            DataContext = new NewsViewModel();

            timer = new DispatcherTimer();
            timer.Interval=TimeSpan.FromSeconds(1);
            timer.Tick+= Timer_Tick;
            timer.Start();

            slideImgs.AddImage("polit.png");
            slideImgs.AddImage("factory.png");
            slideImgs.AddImage("forest.png");
            slideImgs.AddImage("roomBus.png");

            imgSlide.Source = new BitmapImage(new Uri(slideImgs.imagesList[0], UriKind.Relative ) );

            UpdateSlideDesc();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClockTxt.Text=DateTime.Now.ToString("G");
        }

        //descriptions under all of the images during slide show
        private void UpdateSlideDesc()
        {
            SlideDescription.Text = slideDescriptions[index];
        }


        //left button (PREVIOUS -)
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (index > 0)
            {

                index -= 1;
                imgSlide.Source = new BitmapImage(new Uri(slideImgs.imagesList[index], UriKind.Relative));
                UpdateSlideDesc();

            }

            
        }

        //right button (NEXT +)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (index < slideImgs.imagesList.Count-1)
            {

                index += 1;
                imgSlide.Source = new BitmapImage(new Uri(slideImgs.imagesList[index], UriKind.Relative));
                UpdateSlideDesc();

            }

            
        }
    }

    class SliderImage
    {
        private string urlPath;
        public List<string> imagesList;
        public SliderImage()
        {
            imagesList = new List<string>();
        }

        public void AddImage(string imgName)
        {
            urlPath = "/Images/"+imgName;
            imagesList.Add(urlPath);

        }
    }
}
