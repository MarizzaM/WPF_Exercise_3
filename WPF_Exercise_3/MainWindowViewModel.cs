using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Exercise_3
{
    class MainWindowViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string m_name;

        public string Name
        {
            get
            {
                return this.m_name;
            }
            set
            {
                this.m_name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Error {
            get
            {
                return string.Empty;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (String.IsNullOrEmpty(Name))
                {
                    return "Please enter a Name";
                } 
                else if ("Name" == columnName)
                {
                    if (Name.Length > 10)
                    {
                        return "Name is ver 10 characters";
                    }
                }
                return string.Empty;
            }
        }
    }
}
