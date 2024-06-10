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
    public partial class GestionareAniForm : Form
    {
        private List<string> aniDeStudii;

        public GestionareAniForm()
        {
            InitializeComponent();
            aniDeStudii = new List<string>();

            // Încarcă anii de studii salvați din fișier la pornirea aplicației
            LoadAniFromTextFile();
        }

        private void btnAddAn_Click(object sender, EventArgs e)
        {
            var numeAn = txtNumeAn.Text;
            if (!string.IsNullOrEmpty(numeAn))
            {
                aniDeStudii.Add(numeAn);
                lstAni.Items.Add(numeAn);
                txtNumeAn.Clear();

                // Salvează lista actualizată de ani de studii în fișier
                SaveAniToTextFile();
            }
        }

        private void LoadAniFromTextFile()
        {
            string filePath = "ani.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    aniDeStudii.Add(line);
                    lstAni.Items.Add(line);
                }
            }
        }

        private void SaveAniToTextFile()
        {
            string filePath = "ani.txt";
            File.WriteAllLines(filePath, aniDeStudii);
        }

        private void lstAni_DoubleClick(object sender, EventArgs e)
        {
            var GestionareDiscipline = new GestionareDisciplineForm();
            GestionareDiscipline.ShowDialog();
        }
    }
}
