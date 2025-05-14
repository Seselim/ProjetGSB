using AppliGSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliGSB
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void fermerMDI()
        {
            Form c;
            c = this.ActiveMdiChild;    // Récupère le formulaire actif
            if (c != null)      // S’il existe,
                c.Close();  // on le ferme
        }
        private void rendVisible(bool val)      // val vaut true ou false
        {
            LogoGSB.Visible = val;      // La propriété Visible passe à Vrai ou Faux
            btnQuitter.Visible = val;
        }
        private void mnuMedicamentListe_Click(object sender, EventArgs e)
        {
            fermerMDI();        // Ferme le formulaire actif
            rendVisible(false);     // Rend invisibles les composants de FrmAccueil
            FrmMedicament frmMedicament = new FrmMedicament(); // Crée une instance de FrmMedicament
            frmMedicament.MdiParent = this; //Le formulaire MDI parent est l'instance en cours (this)
                                            // de FrmAccueil
            frmMedicament.Show();   // Montre le nouveau formulaire
        }

        private void mnuFichierAccueil_Click(object sender, EventArgs e)
        {
            FrmAccueil accueil = new FrmAccueil(); // Créer une nouvelle instance de la page d'accueil
            accueil.MdiParent = this.MdiParent;    // IMPORTANT : rattacher au même MDI parent
            accueil.Show();                        // Afficher l'accueil

            this.Hide();
        }

        private void mnuMedecinListe_Click(object sender, EventArgs e)
        {
            fermerMDI();        // Ferme le formulaire actif
            rendVisible(false);     // Rend invisibles les composants de FrmAccueil
            FrmMedecin frmMedecin = new FrmMedecin(); // Crée une instance de FrmMedicament
            frmMedecin.MdiParent = this; //Le formulaire MDI parent est l'instance en cours (this)
                                         // de FrmAccueil
            frmMedecin.Show();   // Montre le nouveau formulaire
        }

        private void mnuMedecinGerer_Click(object sender, EventArgs e)
        {
            fermerMDI();                                                                        // Ferme le formulaire actif
            rendVisible(false);                                                                // Rend invisibles les composants de FrmAccueil
            FrmGererMedecin frmGererMedecin = new FrmGererMedecin();           // Crée une instance de frmNouveauMedicament
            frmGererMedecin.MdiParent = this;                                           //Le formulaire MDI parent est l'instance en cours (this)
                                                                                        // de FrmAccueil
            frmGererMedecin.Show();
        }

        private void mnuMedicamentGerer_Click(object sender, EventArgs e)
        {
            fermerMDI();                                                                        // Ferme le formulaire actif
            rendVisible(false);                                                                // Rend invisibles les composants de FrmAccueil
            FrmNouveauMedicament frmNouveauMedicament = new FrmNouveauMedicament();           // Crée une instance de frmNouveauMedicament
            frmNouveauMedicament.MdiParent = this;                                           //Le formulaire MDI parent est l'instance en cours (this)
                                                                                             // de FrmAccueil
            frmNouveauMedicament.Show();
        }

        private void mnuVisiteurListe_Click(object sender, EventArgs e)
        {
            fermerMDI();                                                                        // Ferme le formulaire actif
            rendVisible(false);                                                                // Rend invisibles les composants de FrmAccueil
            FrmListeVisiteur frmListeVisiteur = new FrmListeVisiteur();           // Crée une instance de frmNouveauMedicament
            frmListeVisiteur.MdiParent = this;                                           //Le formulaire MDI parent est l'instance en cours (this)
                                                                                         // de FrmAccueil
            frmListeVisiteur.Show();
        }

        private void mnuVisiteurGerer_Click(object sender, EventArgs e)
        {
            fermerMDI();                                                                        // Ferme le formulaire actif
            rendVisible(false);                                                                // Rend invisibles les composants de FrmAccueil
            FrmGererVisiteur frmGererVisiteur = new FrmGererVisiteur();           // Crée une instance de frmNouveauMedicament
            frmGererVisiteur.MdiParent = this;                                           //Le formulaire MDI parent est l'instance en cours (this)
                                                                                         // de FrmAccueil
            frmGererVisiteur.Show();
        }

        private void mnuRapportRechercher_Click(object sender, EventArgs e)
        {
            fermerMDI();                                                                        // Ferme le formulaire actif
            rendVisible(false);                                                                // Rend invisibles les composants de FrmAccueil
            FrmRapportRecherche frmRapportRecherche = new FrmRapportRecherche();           // Crée une instance de frmNouveauMedicament
            frmRapportRecherche.MdiParent = this;                                           //Le formulaire MDI parent est l'instance en cours (this)
                                                                                            // de FrmAccueil
            frmRapportRecherche.Show();
        }
    }
}    