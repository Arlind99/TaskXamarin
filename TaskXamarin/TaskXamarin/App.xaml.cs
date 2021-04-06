using System;
using System.Threading.Tasks;
using TaskXamarin.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskXamarin
{
    public partial class App : Application
    {
        public static App Instance;
        public App()
        {
            if(Instance == null)
            {
                Instance = this;
            }    
            
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public async Task PushAsync(Page page)
        {
            await MainPage.Navigation.PushAsync(page);
        }
        public async Task PopAsync()
        {
            await MainPage.Navigation.PopAsync();
        }
    }
}
