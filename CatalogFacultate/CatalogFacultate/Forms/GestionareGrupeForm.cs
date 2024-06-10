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
    public partial class GestionareGrupeForm : Form
    {
        private List<Grupa> grupe;

        public GestionareGrupeForm()
        {
            InitializeComponent();
            grupe = new List<Grupa>();

            // Încarcă grupele salvate din fișier la pornirea aplicației
            LoadGrupeFromTextFile();
        }

        private void btnAddGrupa_Click(object sender, EventArgs e)
        {
            var cod = txtCodGrupa.Text;
            var an = txtAn.Text;

            if (!string.IsNullOrEmpty(cod) && !string.IsNullOrEmpty(an))
            {
                var grupa = new Grupa
                {
                    Cod = cod,
                    An = an
                };

                grupe.Add(grupa);
                lstGrupe.Items.Add(grupa.ToString());
                txtCodGrupa.Clear();
                txtAn.Clear();

                // Salvează lista actualizată de grupe în fișier
                SaveGrupeToTextFile();
            }
        }

        private void btnRemoveGrupa_Click(object sender, EventArgs e)
        {
            if (lstGrupe.SelectedItem != null)
            {
                var selectedGrupa = lstGrupe.SelectedItem.ToString();
                lstGrupe.Items.Remove(lstGrupe.SelectedItem);

                var grupaToRemove = grupe.Find(g => g.ToString() == selectedGrupa);
                if (grupaToRemove != null)
                {
                    grupe.Remove(grupaToRemove);

                    // Salvează lista actualizată de grupe în fișier
                    SaveGrupeToTextFile();
                }
            }
        }

        private void LoadGrupeFromTextFile()
        {
            string filePath = "grupe.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    var data = line.Split('|');
                    var grupa = new Grupa
                    {
                        Cod = data[0],
                        An = data[1]
                    };

                    grupe.Add(grupa);
                    lstGrupe.Items.Add(grupa.ToString());
                }
            }
        }

        private void SaveGrupeToTextFile()
        {
            string filePath = "grupe.txt";
            var lines = new List<string>();
            foreach (var grupa in grupe)
            {
                lines.Add($"{grupa.Cod}|{grupa.An}");
            }
            File.WriteAllLines(filePath, lines);
        }

        private class Grupa
        {
            public string Cod { get; set; }
            public string An { get; set; }

            public override string ToString()
            {
                return $"{Cod} - An: {An}";
            }
        }

        private void txtCodGrupa_Enter(object sender, EventArgs e)
        {
            if (txtCodGrupa.Text == "Cod Grupa")
            {
                txtCodGrupa.Text = "";
                txtCodGrupa.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCodGrupa_Leave(object sender, EventArgs e)
        {
            if (txtCodGrupa.Text == "")
            {
                txtCodGrupa.Text = "Cod Grupa";
                txtCodGrupa.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtAn_Enter(object sender, EventArgs e)
        {
            if (txtAn.Text == "An")
            {
                txtAn.Text = "";
                txtAn.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtAn_Leave(object sender, EventArgs e)
        {
            if (txtAn.Text == "")
            {
                txtAn.Text = "An";
                txtAn.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void lstGrupe_DoubleClick(object sender, EventArgs e)
        {
            var GestionareStudent = new GestionareStudentiForm();
            GestionareStudent.ShowDialog();
        }
    }
}
