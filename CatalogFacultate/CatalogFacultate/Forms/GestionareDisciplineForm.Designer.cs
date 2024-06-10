namespace CatalogFacultate.Forms
{
    partial class GestionareDisciplineForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddDisciplina;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.TextBox txtNumeDisciplina;
        private System.Windows.Forms.TextBox txtAcronim;
        private System.Windows.Forms.TextBox txtCredite;
        private System.Windows.Forms.ListBox lstDiscipline;

        private void InitializeComponent()
        {
            this.btnAddDisciplina = new System.Windows.Forms.Button();
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.txtNumeDisciplina = new System.Windows.Forms.TextBox();
            this.txtAcronim = new System.Windows.Forms.TextBox();
            this.txtCredite = new System.Windows.Forms.TextBox();
            this.lstDiscipline = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddDisciplina
            // 
            this.btnAddDisciplina.Location = new System.Drawing.Point(10, 140);
            this.btnAddDisciplina.Name = "btnAddDisciplina";
            this.btnAddDisciplina.Size = new System.Drawing.Size(100, 23);
            this.btnAddDisciplina.TabIndex = 0;
            this.btnAddDisciplina.Text = "Adauga Disciplina";
            this.btnAddDisciplina.UseVisualStyleBackColor = true;
            this.btnAddDisciplina.Click += new System.EventHandler(this.btnAddDisciplina_Click);
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.Location = new System.Drawing.Point(10, 12);
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.Size = new System.Drawing.Size(200, 20);
            this.txtCodDisciplina.TabIndex = 1;
            this.txtCodDisciplina.Text = "Cod Disciplina";
            // 
            // txtNumeDisciplina
            // 
            this.txtNumeDisciplina.Location = new System.Drawing.Point(10, 38);
            this.txtNumeDisciplina.Name = "txtNumeDisciplina";
            this.txtNumeDisciplina.Size = new System.Drawing.Size(200, 20);
            this.txtNumeDisciplina.TabIndex = 2;
            this.txtNumeDisciplina.Text = "Nume Disciplina";
            // 
            // txtAcronim
            // 
            this.txtAcronim.Location = new System.Drawing.Point(10, 64);
            this.txtAcronim.Name = "txtAcronim";
            this.txtAcronim.Size = new System.Drawing.Size(200, 20);
            this.txtAcronim.TabIndex = 3;
            this.txtAcronim.Text = "Acronim";
            // 
            // txtCredite
            // 
            this.txtCredite.Location = new System.Drawing.Point(10, 90);
            this.txtCredite.Name = "txtCredite";
            this.txtCredite.Size = new System.Drawing.Size(200, 20);
            this.txtCredite.TabIndex = 4;
            this.txtCredite.Text = "Numar Credite";
            // 
            // lstDiscipline
            // 
            this.lstDiscipline.FormattingEnabled = true;
            this.lstDiscipline.Location = new System.Drawing.Point(220, 12);
            this.lstDiscipline.Name = "lstDiscipline";
            this.lstDiscipline.Size = new System.Drawing.Size(320, 147);
            this.lstDiscipline.TabIndex = 5;
            this.lstDiscipline.DoubleClick += new System.EventHandler(this.lstDiscipline_DoubleClick);
            // 
            // GestionareDisciplineForm
            // 
            this.ClientSize = new System.Drawing.Size(554, 181);
            this.Controls.Add(this.lstDiscipline);
            this.Controls.Add(this.txtCredite);
            this.Controls.Add(this.txtAcronim);
            this.Controls.Add(this.txtNumeDisciplina);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.btnAddDisciplina);
            this.Name = "GestionareDisciplineForm";
            this.Text = "Gestionare Discipline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}