namespace CatalogFacultate.Forms
{
    partial class GestionareNoteForm
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
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.btnGenereazaCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumarMatricol
            // 
            this.txtNumarMatricol.Location = new System.Drawing.Point(12, 12);
            this.txtNumarMatricol.Name = "txtNumarMatricol";
            this.txtNumarMatricol.Size = new System.Drawing.Size(100, 20);
            this.txtNumarMatricol.TabIndex = 0;
            this.txtNumarMatricol.Text = "Număr Matricol";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(12, 38);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplina.TabIndex = 1;
            this.txtDisciplina.Text = "Disciplina";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(12, 64);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 2;
            this.txtNota.Text = "Nota";
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.Location = new System.Drawing.Point(12, 90);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(100, 23);
            this.btnAdaugaNota.TabIndex = 3;
            this.btnAdaugaNota.Text = "Adaugă Nota";
            this.btnAdaugaNota.UseVisualStyleBackColor = true;
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // btnGenereazaCatalog
            // 
            this.btnGenereazaCatalog.Location = new System.Drawing.Point(12, 119);
            this.btnGenereazaCatalog.Name = "btnGenereazaCatalog";
            this.btnGenereazaCatalog.Size = new System.Drawing.Size(100, 23);
            this.btnGenereazaCatalog.TabIndex = 4;
            this.btnGenereazaCatalog.Text = "Generează Catalog";
            this.btnGenereazaCatalog.UseVisualStyleBackColor = true;
            this.btnGenereazaCatalog.Click += new System.EventHandler(this.btnGenereazaCatalog_Click);
            // 
            // GestionareNoteForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenereazaCatalog);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.txtNumarMatricol);
            this.Name = "GestionareNoteForm";
            this.Text = "Gestionare Note";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumarMatricol;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnAdaugaNota;
        private System.Windows.Forms.Button btnGenereazaCatalog;
    }
}