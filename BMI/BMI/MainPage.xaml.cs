using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BMI_Button_Ciick(Object sender,EventArgs e)
        {
            double dHeight = double.Parse(height.Text);
            double dWeight = double.Parse(weight.Text);

            double dBMI = dWeight / dHeight / dHeight;
            string message;

            if(dBMI >= 30.0 )
            {
                message = "肥満";
            }

            else if(dBMI >= 25.0)
            {
                message = "前肥満";
            }

            else if (dBMI >= 18.5)
            {
                message = "普通体重";
            }

            else if (dBMI >= 17.0)
            {
                message = "痩せぎみ";
            }

            else if (dBMI >= 16.0)
            {
                message = "痩せ";
            }

            else 
            {
                message = "痩せすぎ";
            }

            DisplayAlert("BMI", dBMI+":"+message, "OK");
        }
    }
}
