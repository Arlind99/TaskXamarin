using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TaskXamarin.View;
using Xamarin.Forms;

namespace TaskXamarin.ViewModel
{
    public class NewTaskViewModel : INotifyPropertyChanged
    {

        public ICommand Previews => new Command(previewsView);

        private async void previewsView()
        {
            Home home = new Home();
            home.BindingContext = new Home();
            await App.Instance.PopAsync();
            Debug.WriteLine("logout button pressed");
        }

        public NewTaskViewModel()
        {
            //NewTask newTask = new NewTask();
            //newTask.BindingContext = new NewTask();
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
