namespace CatalogFacultate.Forms
{
    partial class GestionareAniForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddAn;
        private System.Windows.Forms.TextBox txtNumeAn;
        private System.Windows.Forms.ListBox lstAni;

        private void InitializeComponent()
        {
            this.btnAddAn = new System.Windows.Forms.Button();
            this.txtNumeAn = new System.Windows.Forms.TextBox();
            this.lstAni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddAn
            // 
            this.btnAddAn.Location = new System.Drawing.Point(150, 10);
            this.btnAddAn.Name = "btnAddAn";
            this.btnAddAn.Size = new System.Drawing.Size(75, 23);
            this.btnAddAn.TabIndex = 0;
            this.btnAddAn.Text = "Adauga An";
            this.btnAddAn.UseVisualStyleBackColor = true;
            this.btnAddAn.Click += new System.EventHandler(this.btnAddAn_Click);
            // 
            // txtNumeAn
            // 
            this.txtNumeAn.Location = new System.Drawing.Point(10, 12);
            this.txtNumeAn.Name = "txtNumeAn";
            this.txtNumeAn.Size = new System.Drawing.Size(134, 20);
            this.txtNumeAn.TabIndex = 1;
            // 
            // lstAni
            // 
            this.lstAni.FormattingEnabled = true;
            this.lstAni.Location = new System.Drawing.Point(10, 40);
            this.lstAni.Name = "lstAni";
            this.lstAni.Size = new System.Drawing.Size(215, 95);
            this.lstAni.TabIndex = 2;
            this.lstAni.DoubleClick += new System.EventHandler(this.lstAni_DoubleClick);
            // 
            // GestionareAniForm
            // 
            this.ClientSize = new System.Drawing.Size(487, 282);
            this.Controls.Add(this.lstAni);
            this.Controls.Add(this.txtNumeAn);
            this.Controls.Add(this.btnAddAn);
            this.Name = "GestionareAniForm";
            this.Text = "Gestionare Ani de Studii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}