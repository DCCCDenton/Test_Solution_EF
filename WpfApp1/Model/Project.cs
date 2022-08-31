using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Project : INotifyPropertyChanged
    {
        public int Id { get; set; }
        string? project_number;

        public string? Project_number
        {
            get { return project_number; }
            set
            {
                project_number = value;
                OnPropertyChanged("project_number");
            }
        }

        string? project_name;

        public string? Project_name
        {
            get { return project_name; }
            set
            {
                project_name = value;
                OnPropertyChanged("project_name");
            }
        }

        string? project_excutor;

        public string? Project_excutor
        {
            get { return project_excutor; }
            set
            {
                project_excutor = value;
                OnPropertyChanged("project_excutor");
            }
        }

        string? project_date;

        public string? Project_date
        {
            get { return project_date; }
            set
            {
                project_excutor = value;
                OnPropertyChanged("project_date");
            }
        }

        string? project_change_date;

        public string? Project_change_date
        {
            get { return project_change_date; }
            set
            {
                project_change_date = value;
                OnPropertyChanged("project_date");
            }
        }

        public ObservableCollection<Building> Object_list { get; set; } 
        public Project()
        {
            Object_list = new ObservableCollection<Building>();
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
