namespace CatalogFacultate.Forms
{
    partial class GestionareGrupeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddGrupa;
        private System.Windows.Forms.TextBox txtCodGrupa;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.ListBox lstGrupe;
        private System.Windows.Forms.Button btnRemoveGrupa;

        private void InitializeComponent()
        {
            this.btnAddGrupa = new System.Windows.Forms.Button();
            this.txtCodGrupa = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.lstGrupe = new System.Windows.Forms.ListBox();
            this.btnRemoveGrupa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddGrupa
            // 
            this.btnAddGrupa.Location = new System.Drawing.Point(10, 90);
            this.btnAddGrupa.Name = "btnAddGrupa";
            this.btnAddGrupa.Size = new System.Drawing.Size(100, 23);
            this.btnAddGrupa.TabIndex = 0;
            this.btnAddGrupa.Text = "Adaugă Grupa";
            this.btnAddGrupa.UseVisualStyleBackColor = true;
            this.btnAddGrupa.Click += new System.EventHandler(this.btnAddGrupa_Click);
            // 
            // txtCodGrupa
            // 
            this.txtCodGrupa.Location = new System.Drawing.Point(10, 12);
            this.txtCodGrupa.Name = "txtCodGrupa";
            this.txtCodGrupa.Size = new System.Drawing.Size(200, 20);
            this.txtCodGrupa.TabIndex = 1;
            this.txtCodGrupa.Text = "Cod Grupa";
            this.txtCodGrupa.Enter += new System.EventHandler(this.txtCodGrupa_Enter);
            this.txtCodGrupa.Leave += new System.EventHandler(this.txtCodGrupa_Leave);
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(10, 38);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(200, 20);
            this.txtAn.TabIndex = 2;
            this.txtAn.Text = "An";
            this.txtAn.Enter += new System.EventHandler(this.txtAn_Enter);
            this.txtAn.Leave += new System.EventHandler(this.txtAn_Leave);
            // 
            // lstGrupe
            // 
            this.lstGrupe.FormattingEnabled = true;
            this.lstGrupe.Location = new System.Drawing.Point(220, 12);
            this.lstGrupe.Name = "lstGrupe";
            this.lstGrupe.Size = new System.Drawing.Size(320, 147);
            this.lstGrupe.TabIndex = 3;
            this.lstGrupe.DoubleClick += new System.EventHandler(this.lstGrupe_DoubleClick);
            // 
            // btnRemoveGrupa
            // 
            this.btnRemoveGrupa.Location = new System.Drawing.Point(120, 90);
            this.btnRemoveGrupa.Name = "btnRemoveGrupa";
            this.btnRemoveGrupa.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveGrupa.TabIndex = 4;
            this.btnRemoveGrupa.Text = "Șterge Grupa";
            this.btnRemoveGrupa.UseVisualStyleBackColor = true;
            this.btnRemoveGrupa.Click += new System.EventHandler(this.btnRemoveGrupa_Click);
            // 
            // GestionareGrupeForm
            // 
            this.ClientSize = new System.Drawing.Size(554, 181);
            this.Controls.Add(this.btnRemoveGrupa);
            this.Controls.Add(this.lstGrupe);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtCodGrupa);
            this.Controls.Add(this.btnAddGrupa);
            this.Name = "GestionareGrupeForm";
            this.Text = "Gestionare Grupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}