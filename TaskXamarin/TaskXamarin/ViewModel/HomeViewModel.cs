using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TaskXamarin.Model;
using Xamarin.Forms;

namespace TaskXamarin.ViewModel
{
    class HomeViewModel : INotifyPropertyChanged
    {
        private List<TaskModel> lvTask;
        private float pbTask;
        private string lblCompleted;

        public string LblCompleted
        {
            get
            {
                return lblCompleted;
            }
            set
            {
                SetProperty(ref lblCompleted, value);
            }
        }


        private string entUsername;

        public string EntUsername
        {
            get { return entUsername; }
            set {  SetProperty(ref entUsername, value); }
        }


        private float CompletedImportantTask;
        public HomeViewModel(string entUsername)
        {

            EntUsername = $"Hello, {entUsername}";
            LvTask = new List<TaskModel>();
            fillData();
            float SizeOfList = LvTask.Count;
            PbTask = getNOImportantTasks(SizeOfList);
            LblCompleted = $"{CompletedImportantTask} out of {SizeOfList} Tasks are completed";
        }

        private float getNOImportantTasks(float sizeOfList)
        {
            float sum = 0;
            foreach (var task in LvTask)
            {
                if (task.IsImportant)
                {
                    sum++;
                }
            }
            CompletedImportantTask = sum;
            float result = sum / sizeOfList;
            return result;
        }

        private void fillData()
        {
            LvTask.Add(new TaskModel { ID = "1", Description = "Testing the first line", TaskCreater = "Arlind Podrimcaku", IsImportant = true });
            LvTask.Add(new TaskModel { ID = "2", Description = "First things first", TaskCreater = "Arlind Podrimcaku", IsImportant = false });
            LvTask.Add(new TaskModel { ID = "3", Description = "Let me know more about this when you are around", TaskCreater = "Arlind Podrimcaku", IsImportant = false });
            LvTask.Add(new TaskModel { ID = "4", Description = "Let me know more about this when you are around", TaskCreater = "Arlind Podrimcaku", IsImportant = false });
            LvTask.Add(new TaskModel { ID = "5", Description = "Let me know more about this when you are around", TaskCreater = "Arlind Podrimcaku", IsImportant = true });
            LvTask.Add(new TaskModel { ID = "6", Description = "Testing the first line", TaskCreater = "Arlind Podrimcaku", IsImportant = false });
            LvTask.Add(new TaskModel { ID = "7", Description = "First things first", TaskCreater = "Arlind Podrimcaku", IsImportant = true });
        }

        public List<TaskModel> LvTask
        {
            get
            {
                return lvTask;
            }
            set
            {
                SetProperty(ref lvTask, value);
            }
        }

        public float PbTask
        {
            get
            {
                return pbTask;
            }
            set
            {
                SetProperty(ref pbTask, value);
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
