using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogFacultate.Models;

namespace CatalogFacultate.Forms
{
    public partial class GestionareNoteForm : Form
    {
        public GestionareNoteForm()
        {
            InitializeComponent();
        }

        private void btnAdaugaNota_Click(object sender, EventArgs e)
        {
            string numarMatricol = txtNumarMatricol.Text;
            string disciplina = txtDisciplina.Text;
            string nota = txtNota.Text;

            if (string.IsNullOrEmpty(numarMatricol) || string.IsNullOrEmpty(disciplina) || string.IsNullOrEmpty(nota))
            {
                MessageBox.Show("Te rog să completezi toate câmpurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(nota, out double notaValue))
            {
                MessageBox.Show("Nota trebuie să fie un număr.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newLine = $"{numarMatricol}|{disciplina}|{notaValue}";
            File.AppendAllText("note.txt", newLine + Environment.NewLine);

            txtNumarMatricol.Clear();
            txtDisciplina.Clear();
            txtNota.Clear();

            MessageBox.Show("Nota a fost adăugată cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenereazaCatalog_Click(object sender, EventArgs e)
        {
            GenerateCatalog();
            VizualizareCatalogForm vizualizareCatalogForm = new VizualizareCatalogForm();
            vizualizareCatalogForm.ShowDialog();
        }

        private void GenerateCatalog()
        {
            var studenti = CitesteStudenti("studenti.txt");
            var discipline = CitesteDiscipline("discipline.txt");
            var note = CitesteNote("note.txt");

            var catalogData = new List<string>
            {
                "NumarMatricol|Nume|Prenume|Disciplina|Nota|Media|Stare"
            };

            foreach (var student in studenti)
            {
                var noteStudent = note.Where(n => n.Item1 == student.NumarMatricol).ToList();
                double media = noteStudent.Any() ? noteStudent.Average(n => n.Item3) : 0.0;
                string stare = media >= 5.0 ? "integralist" : "restantier";

                foreach (var nota in noteStudent)
                {
                    string disciplina = discipline.FirstOrDefault(d => d.Item1 == nota.Item2)?.Item2 ?? "Necunoscut";
                    catalogData.Add($"{student.NumarMatricol}|{student.Nume}|{student.Prenume}|{disciplina}|{nota.Item3}|{media:F2}|{stare}");
                }
            }

            File.WriteAllLines("catalog.txt", catalogData);
        }

        private List<Student> CitesteStudenti(string filepath)
        {
            var studenti = new List<Student>();
            if (File.Exists(filepath))
            {
                foreach (var line in File.ReadLines(filepath))
                {
                    var data = line.Split('|');
                    if (data.Length >= 8)
                    {
                        studenti.Add(new Student
                        {
                            NumarMatricol = data[0],
                            Nume = data[1],
                            Prenume = data[2],
                            InitialaTata = data[3],
                            CNP = data[4],
                            DataInscrierii = DateTime.Parse(data[5]),
                            CicluInvatamant = data[6],
                            MediaInscriere = double.Parse(data[7])
                        });
                    }
                }
            }
            return studenti;
        }

        private List<Tuple<string, string>> CitesteDiscipline(string filepath)
        {
            var discipline = new List<Tuple<string, string>>();
            if (File.Exists(filepath))
            {
                foreach (var line in File.ReadLines(filepath))
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 2)
                    {
                        discipline.Add(Tuple.Create(parts[0], parts[1]));
                    }
                }
            }
            return discipline;
        }

        private List<Tuple<string, string, double>> CitesteNote(string filepath)
        {
            var note = new List<Tuple<string, string, double>>();
            if (File.Exists(filepath))
            {
                foreach (var line in File.ReadLines(filepath))
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 3 && double.TryParse(parts[2], out double notaValue))
                    {
                        note.Add(Tuple.Create(parts[0], parts[1], notaValue));
                    }
                }
            }
            return note;
        }
    }
}