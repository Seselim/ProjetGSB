namespace AppliGSB
{
    partial class FrmGererVisiteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listVisiteurs = new System.Windows.Forms.ListBox();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.labelComposition = new System.Windows.Forms.Label();
            this.labelCp = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnNouveau);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.BtnModifier);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAjouter);
            this.splitContainer1.Panel2.Controls.Add(this.txtLogin);
            this.splitContainer1.Panel2.Controls.Add(this.txtMdp);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.listVisiteurs);
            this.splitContainer1.Panel2.Controls.Add(this.txtDateEmbauche);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtNom);
            this.splitContainer1.Panel2.Controls.Add(this.labelVille);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrenom);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdresse);
            this.splitContainer1.Panel2.Controls.Add(this.labelId);
            this.splitContainer1.Panel2.Controls.Add(this.labelNom);
            this.splitContainer1.Panel2.Controls.Add(this.txtCp);
            this.splitContainer1.Panel2.Controls.Add(this.labelComposition);
            this.splitContainer1.Panel2.Controls.Add(this.labelCp);
            this.splitContainer1.Panel2.Controls.Add(this.txtVille);
            this.splitContainer1.Size = new System.Drawing.Size(1524, 920);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gérer Visiteur";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtLogin.Location = new System.Drawing.Point(1022, 360);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 23);
            this.txtLogin.TabIndex = 46;
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtMdp.Location = new System.Drawing.Point(1022, 391);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(165, 23);
            this.txtMdp.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label4.Location = new System.Drawing.Point(963, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Login :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label5.Location = new System.Drawing.Point(967, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "MDP :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.Location = new System.Drawing.Point(223, 454);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Date Embauche :";
            // 
            // listVisiteurs
            // 
            this.listVisiteurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVisiteurs.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.listVisiteurs.FormattingEnabled = true;
            this.listVisiteurs.ItemHeight = 16;
            this.listVisiteurs.Location = new System.Drawing.Point(156, 55);
            this.listVisiteurs.Margin = new System.Windows.Forms.Padding(2);
            this.listVisiteurs.Name = "listVisiteurs";
            this.listVisiteurs.Size = new System.Drawing.Size(1050, 196);
            this.listVisiteurs.TabIndex = 31;
            this.listVisiteurs.SelectedIndexChanged += new System.EventHandler(this.listVisiteurs_SelectedIndexChanged_1);
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateEmbauche.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtDateEmbauche.Location = new System.Drawing.Point(339, 454);
            this.txtDateEmbauche.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.Size = new System.Drawing.Size(165, 23);
            this.txtDateEmbauche.TabIndex = 44;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtId.Location = new System.Drawing.Point(339, 335);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(619, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Adresse :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtNom.Location = new System.Drawing.Point(339, 366);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 23);
            this.txtNom.TabIndex = 33;
            // 
            // labelVille
            // 
            this.labelVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelVille.Location = new System.Drawing.Point(629, 394);
            this.labelVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(37, 16);
            this.labelVille.TabIndex = 40;
            this.labelVille.Text = "Ville :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtPrenom.Location = new System.Drawing.Point(339, 408);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(165, 23);
            this.txtPrenom.TabIndex = 34;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtAdresse.Location = new System.Drawing.Point(688, 337);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(218, 23);
            this.txtAdresse.TabIndex = 42;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelId.Location = new System.Drawing.Point(297, 335);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 16);
            this.labelId.TabIndex = 37;
            this.labelId.Text = "ID :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelNom.Location = new System.Drawing.Point(284, 369);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 16);
            this.labelNom.TabIndex = 38;
            this.labelNom.Text = "Nom :";
            // 
            // txtCp
            // 
            this.txtCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCp.Location = new System.Drawing.Point(688, 437);
            this.txtCp.Margin = new System.Windows.Forms.Padding(2);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(218, 23);
            this.txtCp.TabIndex = 36;
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelComposition.Location = new System.Drawing.Point(268, 411);
            this.labelComposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(58, 16);
            this.labelComposition.TabIndex = 39;
            this.labelComposition.Text = "Prénom :";
            // 
            // labelCp
            // 
            this.labelCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCp.AutoSize = true;
            this.labelCp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelCp.Location = new System.Drawing.Point(636, 444);
            this.labelCp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCp.Name = "labelCp";
            this.labelCp.Size = new System.Drawing.Size(30, 16);
            this.labelCp.TabIndex = 41;
            this.labelCp.Text = "CP :";
            // 
            // txtVille
            // 
            this.txtVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVille.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtVille.Location = new System.Drawing.Point(688, 390);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(218, 23);
            this.txtVille.TabIndex = 35;
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouveau.Location = new System.Drawing.Point(494, 545);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(80, 30);
            this.BtnNouveau.TabIndex = 53;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(622, 545);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(80, 30);
            this.BtnSupprimer.TabIndex = 52;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click_1);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(741, 545);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(80, 30);
            this.BtnModifier.TabIndex = 51;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(494, 545);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(80, 30);
            this.BtnAjouter.TabIndex = 50;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // FrmGererVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1524, 920);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmGererVisiteur";
            this.Text = "FrmListeGerer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGererVisiteur_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listVisiteurs;
        private System.Windows.Forms.TextBox txtDateEmbauche;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnAjouter;
    }
}