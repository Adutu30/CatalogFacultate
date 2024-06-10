using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFacultate.Models
{
    public class Grupa
    {
        public string Cod { get; set; }
        public int AnStudiuId { get; set; }
        public List<Student> Student { get; set; } = new List<Student>();
    }
}
