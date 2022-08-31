using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Complect : INotifyPropertyChanged
    {
        public int Id { get; set; }

        string? mark;

        public string? Mark
        {
            get { return mark; }
            set
            {
                mark = value;
                OnPropertyChanged("number");
            }
        }

        string? number;

        public string? Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("number");
            }
        }

        public Building? Building { get; set; }
        public int BuildingId { get; set; }


        string? complect_key;
        public string? Complect_key
        {
            get { return complect_key; }
            set
            {
                complect_key = mark + number.ToString();
                OnPropertyChanged("complect_key");
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
        public List<Document> Document_list { get; set; } = new List<Document>();


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

    
}
