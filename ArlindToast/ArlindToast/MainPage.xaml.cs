using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArlindToast.Interface;
using Xamarin.Forms;

namespace ArlindToast
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IMessage>().ShortAlert("I'm Short Alert");
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IMessage>().LongAlert("I'm Long Alert");
        }
    }
}
