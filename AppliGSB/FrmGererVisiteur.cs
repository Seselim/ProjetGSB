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

namespace AppliGSB
{
    public partial class FrmGererVisiteur : Form
    {
        public FrmGererVisiteur()
        {
            InitializeComponent();
        }

        private void FrmGererVisiteur_Load(object sender, EventArgs e)
        {
            ActualiserListeVisiteurs();
            BtnAjouter.Visible = false;
        }

        private void listVisiteurs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listVisiteurs.SelectedItem == null) return;

            Visiteur v = (Visiteur)listVisiteurs.SelectedItem;
            txtId.Text = v.Id;
            txtNom.Text = v.Nom;
            txtPrenom.Text = v.Prenom;
            txtAdresse.Text = v.Adresse;
            txtVille.Text = v.Ville;
            txtCp.Text = v.Cp;
            txtDateEmbauche.Text = v.DateEmbauche;
            txtLogin.Text = v.Login;
            txtMdp.Text = v.Mdp;
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            ViderChamps();
            BtnAjouter.Visible = true;
            BtnNouveau.Visible = false;
            listVisiteurs.Enabled = false;
            BtnModifier.Enabled = false;
            BtnSupprimer.Enabled = false;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (!ChampsSontComplets()) return;

            Visiteur v = new Visiteur(
                txtId.Text,
                txtNom.Text,
                txtPrenom.Text,
                txtAdresse.Text,
                txtDateEmbauche.Text,
                txtCp.Text,
                txtVille.Text,
                txtLogin.Text,
                txtMdp.Text
            );

            Manager.InsererVisiteur(v);
            MessageBox.Show("Visiteur ajouté avec succès !");
            ActualiserListeVisiteurs();
            ReinitialiserEtat();
        }


        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (listVisiteurs.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un visiteur.");
                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir modifier ce visiteur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Visiteur v = (Visiteur)listVisiteurs.SelectedItem;
                v.Nom = txtNom.Text;
                v.Prenom = txtPrenom.Text;
                v.Adresse = txtAdresse.Text;
                v.Ville = txtVille.Text;
                v.Cp = txtCp.Text;
                v.DateEmbauche = txtDateEmbauche.Text;
                v.Login = txtLogin.Text;
                v.Mdp = txtMdp.Text;

                Manager.ModifierVisiteur(v);

                MessageBox.Show("Visiteur modifié avec succès.");
                ActualiserListeVisiteurs();
            }
        }

        private void BtnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (listVisiteurs.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un visiteur.");
                return;
            }

            Visiteur v = (Visiteur)listVisiteurs.SelectedItem;

            if (Manager.VisiteurADesRapports(v))
            {
                MessageBox.Show("Impossible de supprimer : le visiteur a des rapports.");
                return;
            }

            if (MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Manager.SupprimerVisiteur(v);
                ActualiserListeVisiteurs();
                ViderChamps();
                MessageBox.Show("Visiteur supprimé.");
            }
        }

        private bool ChampsSontComplets()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtAdresse.Text) ||
                string.IsNullOrWhiteSpace(txtVille.Text) ||
                string.IsNullOrWhiteSpace(txtCp.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtMdp.Text) ||
                string.IsNullOrWhiteSpace(txtDateEmbauche.Text))
            {
                MessageBox.Show("Veuillez remplir toutes les informations.");
                return false;
            }
            return true;
        }

        private void ActualiserListeVisiteurs()
        {
            listVisiteurs.Items.Clear();
            List<Visiteur> visiteurs = Manager.ChargerTousVisiteurs();
            foreach (Visiteur v in visiteurs)
            {
                listVisiteurs.Items.Add(v);
            }
        }

        private void ViderChamps()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAdresse.Text = "";
            txtVille.Text = "";
            txtCp.Text = "";
            txtLogin.Text = "";
            txtMdp.Text = "";
            txtDateEmbauche.Text = "";
        }

        private void ReinitialiserEtat()
        {
            BtnAjouter.Visible = false;
            BtnNouveau.Visible = true;
            listVisiteurs.Enabled = true;
            BtnModifier.Enabled = true;
            BtnSupprimer.Enabled = true;
        }



    }
}
