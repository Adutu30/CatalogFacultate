namespace CatalogFacultate.Forms
{
    partial class GestionareProgrameForm
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
            this.txtNumeProgram = new System.Windows.Forms.TextBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnDeleteProgram = new System.Windows.Forms.Button();
            this.lstPrograme = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumeProgram
            // 
            this.txtNumeProgram.Location = new System.Drawing.Point(12, 12);
            this.txtNumeProgram.Name = "txtNumeProgram";
            this.txtNumeProgram.Size = new System.Drawing.Size(200, 20);
            this.txtNumeProgram.TabIndex = 0;
            this.txtNumeProgram.Text = "Nume program";
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(12, 38);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(75, 23);
            this.btnAddProgram.TabIndex = 1;
            this.btnAddProgram.Text = "Adaugă";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnDeleteProgram
            // 
            this.btnDeleteProgram.Location = new System.Drawing.Point(137, 38);
            this.btnDeleteProgram.Name = "btnDeleteProgram";
            this.btnDeleteProgram.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProgram.TabIndex = 2;
            this.btnDeleteProgram.Text = "Șterge";
            this.btnDeleteProgram.UseVisualStyleBackColor = true;
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);
            // 
            // lstPrograme
            // 
            this.lstPrograme.FormattingEnabled = true;
            this.lstPrograme.Location = new System.Drawing.Point(12, 67);
            this.lstPrograme.Name = "lstPrograme";
            this.lstPrograme.Size = new System.Drawing.Size(200, 121);
            this.lstPrograme.TabIndex = 3;
            this.lstPrograme.DoubleClick += new System.EventHandler(this.lstPrograme_DoubleClick);
            // 
            // GestionareProgrameForm
            // 
            this.ClientSize = new System.Drawing.Size(224, 200);
            this.Controls.Add(this.lstPrograme);
            this.Controls.Add(this.btnDeleteProgram);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.txtNumeProgram);
            this.Name = "GestionareProgrameForm";
            this.Text = "Gestionare Programe";
            this.Load += new System.EventHandler(this.GestionareProgrameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNumeProgram;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnDeleteProgram;
        private System.Windows.Forms.ListBox lstPrograme;
    }
}