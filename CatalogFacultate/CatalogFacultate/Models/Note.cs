using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFacultate.Models
{
    public class Nota
    {
        public string Student { get; set; }
        public string Disciplina { get; set; }
        public string Semestru { get; set; }
        public int ValoareNota { get; set; }
    }
}
