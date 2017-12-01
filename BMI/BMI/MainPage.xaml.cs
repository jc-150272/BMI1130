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

            if(dHeight > 3)
            {
                dHeight /= 100;
            }

            if(dBMI < 18.5 )
            {
                DisplayAlert("BMI",dBMI + ":低体重","OK");
            }

            else if(dBMI < 25.0)
            {
                DisplayAlert("BMI", dBMI + ":普通体重", "OK");
            }

            else if (dBMI < 30.0)
            {
                DisplayAlert("BMI", dBMI + ":肥満(1度)", "OK");
            }

            else if (dBMI < 35.0)
            {
                DisplayAlert("BMI", dBMI + ":肥満(2度)", "OK");
            }

            else if (dBMI < 40.0)
            {
                DisplayAlert("BMI", dBMI + ":肥満(3度)", "OK");
            }

            else 
            {
                DisplayAlert("BMI", dBMI + ":肥満(4度)", "OK");
            }

        }
    }
}
