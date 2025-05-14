namespace AppliGSB
{
    partial class FrmListeVisiteur
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelComposition = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.labelCp = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.listVisiteur = new System.Windows.Forms.ListBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtDateEmbauche);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.labelVille);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdresse);
            this.splitContainer1.Panel2.Controls.Add(this.labelNom);
            this.splitContainer1.Panel2.Controls.Add(this.labelComposition);
            this.splitContainer1.Panel2.Controls.Add(this.txtVille);
            this.splitContainer1.Panel2.Controls.Add(this.labelCp);
            this.splitContainer1.Panel2.Controls.Add(this.txtCp);
            this.splitContainer1.Size = new System.Drawing.Size(1314, 803);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(558, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Visiteurs";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(674, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adresse :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtAdresse.Location = new System.Drawing.Point(743, 284);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(218, 23);
            this.txtAdresse.TabIndex = 27;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelNom.Location = new System.Drawing.Point(281, 337);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 16);
            this.labelNom.TabIndex = 23;
            this.labelNom.Text = "Nom :";
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelComposition.Location = new System.Drawing.Point(265, 393);
            this.labelComposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(58, 16);
            this.labelComposition.TabIndex = 24;
            this.labelComposition.Text = "Prénom :";
            // 
            // txtVille
            // 
            this.txtVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVille.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtVille.Location = new System.Drawing.Point(743, 337);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(218, 23);
            this.txtVille.TabIndex = 20;
            // 
            // labelCp
            // 
            this.labelCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCp.AutoSize = true;
            this.labelCp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelCp.Location = new System.Drawing.Point(691, 391);
            this.labelCp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCp.Name = "labelCp";
            this.labelCp.Size = new System.Drawing.Size(30, 16);
            this.labelCp.TabIndex = 26;
            this.labelCp.Text = "CP :";
            // 
            // txtCp
            // 
            this.txtCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCp.Location = new System.Drawing.Point(743, 384);
            this.txtCp.Margin = new System.Windows.Forms.Padding(2);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(218, 23);
            this.txtCp.TabIndex = 21;
            // 
            // listVisiteur
            // 
            this.listVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVisiteur.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.listVisiteur.FormattingEnabled = true;
            this.listVisiteur.ItemHeight = 16;
            this.listVisiteur.Location = new System.Drawing.Point(132, 193);
            this.listVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.listVisiteur.Name = "listVisiteur";
            this.listVisiteur.Size = new System.Drawing.Size(1050, 196);
            this.listVisiteur.TabIndex = 16;
            // 
            // labelVille
            // 
            this.labelVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelVille.Location = new System.Drawing.Point(684, 341);
            this.labelVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(37, 16);
            this.labelVille.TabIndex = 25;
            this.labelVille.Text = "Ville :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelId.Location = new System.Drawing.Point(296, 412);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 16);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "ID :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtPrenom.Location = new System.Drawing.Point(327, 518);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(165, 23);
            this.txtPrenom.TabIndex = 19;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtNom.Location = new System.Drawing.Point(327, 462);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 23);
            this.txtNom.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtId.Location = new System.Drawing.Point(327, 412);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.Location = new System.Drawing.Point(208, 442);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Date Embauche :";
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateEmbauche.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtDateEmbauche.Location = new System.Drawing.Point(327, 439);
            this.txtDateEmbauche.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.Size = new System.Drawing.Size(165, 23);
            this.txtDateEmbauche.TabIndex = 29;
            // 
            // FrmListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1314, 803);
            this.ControlBox = false;
            this.Controls.Add(this.listVisiteur);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmListeVisiteur";
            this.Text = "FrmListeVisiteur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListeVisiteur_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listVisiteur;
        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDateEmbauche;
    }
}