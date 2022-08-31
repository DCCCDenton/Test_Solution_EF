using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.MVVM
{
    internal class BuildingVM : INotifyPropertyChanged
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


        public event PropertyChangedEventHandler PropertyChanged; //реализация интерфейса
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
