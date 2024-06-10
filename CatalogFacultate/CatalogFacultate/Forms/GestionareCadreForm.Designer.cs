namespace CatalogFacultate.Forms
{
    partial class GestionareCadreForm
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtMarcaAngajat = new System.Windows.Forms.TextBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.btnAddCadru = new System.Windows.Forms.Button();
            this.btnEditCadru = new System.Windows.Forms.Button();
            this.btnDeleteCadru = new System.Windows.Forms.Button();
            this.lstCadre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(12, 12);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 0;
            this.txtNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(12, 38);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 20);
            this.txtPrenume.TabIndex = 1;
            this.txtPrenume.Text = "Prenume";
            // 
            // txtMarcaAngajat
            // 
            this.txtMarcaAngajat.Location = new System.Drawing.Point(12, 64);
            this.txtMarcaAngajat.Name = "txtMarcaAngajat";
            this.txtMarcaAngajat.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaAngajat.TabIndex = 2;
            this.txtMarcaAngajat.Text = "Marca Angajat";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(12, 90);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(100, 20);
            this.txtTitlu.TabIndex = 3;
            this.txtTitlu.Text = "Titlu";
            // 
            // cmbPost
            // 
            this.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Items.AddRange(new object[] {
            "Asistent universitar",
            "Șef lucrări/Lector",
            "Conferențiar universitar",
            "Profesor universitar",
            "CDA"});
            this.cmbPost.Location = new System.Drawing.Point(12, 116);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(121, 21);
            this.cmbPost.TabIndex = 4;
            // 
            // btnAddCadru
            // 
            this.btnAddCadru.Location = new System.Drawing.Point(12, 143);
            this.btnAddCadru.Name = "btnAddCadru";
            this.btnAddCadru.Size = new System.Drawing.Size(100, 23);
            this.btnAddCadru.TabIndex = 5;
            this.btnAddCadru.Text = "Adaugă Cadru";
            this.btnAddCadru.UseVisualStyleBackColor = true;
            this.btnAddCadru.Click += new System.EventHandler(this.btnAddCadru_Click);
            // 
            // btnEditCadru
            // 
            this.btnEditCadru.Location = new System.Drawing.Point(12, 172);
            this.btnEditCadru.Name = "btnEditCadru";
            this.btnEditCadru.Size = new System.Drawing.Size(100, 23);
            this.btnEditCadru.TabIndex = 6;
            this.btnEditCadru.Text = "Editează Cadru";
            this.btnEditCadru.UseVisualStyleBackColor = true;
            this.btnEditCadru.Click += new System.EventHandler(this.btnEditCadru_Click);
            // 
            // btnDeleteCadru
            // 
            this.btnDeleteCadru.Location = new System.Drawing.Point(12, 201);
            this.btnDeleteCadru.Name = "btnDeleteCadru";
            this.btnDeleteCadru.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteCadru.TabIndex = 7;
            this.btnDeleteCadru.Text = "Șterge Cadru";
            this.btnDeleteCadru.UseVisualStyleBackColor = true;
            this.btnDeleteCadru.Click += new System.EventHandler(this.btnDeleteCadru_Click);
            // 
            // lstCadre
            // 
            this.lstCadre.FormattingEnabled = true;
            this.lstCadre.Location = new System.Drawing.Point(139, 12);
            this.lstCadre.Name = "lstCadre";
            this.lstCadre.Size = new System.Drawing.Size(200, 212);
            this.lstCadre.TabIndex = 8;
            this.lstCadre.SelectedIndexChanged += new System.EventHandler(this.lstCadre_SelectedIndexChanged);
            this.lstCadre.DoubleClick += new System.EventHandler(this.lstCadre_DoubleClick);
            // 
            // GestionareCadreForm
            // 
            this.ClientSize = new System.Drawing.Size(351, 245);
            this.Controls.Add(this.lstCadre);
            this.Controls.Add(this.btnDeleteCadru);
            this.Controls.Add(this.btnEditCadru);
            this.Controls.Add(this.btnAddCadru);
            this.Controls.Add(this.cmbPost);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.txtMarcaAngajat);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Name = "GestionareCadreForm";
            this.Text = "Gestionare Cadre Didactice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtMarcaAngajat;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Button btnAddCadru;
        private System.Windows.Forms.Button btnEditCadru;
        private System.Windows.Forms.Button btnDeleteCadru;
        private System.Windows.Forms.ListBox lstCadre;
    }
}