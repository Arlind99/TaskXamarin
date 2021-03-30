using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using TaskXamarin.View;

namespace TaskXamarin.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private string entUsername;
        private string entPassword;
        private string lblError;
        public ICommand btnLogin => new Command(async () => await checkLogin());

        //this is temporary part which has to be deleted after the process has been finished
        //this constructor fills the data Entry with data for login
        public LoginViewModel()
        {
            entUsername = "testtest";
            EntPassword = "1111";
        }

        private async Task checkLogin()
        {
            if (entUsername != null && entPassword != null)
            {
                if (entUsername == "testtest" && entPassword == "1111")
                {
                    Home home = new Home();
                    home.BindingContext = new HomeViewModel(EntUsername);
                    await App.Instance.PushAsync(home);
                }
                else
                {
                    LblError = "Username or Password is incorrect";
                }
            }
            else
            {
                LblError = "Username or Password is empty";
            }
        }

        public string EntUsername
        {
            get
            {
                return entUsername;
            }

            set
            {
                entUsername = value;
            }
        }

        public string EntPassword
        {
            get
            {
                return entPassword;
            }

            set
            {
                entPassword = value;
            }
        }

        public string LblError
        {
            get
            {
                return lblError;
            }
            set
            {
                SetProperty(ref lblError, value);
            }
        }

        //notifier - we need this so that we can communicate with view and change data in view
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value,
        [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
