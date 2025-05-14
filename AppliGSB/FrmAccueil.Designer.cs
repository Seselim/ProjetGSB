namespace AppliGSB
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripGSB = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicament = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicamentGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicamentListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteurListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteurGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisiteurRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinDernierRapport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedecinListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapportAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapportRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRapportListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.LogoGSB = new System.Windows.Forms.PictureBox();
            this.menuStripGSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGSB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripGSB
            // 
            this.menuStripGSB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripGSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuMedicament,
            this.mnuVisiteur,
            this.mnuMedecin,
            this.mnuRapport,
            this.mnuAide});
            this.menuStripGSB.Location = new System.Drawing.Point(0, 0);
            this.menuStripGSB.Name = "menuStripGSB";
            this.menuStripGSB.Size = new System.Drawing.Size(1561, 28);
            this.menuStripGSB.TabIndex = 1;
            this.menuStripGSB.Text = "menuStripGSB";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierAccueil,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(70, 24);
            this.mnuFichier.Text = "Fichier ";
            // 
            // mnuFichierAccueil
            // 
            this.mnuFichierAccueil.Name = "mnuFichierAccueil";
            this.mnuFichierAccueil.Size = new System.Drawing.Size(140, 26);
            this.mnuFichierAccueil.Text = "Accueil";
            this.mnuFichierAccueil.Click += new System.EventHandler(this.mnuFichierAccueil_Click);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.Size = new System.Drawing.Size(140, 26);
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuMedicament
            // 
            this.mnuMedicament.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedicamentGerer,
            this.mnuMedicamentListe});
            this.mnuMedicament.Name = "mnuMedicament";
            this.mnuMedicament.Size = new System.Drawing.Size(106, 24);
            this.mnuMedicament.Text = "Médicament";
            // 
            // mnuMedicamentGerer
            // 
            this.mnuMedicamentGerer.Name = "mnuMedicamentGerer";
            this.mnuMedicamentGerer.Size = new System.Drawing.Size(128, 26);
            this.mnuMedicamentGerer.Text = "Gérer";
            this.mnuMedicamentGerer.Click += new System.EventHandler(this.mnuMedicamentGerer_Click);
            // 
            // mnuMedicamentListe
            // 
            this.mnuMedicamentListe.Name = "mnuMedicamentListe";
            this.mnuMedicamentListe.Size = new System.Drawing.Size(128, 26);
            this.mnuMedicamentListe.Text = "Liste";
            this.mnuMedicamentListe.Click += new System.EventHandler(this.mnuMedicamentListe_Click);
            // 
            // mnuVisiteur
            // 
            this.mnuVisiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisiteurListe,
            this.mnuVisiteurGerer,
            this.mnuVisiteurRechercher});
            this.mnuVisiteur.Name = "mnuVisiteur";
            this.mnuVisiteur.Size = new System.Drawing.Size(72, 24);
            this.mnuVisiteur.Text = "Visiteur";
            // 
            // mnuVisiteurListe
            // 
            this.mnuVisiteurListe.Name = "mnuVisiteurListe";
            this.mnuVisiteurListe.Size = new System.Drawing.Size(165, 26);
            this.mnuVisiteurListe.Text = "Liste";
            this.mnuVisiteurListe.Click += new System.EventHandler(this.mnuVisiteurListe_Click);
            // 
            // mnuVisiteurGerer
            // 
            this.mnuVisiteurGerer.Name = "mnuVisiteurGerer";
            this.mnuVisiteurGerer.Size = new System.Drawing.Size(165, 26);
            this.mnuVisiteurGerer.Text = "Gérer";
            this.mnuVisiteurGerer.Click += new System.EventHandler(this.mnuVisiteurGerer_Click);
            // 
            // mnuVisiteurRechercher
            // 
            this.mnuVisiteurRechercher.Name = "mnuVisiteurRechercher";
            this.mnuVisiteurRechercher.Size = new System.Drawing.Size(165, 26);
            this.mnuVisiteurRechercher.Text = "Rechercher";
            // 
            // mnuMedecin
            // 
            this.mnuMedecin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedecinGerer,
            this.mnuMedecinDernierRapport,
            this.mnuMedecinRechercher,
            this.mnuMedecinListe});
            this.mnuMedecin.Name = "mnuMedecin";
            this.mnuMedecin.Size = new System.Drawing.Size(80, 24);
            this.mnuMedecin.Text = "Médecin";
            // 
            // mnuMedecinGerer
            // 
            this.mnuMedecinGerer.Name = "mnuMedecinGerer";
            this.mnuMedecinGerer.Size = new System.Drawing.Size(195, 26);
            this.mnuMedecinGerer.Text = "Gérer";
            this.mnuMedecinGerer.Click += new System.EventHandler(this.mnuMedecinGerer_Click);
            // 
            // mnuMedecinDernierRapport
            // 
            this.mnuMedecinDernierRapport.Name = "mnuMedecinDernierRapport";
            this.mnuMedecinDernierRapport.Size = new System.Drawing.Size(195, 26);
            this.mnuMedecinDernierRapport.Text = "Dernier rapport";
            // 
            // mnuMedecinRechercher
            // 
            this.mnuMedecinRechercher.Name = "mnuMedecinRechercher";
            this.mnuMedecinRechercher.Size = new System.Drawing.Size(195, 26);
            this.mnuMedecinRechercher.Text = "Rechercher";
            // 
            // mnuMedecinListe
            // 
            this.mnuMedecinListe.Name = "mnuMedecinListe";
            this.mnuMedecinListe.Size = new System.Drawing.Size(195, 26);
            this.mnuMedecinListe.Text = "Liste";
            this.mnuMedecinListe.Click += new System.EventHandler(this.mnuMedecinListe_Click);
            // 
            // mnuRapport
            // 
            this.mnuRapport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRapportAjouter,
            this.mnuRapportRechercher,
            this.mnuRapportListe});
            this.mnuRapport.Name = "mnuRapport";
            this.mnuRapport.Size = new System.Drawing.Size(77, 24);
            this.mnuRapport.Text = "Rapport";
            // 
            // mnuRapportAjouter
            // 
            this.mnuRapportAjouter.Name = "mnuRapportAjouter";
            this.mnuRapportAjouter.Size = new System.Drawing.Size(224, 26);
            this.mnuRapportAjouter.Text = "Ajouter";
            // 
            // mnuRapportRechercher
            // 
            this.mnuRapportRechercher.Name = "mnuRapportRechercher";
            this.mnuRapportRechercher.Size = new System.Drawing.Size(224, 26);
            this.mnuRapportRechercher.Text = "Rechercher";
            this.mnuRapportRechercher.Click += new System.EventHandler(this.mnuRapportRechercher_Click);
            // 
            // mnuRapportListe
            // 
            this.mnuRapportListe.Name = "mnuRapportListe";
            this.mnuRapportListe.Size = new System.Drawing.Size(224, 26);
            this.mnuRapportListe.Text = "Liste";
            // 
            // mnuAide
            // 
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(30, 24);
            this.mnuAide.Text = "?";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.Location = new System.Drawing.Point(1311, 863);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(120, 30);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // LogoGSB
            // 
            this.LogoGSB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoGSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoGSB.Image = global::AppliGSB.Properties.Resources.Logo_GSB;
            this.LogoGSB.Location = new System.Drawing.Point(0, 0);
            this.LogoGSB.Name = "LogoGSB";
            this.LogoGSB.Size = new System.Drawing.Size(1561, 881);
            this.LogoGSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoGSB.TabIndex = 5;
            this.LogoGSB.TabStop = false;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1561, 881);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStripGSB);
            this.Controls.Add(this.LogoGSB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripGSB;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAccueil";
            this.Text = "Application Comptes-Rendus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            this.menuStripGSB.ResumeLayout(false);
            this.menuStripGSB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGSB;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierAccueil;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicament;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicamentGerer;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicamentListe;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteur;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteurListe;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteurGerer;
        private System.Windows.Forms.ToolStripMenuItem mnuVisiteurRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecin;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinGerer;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinDernierRapport;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuRapport;
        private System.Windows.Forms.ToolStripMenuItem mnuRapportAjouter;
        private System.Windows.Forms.ToolStripMenuItem mnuRapportRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuRapportListe;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuMedecinListe;
        private System.Windows.Forms.PictureBox LogoGSB;
    }
}

