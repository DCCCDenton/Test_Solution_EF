using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Context;
using System.Windows;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp1.MVVM
{
    internal class AppViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Project> project_list;
        public ObservableCollection<Project> Project_list
        {
            get { return project_list; }
            set
            {
                project_list = value;
                OnPropertyChanged("project_list");
            }
        }



        private Building itemBuilding;
        public Building ItemBuilding
        {
            get { return itemBuilding; }
            set
            {
                OnPropertyChanged("IsSelected");
                if (SelectedItem.GetType() == typeof(Building))
                {
                    itemBuilding = (Building)SelectedItem;  
                }
            }
        }


        private object selectedItem;

        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
    
                OnPropertyChanged("IsSelected");


                if (IsSelected == true)
                {
                    SelectedItem = this;
                    var tmp = SelectedItem;
                    MessageBox.Show("Work!!!");
                }
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

        private RelayCommand run;
        public RelayCommand Run
        {
            get
            {
                return run ??
                  (run = new RelayCommand(obj =>
                  {
                      Program prog = new Program();
                      prog.Run();
                  }));
            }
        }
        public AppViewModel()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Project prj1 = new Project { Project_number = "12-123-65", Project_name = "prj111" };
                Project prj2 = new Project { Project_number = "12-456-98", Project_name = "prj222" };
                Building obj1 = new Building { Project = prj1, Object_cod = "01", Object_name = "House1" };
                Building obj2 = new Building { Project = prj1, Object_cod = "02", Object_name = "House2" };
                Building obj3 = new Building { Project = prj2, Object_cod = "01", Object_name = "House1" };
                Building obj4 = new Building { Project = prj2, Object_cod = "02", Object_name = "House2" };
                Complect IOS1 = new Complect { Building = obj2, Mark = "ИОС1" };
                Complect IOS5 = new Complect { Building = obj1, Mark = "ИОС5" };
                Document draw = new Document { Complect = IOS1, Name = "План" };
                Document spec = new Document { Complect = IOS1, Name = "Спецификация" };


                Catalog executors = new Catalog { catalog_name = "executors" };
                Write ivanov = new Write { Name = "Ivanov", Catalog = executors };
                Write petrov = new Write { Name = "Petrov", Catalog = executors };


                db.Projects.AddRange(prj1, prj2);
                db.Buildings.AddRange(obj1, obj2, obj3, obj4);
                db.Complects.AddRange(IOS1, IOS5);
                db.Documents.AddRange(draw, spec);
                db.Catalogs.Add(executors);
                db.Writes.AddRange(ivanov, petrov);
                db.SaveChanges();



                project_list = db.Projects.Local.ToObservableCollection();
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
