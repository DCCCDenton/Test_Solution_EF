using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Catalog
    {
        public int Id { get; set; }
        public string? catalog_name { get; set; }
        public List<Write> Writes { get; set; } = new();
    }
}
