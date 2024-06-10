using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFacultate.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Cod { get; set; }
        public string Nume { get; set; }
        public string Acronim { get; set; }
        public int Credite { get; set; }
        public int AnStudiuId { get; set; }
    }
}
