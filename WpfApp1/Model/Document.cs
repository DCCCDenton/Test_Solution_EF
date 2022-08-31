using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Document : INotifyPropertyChanged
    {
        public int Id { get; set; }

        string? type;

        public string? Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("type");
            }
        }

        string? name;

        public string? Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("name");
            }
        }

        public Complect? Complect { get; set; }
        public int ComplectId { get; set; }

        int number;
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 1)
                {
                    number = 1;
                    OnPropertyChanged("number");
                }
            }
        }

        string? document_key;
        public string? Document_key
        {
            get { return document_key; }
            set 
            { 
                document_key = type + number.ToString();
                OnPropertyChanged("document_key");
            }
        }

        private Boolean isSelected;
        public Boolean IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
