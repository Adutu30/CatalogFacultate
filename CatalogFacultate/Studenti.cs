namespace CatalogFacultate
{
    public class Studenti
    {
        public int Id { get; set; }
        public string NumarMatricol { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string InitialaTatalui { get; set; }
        public string CNP { get; set; }
        public DateTime DataInscrierii { get; set; }
        public int CicluriInvatamantId { get; set; }
        public double MedieInscriere { get; set; }
    }
   
}