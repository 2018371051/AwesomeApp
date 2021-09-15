using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        int count;
        string message;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            count = 0;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            if(button1 == null)
                button1 = ((Button)sender);
            count++;
            message = "Tu me has presionado {0} veces";
            button1.Text = string.Format(message, count);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            message = "Presióname";
            if (button1 != null)
            {
                button1.Text = message;
                count = 0;
            }
        }
    }
}
