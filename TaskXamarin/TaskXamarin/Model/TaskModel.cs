using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TaskXamarin.Model
{
    class TaskModel
    {

        private string id;
        private string description;
        private string taskCreater;

        public string ID
        {
            get { return id; }
            set { 
                id = value;
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value;
            }
        }

        public string TaskCreater
        {
            get { return taskCreater; }
            set { taskCreater = value;
            }
        }

        private bool isImportant;

        public bool IsImportant
        {
            get { return isImportant; }
            set { isImportant = value; }
        }

    }
}
