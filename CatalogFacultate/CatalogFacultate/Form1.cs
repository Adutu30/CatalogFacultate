using System;
using System.Windows.Forms;
using CatalogFacultate.Forms;

namespace CatalogFacultate

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestionareCicluri_Click(object sender, EventArgs e)
        {
            var form = new GestionareCicluriForm();
            form.Show();
        }

        private void btnGestionarePrograme_Click(object sender, EventArgs e)
        {
            var form = new GestionareProgrameForm();
            form.Show();
        }

        private void btnGestionareAni_Click(object sender, EventArgs e)
        {
            var form = new GestionareAniForm();
            form.Show();
        }

        private void btnGestionareDiscipline_Click(object sender, EventArgs e)
        {
            var form = new GestionareDisciplineForm();
            form.Show();
        }

        private void btnGestionareStudenti_Click(object sender, EventArgs e)
        {
            var form = new GestionareStudentiForm();
            form.Show();
        }

        private void btnGestionareGrupe_Click(object sender, EventArgs e)
        {
            var form = new GestionareGrupeForm();
            form.Show();
        }

        private void btnGestionareCadre_Click(object sender, EventArgs e)
        {
            var form = new GestionareCadreForm();
            form.Show();
        }

    }
}