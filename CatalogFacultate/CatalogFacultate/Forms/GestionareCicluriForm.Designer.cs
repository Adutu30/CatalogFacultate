namespace CatalogFacultate.Forms
{
    partial class GestionareCicluriForm
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
            this.txtNumeCiclu = new System.Windows.Forms.TextBox();
            this.btnAddCiclu = new System.Windows.Forms.Button();
            this.btnDeleteCiclu = new System.Windows.Forms.Button();
            this.lstCicluri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumeCiclu
            // 
            this.txtNumeCiclu.Location = new System.Drawing.Point(12, 12);
            this.txtNumeCiclu.Name = "txtNumeCiclu";
            this.txtNumeCiclu.Size = new System.Drawing.Size(200, 20);
            this.txtNumeCiclu.TabIndex = 0;
            this.txtNumeCiclu.Text = "Nume ciclu";
            // 
            // btnAddCiclu
            // 
            this.btnAddCiclu.Location = new System.Drawing.Point(12, 38);
            this.btnAddCiclu.Name = "btnAddCiclu";
            this.btnAddCiclu.Size = new System.Drawing.Size(75, 23);
            this.btnAddCiclu.TabIndex = 1;
            this.btnAddCiclu.Text = "Adaugă";
            this.btnAddCiclu.UseVisualStyleBackColor = true;
            this.btnAddCiclu.Click += new System.EventHandler(this.btnAddCiclu_Click);
            // 
            // btnDeleteCiclu
            // 
            this.btnDeleteCiclu.Location = new System.Drawing.Point(137, 38);
            this.btnDeleteCiclu.Name = "btnDeleteCiclu";
            this.btnDeleteCiclu.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCiclu.TabIndex = 2;
            this.btnDeleteCiclu.Text = "Șterge";
            this.btnDeleteCiclu.UseVisualStyleBackColor = true;
            this.btnDeleteCiclu.Click += new System.EventHandler(this.btnDeleteCiclu_Click);
            // 
            // lstCicluri
            // 
            this.lstCicluri.FormattingEnabled = true;
            this.lstCicluri.Location = new System.Drawing.Point(12, 67);
            this.lstCicluri.Name = "lstCicluri";
            this.lstCicluri.Size = new System.Drawing.Size(200, 121);
            this.lstCicluri.TabIndex = 3;
            this.lstCicluri.DoubleClick += new System.EventHandler(this.lstCicluri_DoubleClick);
            // 
            // GestionareCicluriForm
            // 
            this.ClientSize = new System.Drawing.Size(224, 200);
            this.Controls.Add(this.lstCicluri);
            this.Controls.Add(this.btnDeleteCiclu);
            this.Controls.Add(this.btnAddCiclu);
            this.Controls.Add(this.txtNumeCiclu);
            this.Name = "GestionareCicluriForm";
            this.Text = "Gestionare Cicluri";
            this.Load += new System.EventHandler(this.GestionareCicluriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNumeCiclu;
        private System.Windows.Forms.Button btnAddCiclu;
        private System.Windows.Forms.Button btnDeleteCiclu;
        private System.Windows.Forms.ListBox lstCicluri;
    }
}