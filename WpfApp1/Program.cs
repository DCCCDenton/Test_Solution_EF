using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Context;
using WpfApp1.Model;

namespace WpfApp1
{
    public class Program
    {
        public void Run()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Project prj1 = new Project { Project_number = "12-123-65", Project_name = "prj111" };
                Project prj2 = new Project { Project_number = "12-456-98", Project_name = "prj222" };
                Building obj1 = new Building { Project = prj1, Object_cod = "01", Object_name = "House1" };
                Building obj2 = new Building { Project = prj1, Object_cod = "02", Object_name = "House2" };
                Complect IOS1 = new Complect { Building = obj2, Mark = "ИОС1" };
                Complect IOS5 = new Complect { Building = obj1, Mark = "ИОС5" };
                Document draw = new Document { Complect = IOS1, Name = "План" };
                Document spec = new Document { Complect = IOS1, Name = "Спецификация" };


                Catalog executors = new Catalog { catalog_name = "executors" };
                Write ivanov = new Write { Name = "Ivanov", Catalog = executors };
                Write petrov = new Write { Name = "Petrov", Catalog = executors };


                db.Projects.AddRange(prj1, prj2);
                db.Buildings.AddRange(obj1, obj2);
                db.Complects.AddRange(IOS1, IOS5);
                db.Documents.AddRange(draw, spec);
                db.Catalogs.Add(executors);
                db.Writes.AddRange(ivanov, petrov);
                db.SaveChanges();
                ObservableCollection<Project> Project_list = db.Projects.Local.ToObservableCollection();
            }

        }
    }
}
