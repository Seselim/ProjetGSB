namespace AppliGSB
{
    partial class FrmNouveauMedicament
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
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
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnNouveau);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.BtnModifier);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAjouter);
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
            this.splitContainer1.Size = new System.Drawing.Size(1307, 797);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label2.Location = new System.Drawing.Point(598, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Gérer Medicament ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, -42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouveau.Location = new System.Drawing.Point(427, 488);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(80, 30);
            this.BtnNouveau.TabIndex = 32;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(555, 488);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(80, 30);
            this.BtnSupprimer.TabIndex = 31;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(674, 488);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(80, 30);
            this.BtnModifier.TabIndex = 30;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(427, 488);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(80, 30);
            this.BtnAjouter.TabIndex = 29;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // comboFamilles
            // 
            this.comboFamilles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFamilles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFamilles.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.comboFamilles.FormattingEnabled = true;
            this.comboFamilles.Location = new System.Drawing.Point(728, 435);
            this.comboFamilles.Margin = new System.Windows.Forms.Padding(2);
            this.comboFamilles.Name = "comboFamilles";
            this.comboFamilles.Size = new System.Drawing.Size(218, 24);
            this.comboFamilles.TabIndex = 28;
            // 
            // listMedicaments
            // 
            this.listMedicaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMedicaments.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.listMedicaments.FormattingEnabled = true;
            this.listMedicaments.ItemHeight = 16;
            this.listMedicaments.Location = new System.Drawing.Point(114, 27);
            this.listMedicaments.Margin = new System.Windows.Forms.Padding(2);
            this.listMedicaments.Name = "listMedicaments";
            this.listMedicaments.Size = new System.Drawing.Size(1050, 196);
            this.listMedicaments.TabIndex = 16;
            this.listMedicaments.SelectedIndexChanged += new System.EventHandler(this.listMedicaments_SelectedIndexChanged);
            // 
            // labelFamille
            // 
            this.labelFamille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelFamille.Location = new System.Drawing.Point(664, 436);
            this.labelFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(54, 16);
            this.labelFamille.TabIndex = 27;
            this.labelFamille.Text = "Famille :";
            // 
            // labelContreIndications
            // 
            this.labelContreIndications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContreIndications.AutoSize = true;
            this.labelContreIndications.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelContreIndications.Location = new System.Drawing.Point(606, 362);
            this.labelContreIndications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContreIndications.Name = "labelContreIndications";
            this.labelContreIndications.Size = new System.Drawing.Size(118, 16);
            this.labelContreIndications.TabIndex = 26;
            this.labelContreIndications.Text = "Contre Indications :";
            // 
            // labelEffets
            // 
            this.labelEffets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEffets.AutoSize = true;
            this.labelEffets.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelEffets.Location = new System.Drawing.Point(671, 273);
            this.labelEffets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEffets.Name = "labelEffets";
            this.labelEffets.Size = new System.Drawing.Size(48, 16);
            this.labelEffets.TabIndex = 25;
            this.labelEffets.Text = "Effets :";
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelComposition.Location = new System.Drawing.Point(227, 404);
            this.labelComposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(85, 16);
            this.labelComposition.TabIndex = 24;
            this.labelComposition.Text = "Composition :";
            // 
            // labelNomCommercial
            // 
            this.labelNomCommercial.AutoSize = true;
            this.labelNomCommercial.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelNomCommercial.Location = new System.Drawing.Point(204, 319);
            this.labelNomCommercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomCommercial.Name = "labelNomCommercial";
            this.labelNomCommercial.Size = new System.Drawing.Size(112, 16);
            this.labelNomCommercial.TabIndex = 23;
            this.labelNomCommercial.Text = "Nom commercial :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelId.Location = new System.Drawing.Point(281, 267);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 16);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "ID :";
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContreIndications.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtContreIndications.Location = new System.Drawing.Point(728, 345);
            this.txtContreIndications.Margin = new System.Windows.Forms.Padding(2);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.Size = new System.Drawing.Size(218, 60);
            this.txtContreIndications.TabIndex = 21;
            // 
            // txtEffets
            // 
            this.txtEffets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEffets.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtEffets.Location = new System.Drawing.Point(728, 248);
            this.txtEffets.Margin = new System.Windows.Forms.Padding(2);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(218, 74);
            this.txtEffets.TabIndex = 20;
            // 
            // txtComposition
            // 
            this.txtComposition.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtComposition.Location = new System.Drawing.Point(312, 373);
            this.txtComposition.Margin = new System.Windows.Forms.Padding(2);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(165, 91);
            this.txtComposition.TabIndex = 19;
            // 
            // txtNomCommercial
            // 
            this.txtNomCommercial.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtNomCommercial.Location = new System.Drawing.Point(312, 317);
            this.txtNomCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomCommercial.Name = "txtNomCommercial";
            this.txtNomCommercial.Size = new System.Drawing.Size(165, 23);
            this.txtNomCommercial.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtId.Location = new System.Drawing.Point(312, 267);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 17;
            // 
            // FrmNouveauMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1307, 797);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmNouveauMedicament";
            this.Text = "FrmNouveauMedicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNouveauMedicament_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFamilles;
        private System.Windows.Forms.ListBox listMedicaments;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.Label labelContreIndications;
        private System.Windows.Forms.Label labelEffets;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelNomCommercial;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtNomCommercial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnNouveau;
    }
}