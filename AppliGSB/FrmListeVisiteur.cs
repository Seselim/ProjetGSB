using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoucheLogiqueMetier;
using CoucheMetier;

namespace AppliGSB
{
    public partial class FrmListeVisiteur : Form
    {
        public FrmListeVisiteur()
        {
            InitializeComponent();
        }

        private void FrmListeVisiteur_Load(object sender, EventArgs e)
        {
            listVisiteur.Items.Clear();

            List<Visiteur> lesVisiteurs = Manager.ChargerTousVisiteurs();

            foreach (Visiteur v in lesVisiteurs)
            {
                listVisiteur.Items.Add(v);
            }
            listVisiteur.SelectedIndexChanged += listVisiteur_SelectedIndexChanged; // 🔥 Important !
        }


        private void listVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVisiteur.SelectedItem == null) return;

            Visiteur v = (Visiteur)listVisiteur.SelectedItem;
            txtId.Text = v.Id;
            txtNom.Text = v.Nom;
            txtPrenom.Text = v.Prenom;
            txtAdresse.Text = v.Adresse;
            txtVille.Text = v.Ville;
            txtCp.Text = v.Cp;
            txtDateEmbauche.Text = v.DateEmbauche;
        }
    }
}