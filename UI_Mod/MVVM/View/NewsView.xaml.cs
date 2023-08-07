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

            imgSlide.Source = new BitmapImage(new Uri(slideImgs.imagesList[0], UriKind.Relative ) );

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClockTxt.Text=DateTime.Now.ToString("G");
        }


        //left button (PREVIOUS -)
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (index > 0)
            {

                index -= 1;
                imgSlide.Source = new BitmapImage(new Uri(slideImgs.imagesList[index], UriKind.Relative));

            }

            
        }

        //right button (NEXT +)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (index < slideImgs.imagesList.Count-1)
            {

                index += 1;
                imgSlide.Source = new BitmapImage(new Uri(slideImgs.imagesList[index], UriKind.Relative));

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

        //<Image Grid.Column="1" Source="/Images/polit.png" Height="323" Width="580" Stretch="UniformToFill" Margin="5" />
        public void AddImage(string imgName)
        {
            urlPath = "/Images/"+imgName;
            imagesList.Add(urlPath);

        }
    }
}
