using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercise2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public bool switchCase = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (switchCase == true)
            {
                switchCase = false;
            }
            else
            {
                switchCase = true;
            }
            if (switchCase == true)
            {
                messageLabel.IsVisible = true;
            }
            else
            {
                messageLabel.IsVisible = false;
            }
        }
    }
}
