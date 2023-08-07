using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Mod.MVVM.ViewModel
{
    internal class NewsViewModel
    {

        public ObservableCollection<string> Tags { get; set; }

        public NewsViewModel()
        {
            Tags = new ObservableCollection<string>();

            Tags.Add("Politics");
            Tags.Add("Nature");
            Tags.Add("Industry");
            Tags.Add("Data analysis");
            Tags.Add("Around the world");
            Tags.Add("Business");

        }

    }
}
