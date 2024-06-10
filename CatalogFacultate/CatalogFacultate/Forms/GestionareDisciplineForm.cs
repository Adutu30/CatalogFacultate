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
    public partial class GestionareDisciplineForm : Form
    {
        private List<Disciplina> discipline;

        public GestionareDisciplineForm()
        {
            InitializeComponent();
            discipline = new List<Disciplina>();

            // Încarcă disciplinele salvate din fișier la pornirea aplicației
            LoadDisciplineFromTextFile();
        }

        private void btnAddDisciplina_Click(object sender, EventArgs e)
        {
            var cod = txtCodDisciplina.Text;
            var nume = txtNumeDisciplina.Text;
            var acronim = txtAcronim.Text;
            var credite = txtCredite.Text;

            if (!string.IsNullOrEmpty(cod) && !string.IsNullOrEmpty(nume) && !string.IsNullOrEmpty(acronim) && !string.IsNullOrEmpty(credite))
            {
                var disciplina = new Disciplina
                {
                    Cod = cod,
                    Nume = nume,
                    Acronim = acronim,
                    Credite = int.Parse(credite)
                };

                discipline.Add(disciplina);
                lstDiscipline.Items.Add(disciplina.ToString());
                txtCodDisciplina.Clear();
                txtNumeDisciplina.Clear();
                txtAcronim.Clear();
                txtCredite.Clear();

                // Salvează lista actualizată de discipline în fișier
                SaveDisciplineToTextFile();
            }
        }

        private void LoadDisciplineFromTextFile()
        {
            string filePath = "discipline.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    var data = line.Split('|');
                    var disciplina = new Disciplina
                    {
                        Cod = data[0],
                        Nume = data[1],
                        Acronim = data[2],
                        Credite = int.Parse(data[3])
                    };

                    discipline.Add(disciplina);
                    lstDiscipline.Items.Add(disciplina.ToString());
                }
            }
        }

        private void SaveDisciplineToTextFile()
        {
            string filePath = "discipline.txt";
            var lines = new List<string>();
            foreach (var disciplina in discipline)
            {
                lines.Add($"{disciplina.Cod}|{disciplina.Nume}|{disciplina.Acronim}|{disciplina.Credite}");
            }
            File.WriteAllLines(filePath, lines);
        }

        private class Disciplina
        {
            public string Cod { get; set; }
            public string Nume { get; set; }
            public string Acronim { get; set; }
            public int Credite { get; set; }

            public override string ToString()
            {
                return $"{Cod} - {Nume} ({Acronim}), Credite: {Credite}";
            }
        }

        private void lstDiscipline_DoubleClick(object sender, EventArgs e)
        {
            var GestionareCadre =  new GestionareCadreForm();
            GestionareCadre.ShowDialog();
        }
    }
}
