using CatalogFacultate.Models;
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
    public partial class GestionareCicluriForm : Form
    {
        private List<string> cicluri;
        private const string FilePath = "cicluri.txt";

        public GestionareCicluriForm()
        {
            InitializeComponent();
            cicluri = new List<string>();
            LoadCicluriFromFile();
            RefreshCicluriList();
        }

        private void GestionareCicluriForm_Load(object sender, EventArgs e)
        {
            LoadCicluriFromFile();
            RefreshCicluriList();
        }

        private void btnAddCiclu_Click(object sender, EventArgs e)
        {
            string numeCiclu = txtNumeCiclu.Text.Trim();
            if (!string.IsNullOrEmpty(numeCiclu) && !cicluri.Contains(numeCiclu))
            {
                cicluri.Add(numeCiclu);
                SaveCicluriToFile();
                RefreshCicluriList();
                txtNumeCiclu.Clear();
            }
            else
            {
                MessageBox.Show("Numele ciclului este invalid sau deja există.");
            }
        }

        private void btnDeleteCiclu_Click(object sender, EventArgs e)
        {
            if (lstCicluri.SelectedItem != null)
            {
                cicluri.Remove(lstCicluri.SelectedItem.ToString());
                SaveCicluriToFile();
                RefreshCicluriList();
            }
        }

        private void RefreshCicluriList()
        {
            lstCicluri.Items.Clear();
            foreach (var ciclu in cicluri)
            {
                lstCicluri.Items.Add(ciclu);
            }
        }

        private void LoadCicluriFromFile()
        {
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                cicluri.AddRange(lines);
            }
        }

        private void SaveCicluriToFile()
        {
            File.WriteAllLines(FilePath, cicluri);
        }

        private void lstCicluri_DoubleClick(object sender, EventArgs e)
        {
            var GestionarePrograme = new GestionareProgrameForm();
            GestionarePrograme.ShowDialog();
        }
    }
}
