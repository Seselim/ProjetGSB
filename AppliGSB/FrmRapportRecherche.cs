using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoucheMetier;
using CoucheLogiqueMetier;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
namespace AppliGSB
{
    public partial class FrmRapportRecherche : Form
    {
        List<Visiteur> lesVisiteurs;
        List<Medecin> lesMedecins;
        List<Rapport> lesRapportsVisiteur;
        List<Rapport> lesRapportsMedecin;
        public FrmRapportRecherche()
        {
            InitializeComponent();
        }

        private void FrmRapportRecherche_Load(object sender, EventArgs e)
        {
            comboVisiteurs.Items.Clear();
            foreach (Visiteur v in Manager.ChargerTousVisiteurs())
            {
                comboVisiteurs.Items.Add(v);
            }


            comboMedecins.Items.Clear();
            foreach (Medecin m in Manager.ChargerTousMedecins())
            {
                comboMedecins.Items.Add(m);
            }

            // Optionnel si tu veux aussi charger TOUS les rapports au démarrage :
            listRapports.Items.Clear();
            List<Rapport> rapports = Manager.ChargerTousRapports();
            foreach (Rapport r in rapports)
            {
                listRapports.Items.Add(r.Id.ToString());
            }

        }



        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btRechercherRapportVisiteur_Click(object sender, EventArgs e)
        {
           listRapports.Items.Clear();

            if (comboVisiteurs.SelectedItem is Visiteur v)
            {
                List<Rapport> lesRapportsVisiteur = Manager.ChargerRapportsVisiteur(v.Id);

                foreach (Rapport r in lesRapportsVisiteur)
                {
                    listRapports.Items.Add(r.Id.ToString());
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un visiteur.");
            }
        }



        private void btRechercherRapportMedecin_Click(object sender, EventArgs e)
        {
            listRapports.Items.Clear();

            if (comboMedecins.SelectedItem is Medecin m)
            {
                // On récupère bien la liste des rapports du médecin
                List<Rapport> lesRapportsMedecin = Manager.ChargerRapportsParMedecin(m.Id);

                // On n'affiche que les id des rapports (en string dans la ListBox)
                foreach (Rapport r in lesRapportsMedecin)
                {
                    listRapports.Items.Add(r.Id.ToString());
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un médecin.");
            }
        }


        private void listRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRapports.SelectedItems.Count > 0)
            {
                // Récupérer le Tag (que tu dois avoir mis au moment du Add)
                Rapport r = listRapports.SelectedItems[0].Tag as Rapport;
                if (r != null)
                {
                    // Affichage général du rapport
                    txtMotif.Text = r.Motif;
                    txtDateVisite.Text = r.Date.ToString("yyyy-MM-dd");
                    txtBilan.Text = r.Bilan;

                    // Chargement complet du visiteur
                    Visiteur v = Manager.GetVisiteurById(r.IdVisiteur.ToString());
                    if (v != null)
                    {
                        txtNomVisiteur.Text = v.Nom;
                        txtPrenomVisiteur.Text = v.Prenom;
                    }

                    // Chargement complet du médecin
                    Medecin m = Manager.GetMedecinById(r.IdMedecin.ToString());
                    if (m != null)
                    {
                        txtNomMedecin.Text = m.Nom;
                        txtPrenomMedecin.Text = m.Prenom;
                        txtAdresseMedecin.Text = m.Adresse;
                    }

                    
                    
                }
            }
        }


        private void comboVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
            {

            }


    }
    }


