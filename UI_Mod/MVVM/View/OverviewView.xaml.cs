using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace UI_Mod.MVVM.View
{
    public partial class OverviewView : UserControl
    {
        public OverviewView()
        {
            InitializeComponent();
            Loaded+= Overview_DL_Evn;
        }

        private void Overview_DL_Evn(object sender, EventArgs e)
        {

            Update_Evnt_DL();
        }

        private void Update_Evnt_DL()
        {
            CultureInfo eng = new CultureInfo("en-GB");
            day_label.Content = DateTime.Now.ToString("dddd, MMMM",eng);
        }
    }

}
