namespace AppliGSB
{
    partial class FrmMedicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMedicament = new System.Windows.Forms.Label();
            this.comboFamilles = new System.Windows.Forms.ComboBox();
            this.listMedicaments = new System.Windows.Forms.ListBox();
            this.labelFamille = new System.Windows.Forms.Label();
            this.labelContreIndications = new System.Windows.Forms.Label();
            this.labelEffets = new System.Windows.Forms.Label();
            this.labelComposition = new System.Windows.Forms.Label();
            this.labelNomCommercial = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtNomCommercial = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelMedicament);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboFamilles);
            this.splitContainer1.Panel2.Controls.Add(this.listMedicaments);
            this.splitContainer1.Panel2.Controls.Add(this.labelFamille);
            this.splitContainer1.Panel2.Controls.Add(this.labelContreIndications);
            this.splitContainer1.Panel2.Controls.Add(this.labelEffets);
            this.splitContainer1.Panel2.Controls.Add(this.labelComposition);
            this.splitContainer1.Panel2.Controls.Add(this.labelNomCommercial);
            this.splitContainer1.Panel2.Controls.Add(this.labelId);
            this.splitContainer1.Panel2.Controls.Add(this.txtContreIndications);
            this.splitContainer1.Panel2.Controls.Add(this.txtEffets);
            this.splitContainer1.Panel2.Controls.Add(this.txtComposition);
            this.splitContainer1.Panel2.Controls.Add(this.txtNomCommercial);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 707);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelMedicament
            // 
            this.labelMedicament.AutoSize = true;
            this.labelMedicament.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.labelMedicament.Location = new System.Drawing.Point(488, 28);
            this.labelMedicament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMedicament.Name = "labelMedicament";
            this.labelMedicament.Size = new System.Drawing.Size(239, 27);
            this.labelMedicament.TabIndex = 0;
            this.labelMedicament.Text = "Liste des Médicaments ";
            this.labelMedicament.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboFamilles
            // 
            this.comboFamilles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFamilles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFamilles.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.comboFamilles.FormattingEnabled = true;
            this.comboFamilles.Location = new System.Drawing.Point(695, 404);
            this.comboFamilles.Margin = new System.Windows.Forms.Padding(2);
            this.comboFamilles.Name = "comboFamilles";
            this.comboFamilles.Size = new System.Drawing.Size(218, 24);
            this.comboFamilles.TabIndex = 15;
            this.comboFamilles.SelectedIndexChanged += new System.EventHandler(this.comboFamilles_SelectedIndexChanged);
            // 
            // listMedicaments
            // 
            this.listMedicaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMedicaments.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.listMedicaments.FormattingEnabled = true;
            this.listMedicaments.ItemHeight = 16;
            this.listMedicaments.Location = new System.Drawing.Point(84, 17);
            this.listMedicaments.Margin = new System.Windows.Forms.Padding(2);
            this.listMedicaments.Name = "listMedicaments";
            this.listMedicaments.Size = new System.Drawing.Size(1050, 196);
            this.listMedicaments.TabIndex = 0;
            this.listMedicaments.SelectedIndexChanged += new System.EventHandler(this.listMedicaments_SelectedIndexChanged);
            // 
            // labelFamille
            // 
            this.labelFamille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelFamille.Location = new System.Drawing.Point(631, 405);
            this.labelFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(54, 16);
            this.labelFamille.TabIndex = 12;
            this.labelFamille.Text = "Famille :";
            // 
            // labelContreIndications
            // 
            this.labelContreIndications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContreIndications.AutoSize = true;
            this.labelContreIndications.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelContreIndications.Location = new System.Drawing.Point(583, 331);
            this.labelContreIndications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContreIndications.Name = "labelContreIndications";
            this.labelContreIndications.Size = new System.Drawing.Size(118, 16);
            this.labelContreIndications.TabIndex = 11;
            this.labelContreIndications.Text = "Contre Indications :";
            // 
            // labelEffets
            // 
            this.labelEffets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEffets.AutoSize = true;
            this.labelEffets.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelEffets.Location = new System.Drawing.Point(638, 242);
            this.labelEffets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEffets.Name = "labelEffets";
            this.labelEffets.Size = new System.Drawing.Size(48, 16);
            this.labelEffets.TabIndex = 10;
            this.labelEffets.Text = "Effets :";
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelComposition.Location = new System.Drawing.Point(194, 373);
            this.labelComposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(85, 16);
            this.labelComposition.TabIndex = 9;
            this.labelComposition.Text = "Composition :";
            // 
            // labelNomCommercial
            // 
            this.labelNomCommercial.AutoSize = true;
            this.labelNomCommercial.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelNomCommercial.Location = new System.Drawing.Point(171, 288);
            this.labelNomCommercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomCommercial.Name = "labelNomCommercial";
            this.labelNomCommercial.Size = new System.Drawing.Size(112, 16);
            this.labelNomCommercial.TabIndex = 8;
            this.labelNomCommercial.Text = "Nom commercial :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelId.Location = new System.Drawing.Point(248, 236);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 16);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "ID :";
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContreIndications.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtContreIndications.Location = new System.Drawing.Point(695, 314);
            this.txtContreIndications.Margin = new System.Windows.Forms.Padding(2);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.Size = new System.Drawing.Size(218, 60);
            this.txtContreIndications.TabIndex = 5;
            // 
            // txtEffets
            // 
            this.txtEffets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEffets.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtEffets.Location = new System.Drawing.Point(695, 217);
            this.txtEffets.Margin = new System.Windows.Forms.Padding(2);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(218, 74);
            this.txtEffets.TabIndex = 4;
            // 
            // txtComposition
            // 
            this.txtComposition.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtComposition.Location = new System.Drawing.Point(279, 342);
            this.txtComposition.Margin = new System.Windows.Forms.Padding(2);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(165, 91);
            this.txtComposition.TabIndex = 3;
            // 
            // txtNomCommercial
            // 
            this.txtNomCommercial.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtNomCommercial.Location = new System.Drawing.Point(279, 286);
            this.txtNomCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomCommercial.Name = "txtNomCommercial";
            this.txtNomCommercial.Size = new System.Drawing.Size(165, 23);
            this.txtNomCommercial.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtId.Location = new System.Drawing.Point(279, 236);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 1;
            // 
            // FrmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 707);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMedicament";
            this.Text = "FrmMedicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMedicament_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMedicament;
        private System.Windows.Forms.ListBox listMedicaments;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtNomCommercial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.Label labelContreIndications;
        private System.Windows.Forms.Label labelEffets;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelNomCommercial;
        private System.Windows.Forms.ComboBox comboFamilles;
    }
}