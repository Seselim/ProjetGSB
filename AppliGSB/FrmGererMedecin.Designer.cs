namespace AppliGSB
{
    partial class FrmGererMedecin
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
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.comboSpecialites = new System.Windows.Forms.ComboBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.listMedecins = new System.Windows.Forms.ListBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnNouveau);
            this.splitContainer1.Panel2.Controls.Add(this.comboSpecialites);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAjouter);
            this.splitContainer1.Panel2.Controls.Add(this.BtnModifier);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDepartement);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Panel2.Controls.Add(this.txtTel);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdresse);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrenom);
            this.splitContainer1.Panel2.Controls.Add(this.txtNom);
            this.splitContainer1.Panel2.Controls.Add(this.listMedecins);
            this.splitContainer1.Size = new System.Drawing.Size(1385, 787);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(637, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerer Medecin";
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnNouveau.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.BtnNouveau.Location = new System.Drawing.Point(604, 477);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(130, 30);
            this.BtnNouveau.TabIndex = 33;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click_1);
            // 
            // comboSpecialites
            // 
            this.comboSpecialites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSpecialites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialites.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.comboSpecialites.FormattingEnabled = true;
            this.comboSpecialites.Location = new System.Drawing.Point(736, 325);
            this.comboSpecialites.Margin = new System.Windows.Forms.Padding(2);
            this.comboSpecialites.Name = "comboSpecialites";
            this.comboSpecialites.Size = new System.Drawing.Size(190, 27);
            this.comboSpecialites.TabIndex = 32;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAjouter.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.BtnAjouter.Location = new System.Drawing.Point(604, 477);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(130, 30);
            this.BtnAjouter.TabIndex = 31;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click_1);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnModifier.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.BtnModifier.Location = new System.Drawing.Point(930, 477);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(130, 30);
            this.BtnModifier.TabIndex = 30;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click_1);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSupprimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSupprimer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(773, 477);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(130, 30);
            this.BtnSupprimer.TabIndex = 29;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(621, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Département :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(639, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Spécialité :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(184, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tél :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(184, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(184, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(184, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(184, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID :";
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(736, 390);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(190, 27);
            this.txtDepartement.TabIndex = 22;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(267, 302);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(190, 27);
            this.txtId.TabIndex = 20;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(267, 507);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(190, 27);
            this.txtTel.TabIndex = 19;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(267, 455);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(190, 27);
            this.txtAdresse.TabIndex = 18;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(267, 405);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(190, 27);
            this.txtPrenom.TabIndex = 17;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(267, 351);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(190, 27);
            this.txtNom.TabIndex = 16;
            // 
            // listMedecins
            // 
            this.listMedecins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMedecins.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listMedecins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMedecins.FormattingEnabled = true;
            this.listMedecins.ItemHeight = 19;
            this.listMedecins.Location = new System.Drawing.Point(50, 33);
            this.listMedecins.Name = "listMedecins";
            this.listMedecins.Size = new System.Drawing.Size(1285, 228);
            this.listMedecins.TabIndex = 14;
            this.listMedecins.SelectedIndexChanged += new System.EventHandler(this.listMedecins_SelectedIndexChanged_1);
            // 
            // FrmGererMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 787);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGererMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmGererMedecin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGererMedecin_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ListBox listMedecins;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.ComboBox comboSpecialites;
        private System.Windows.Forms.Button BtnNouveau;
    }
}