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
    public partial class PrimaryContentView : ContentView
    {
        public PrimaryContentView()
        {
            InitializeComponent();
        }
        private void FrameHighTapped(object sender, EventArgs e)
        {
            fNormal.BackgroundColor = Color.Transparent;
            fHigh.BackgroundColor = Color.White;
        }
        private void FrameNormalTapped(object sender, EventArgs e)
        {
            fNormal.BackgroundColor = Color.White;
            fHigh.BackgroundColor = Color.Transparent;
        }
    }
}