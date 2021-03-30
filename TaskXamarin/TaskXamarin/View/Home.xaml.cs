using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            LblMine.BackgroundColor = Color.FromHex("#ffffff");
            LblAll.BackgroundColor = Color.FromHex("#DEDEE5");
        }

        private void MineLabel_Tapped(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackgroundColor = Color.FromHex("#ffffff");
            LblAll.BackgroundColor = Color.FromHex("#DEDEE5");

        }

        private void AllLabel_Tapped(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackgroundColor = Color.FromHex("#ffffff");
            LblMine.BackgroundColor = Color.FromHex("#DEDEE5");
        }
    }
}