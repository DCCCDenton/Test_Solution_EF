using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    internal class Building : INotifyPropertyChanged
    {
        public int Id { get; set; }

        string? object_cod;

        public string? Object_cod
        {
            get { return object_cod; }
            set
            {
                object_cod = value;
                OnPropertyChanged("object_cod");
            }
        }

        string? object_name;

        public string? Object_name
        {
            get { return object_name; }
            set
            {
                object_name = value;
                OnPropertyChanged("object_name");
            }
        }

        string? object_executor;

        public string? Object_executor
        {
            get { return object_cod; }
            set
            {
                object_cod = value;
                OnPropertyChanged("object_executor");
            }
        }

       

        private bool isSelected;
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public Project? Project { get; set; }
        public int ProjectId { get; set; }
        public List<Complect> Complect_list { get; set; } = new List<Complect>();

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
