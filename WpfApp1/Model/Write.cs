using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Write
    {
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public Catalog? Catalog { get; set; }
        public string? ShortName { get; set; }   
        public string? Name { get; set; }
    }
}
