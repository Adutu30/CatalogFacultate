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

namespace CatalogFacultate.Forms
{
    public partial class GestionareStudentiForm : Form
    {
        private List<Student> studenti;

        public GestionareStudentiForm()
        {
            InitializeComponent();
            studenti = new List<Student>();

            // Încarcă studenții salvați din fișier la pornirea aplicației
            LoadStudentiFromTextFile();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var numarMatricol = txtNumarMatricol.Text;
            var nume = txtNume.Text;
            var prenume = txtPrenume.Text;
            var initialaTata = txtInitialaTata.Text;
            var cnp = txtCNP.Text;
            var dataInscrierii = txtDataInscrierii.Text;
            var cicluInvatamant = txtCicluInvatamant.Text;
            var mediaInscriere = txtMediaInscriere.Text;

            if (!string.IsNullOrEmpty(numarMatricol) && !string.IsNullOrEmpty(nume) &&
                !string.IsNullOrEmpty(prenume) && !string.IsNullOrEmpty(cnp))
            {
                var student = new Student
                {
                    NumarMatricol = numarMatricol,
                    Nume = nume,
                    Prenume = prenume,
                    InitialaTata = initialaTata,
                    CNP = cnp,
                    DataInscrierii = dataInscrierii,
                    CicluInvatamant = cicluInvatamant,
                    MediaInscriere = mediaInscriere
                };

                studenti.Add(student);
                lstStudenti.Items.Add(student.ToString());
                ClearTextBoxes();

                // Salvează lista actualizată de studenți în fișier
                SaveStudentiToTextFile();
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lstStudenti.SelectedItem != null)
            {
                var selectedStudent = lstStudenti.SelectedItem.ToString();
                lstStudenti.Items.Remove(lstStudenti.SelectedItem);

                var studentToRemove = studenti.Find(s => s.ToString() == selectedStudent);
                if (studentToRemove != null)
                {
                    studenti.Remove(studentToRemove);

                    // Salvează lista actualizată de studenți în fișier
                    SaveStudentiToTextFile();
                }
            }
        }

        private void LoadStudentiFromTextFile()
        {
            string filePath = "studenti.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    var data = line.Split('|');
                    var student = new Student
                    {
                        NumarMatricol = data[0],
                        Nume = data[1],
                        Prenume = data[2],
                        InitialaTata = data[3],
                        CNP = data[4],
                        DataInscrierii = data[5],
                        CicluInvatamant = data[6],
                        MediaInscriere = data[7]
                    };

                    studenti.Add(student);
                    lstStudenti.Items.Add(student.ToString());
                }
            }
        }

        private void SaveStudentiToTextFile()
        {
            string filePath = "studenti.txt";
            var lines = new List<string>();
            foreach (var student in studenti)
            {
                lines.Add($"{student.NumarMatricol}|{student.Nume}|{student.Prenume}|{student.InitialaTata}|{student.CNP}|{student.DataInscrierii}|{student.CicluInvatamant}|{student.MediaInscriere}");
            }
            File.WriteAllLines(filePath, lines);
        }

        private void ClearTextBoxes()
        {
            txtNumarMatricol.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtInitialaTata.Text = "";
            txtCNP.Text = "";
            txtDataInscrierii.Text = "";
            txtCicluInvatamant.Text = "";
            txtMediaInscriere.Text = "";
        }

        private class Student
        {
            public string NumarMatricol { get; set; }
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public string InitialaTata { get; set; }
            public string CNP { get; set; }
            public string DataInscrierii { get; set; }
            public string CicluInvatamant { get; set; }
            public string MediaInscriere { get; set; }

            public override string ToString()
            {
                return $"{NumarMatricol} - {Nume} {Prenume} ({InitialaTata})";
            }
        }

        private void lstStudenti_DoubleClick(object sender, EventArgs e)
        {
            var GestionareNote = new GestionareNoteForm();
            GestionareNote.ShowDialog();
        }
    }
}
