using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogFacultate.Models
{
    public class Student
    {
        public string NumarMatricol { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string InitialaTata { get; set; }
        public string CNP { get; set; }
        public DateTime DataInscrierii { get; set; }
        public string CicluInvatamant { get; set; }
        public double MediaInscriere { get; set; }

        public override string ToString()
    {
        return $"{NumarMatricol} - {Nume} {Prenume} ({InitialaTata})";
    }
    }
}
