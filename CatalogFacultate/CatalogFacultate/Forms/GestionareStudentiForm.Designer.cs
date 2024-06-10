namespace CatalogFacultate.Forms
{
    partial class GestionareStudentiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumarMatricol = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtInitialaTata = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtDataInscrierii = new System.Windows.Forms.TextBox();
            this.txtCicluInvatamant = new System.Windows.Forms.TextBox();
            this.txtMediaInscriere = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.lstStudenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumarMatricol
            // 
            this.txtNumarMatricol.Location = new System.Drawing.Point(12, 12);
            this.txtNumarMatricol.Name = "txtNumarMatricol";
            this.txtNumarMatricol.Size = new System.Drawing.Size(100, 20);
            this.txtNumarMatricol.TabIndex = 0;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(12, 38);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 1;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(12, 64);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 20);
            this.txtPrenume.TabIndex = 2;
            // 
            // txtInitialaTata
            // 
            this.txtInitialaTata.Location = new System.Drawing.Point(12, 90);
            this.txtInitialaTata.Name = "txtInitialaTata";
            this.txtInitialaTata.Size = new System.Drawing.Size(100, 20);
            this.txtInitialaTata.TabIndex = 3;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(12, 116);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(100, 20);
            this.txtCNP.TabIndex = 4;
            // 
            // txtDataInscrierii
            // 
            this.txtDataInscrierii.Location = new System.Drawing.Point(12, 142);
            this.txtDataInscrierii.Name = "txtDataInscrierii";
            this.txtDataInscrierii.Size = new System.Drawing.Size(100, 20);
            this.txtDataInscrierii.TabIndex = 5;
            // 
            // txtCicluInvatamant
            // 
            this.txtCicluInvatamant.Location = new System.Drawing.Point(12, 168);
            this.txtCicluInvatamant.Name = "txtCicluInvatamant";
            this.txtCicluInvatamant.Size = new System.Drawing.Size(100, 20);
            this.txtCicluInvatamant.TabIndex = 6;
            // 
            // txtMediaInscriere
            // 
            this.txtMediaInscriere.Location = new System.Drawing.Point(12, 194);
            this.txtMediaInscriere.Name = "txtMediaInscriere";
            this.txtMediaInscriere.Size = new System.Drawing.Size(100, 20);
            this.txtMediaInscriere.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(118, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 23);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Adaugă Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(118, 41);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveStudent.TabIndex = 9;
            this.btnRemoveStudent.Text = "Șterge Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // lstStudenti
            // 
            this.lstStudenti.FormattingEnabled = true;
            this.lstStudenti.Location = new System.Drawing.Point(224, 12);
            this.lstStudenti.Name = "lstStudenti";
            this.lstStudenti.Size = new System.Drawing.Size(300, 199);
            this.lstStudenti.TabIndex = 10;
            this.lstStudenti.DoubleClick += new System.EventHandler(this.lstStudenti_DoubleClick);
            // 
            // GestionareStudentiForm
            // 
            this.ClientSize = new System.Drawing.Size(534, 223);
            this.Controls.Add(this.lstStudenti);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMediaInscriere);
            this.Controls.Add(this.txtCicluInvatamant);
            this.Controls.Add(this.txtDataInscrierii);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtInitialaTata);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtNumarMatricol);
            this.Name = "GestionareStudentiForm";
            this.Text = "Gestionare Studenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNumarMatricol;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtInitialaTata;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtDataInscrierii;
        private System.Windows.Forms.TextBox txtCicluInvatamant;
        private System.Windows.Forms.TextBox txtMediaInscriere;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.ListBox lstStudenti;
    }
}