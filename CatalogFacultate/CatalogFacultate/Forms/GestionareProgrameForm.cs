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
    public partial class GestionareProgrameForm : Form
    {
        private List<string> programe;
        private const string FilePath = "programe.txt";

        public GestionareProgrameForm()
        {
            InitializeComponent();
            programe = new List<string>();
            LoadProgrameFromFile();
            RefreshProgrameList();
        }

        private void GestionareProgrameForm_Load(object sender, EventArgs e)
        {
            LoadProgrameFromFile();
            RefreshProgrameList();
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            string numeProgram = txtNumeProgram.Text.Trim();
            if (!string.IsNullOrEmpty(numeProgram) && !programe.Contains(numeProgram))
            {
                programe.Add(numeProgram);
                SaveProgrameToFile();
                RefreshProgrameList();
                txtNumeProgram.Clear();
            }
            else
            {
                MessageBox.Show("Numele programului este invalid sau deja există.");
            }
        }

        private void btnDeleteProgram_Click(object sender, EventArgs e)
        {
            if (lstPrograme.SelectedItem != null)
            {
                programe.Remove(lstPrograme.SelectedItem.ToString());
                SaveProgrameToFile();
                RefreshProgrameList();
            }
        }

        private void RefreshProgrameList()
        {
            lstPrograme.Items.Clear();
            foreach (var program in programe)
            {
                lstPrograme.Items.Add(program);
            }
        }

        private void LoadProgrameFromFile()
        {
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                programe.AddRange(lines);
            }
        }

        private void SaveProgrameToFile()
        {
            File.WriteAllLines(FilePath, programe);
        }

        private void lstPrograme_DoubleClick(object sender, EventArgs e)
        {
            var GestionareAni = new GestionareAniForm();
            GestionareAni.ShowDialog();
        }
    }
}
