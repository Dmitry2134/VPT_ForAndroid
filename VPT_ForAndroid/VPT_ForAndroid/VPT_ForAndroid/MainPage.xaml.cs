using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VPT_ForAndroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void Init()
        {
            Button btnOsnSved = new Button();
            btnOsnSved.Text = "Основные сведения";

            Image imgOsnSved = new Image();
            imgOsnSved.Source = "osnSvedenia.png";
            imgOsnSved.HeightRequest = 30;
            imgOsnSved.WidthRequest = 30;

            
        }

        private void btnOsnSved_Clicked(object sender, EventArgs e)
        {

        }
    }
}
