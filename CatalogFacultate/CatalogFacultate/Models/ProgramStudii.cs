using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFacultate.Models
{
    public class ProgrameStudii
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int CicluInvatamantId { get; set; }
    }
}
