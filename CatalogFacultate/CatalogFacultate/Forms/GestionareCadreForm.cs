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
    public partial class GestionareCadreForm : Form
    {
        private List<CadruDidactic> cadreDidactice;

        public GestionareCadreForm()
        {
            InitializeComponent();
            cadreDidactice = new List<CadruDidactic>();
            LoadCadreDidactice();
        }

        private void btnAddCadru_Click(object sender, EventArgs e)
        {
            var cadru = new CadruDidactic
            {
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text,
                MarcaAngajat = txtMarcaAngajat.Text,
                Titlu = txtTitlu.Text,
                Post = cmbPost.SelectedItem.ToString()
            };

            cadreDidactice.Add(cadru);
            SaveCadreDidactice();
            RefreshCadreList();
        }

        private void btnEditCadru_Click(object sender, EventArgs e)
        {
            if (lstCadre.SelectedItem != null)
            {
                var cadru = cadreDidactice[lstCadre.SelectedIndex];
                cadru.Nume = txtNume.Text;
                cadru.Prenume = txtPrenume.Text;
                cadru.MarcaAngajat = txtMarcaAngajat.Text;
                cadru.Titlu = txtTitlu.Text;
                cadru.Post = cmbPost.SelectedItem.ToString();

                SaveCadreDidactice();
                RefreshCadreList();
            }
        }

        private void btnDeleteCadru_Click(object sender, EventArgs e)
        {
            if (lstCadre.SelectedItem != null)
            {
                cadreDidactice.RemoveAt(lstCadre.SelectedIndex);
                SaveCadreDidactice();
                RefreshCadreList();
            }
        }

        private void lstCadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCadre.SelectedItem != null)
            {
                var cadru = cadreDidactice[lstCadre.SelectedIndex];
                txtNume.Text = cadru.Nume;
                txtPrenume.Text = cadru.Prenume;
                txtMarcaAngajat.Text = cadru.MarcaAngajat;
                txtTitlu.Text = cadru.Titlu;
                cmbPost.SelectedItem = cadru.Post;
            }
        }

        private void LoadCadreDidactice()
        {
            if (File.Exists("cadreDidactice.txt"))
            {
                var lines = File.ReadAllLines("cadreDidactice.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    var cadru = new CadruDidactic
                    {
                        Nume = parts[0],
                        Prenume = parts[1],
                        MarcaAngajat = parts[2],
                        Titlu = parts[3],
                        Post = parts[4]
                    };
                    cadreDidactice.Add(cadru);
                }
                RefreshCadreList();
            }
        }

        private void SaveCadreDidactice()
        {
            var lines = new List<string>();
            foreach (var cadru in cadreDidactice)
            {
                lines.Add($"{cadru.Nume},{cadru.Prenume},{cadru.MarcaAngajat},{cadru.Titlu},{cadru.Post}");
            }
            File.WriteAllLines("cadreDidactice.txt", lines);
        }

        private void RefreshCadreList()
        {
            lstCadre.Items.Clear();
            foreach (var cadru in cadreDidactice)
            {
                lstCadre.Items.Add($"{cadru.Nume} {cadru.Prenume} ({cadru.MarcaAngajat})");
            }
        }

        private void lstCadre_DoubleClick(object sender, EventArgs e)
        {
            var GestionareGrupe = new GestionareGrupeForm();
            GestionareGrupe.ShowDialog();
        }
    }

    public class CadruDidactic
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string MarcaAngajat { get; set; }
        public string Titlu { get; set; }
        public string Post { get; set; }
    }
}
