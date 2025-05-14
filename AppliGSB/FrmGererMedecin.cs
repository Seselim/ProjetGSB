using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoucheLogiqueMetier;
using CoucheMetier;


namespace AppliGSB
{
    public partial class FrmGererMedecin : Form
    {
        public FrmGererMedecin()
        {
            InitializeComponent();
        }

        private void FrmGererMedecin_Load(object sender, EventArgs e)
        {
            comboSpecialites.Items.Clear();
            foreach (Specialite s in Manager.ChargerToutesLesSpecialites())
            {
                comboSpecialites.Items.Add(s);
            }

            ActualiserListeMedecins();
            BtnAjouter.Visible = false;
        }

        private void listMedecins_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Vérifie si un item est sélectionné
            if (listMedecins.SelectedItem is Medecin m)
            {
                // Recharge bien la spécialité depuis la base
                Manager.ChargerSpecialiteDuMedecin(m);

                // Mets à jour les champs
                txtId.Text = m.Id;
                txtNom.Text = m.Nom;
                txtPrenom.Text = m.Prenom;
                txtAdresse.Text = m.Adresse;
                txtTel.Text = m.Tel;
                txtDepartement.Text = m.Departement;

                // 👇 Correctement mettre à jour la combo via comparaison sur ID
                comboSpecialites.SelectedItem = comboSpecialites.Items
                    .Cast<Specialite>()
                    .FirstOrDefault(s => s.Id == m.LaSpecialite?.Id);

                // Réactiver le bon état des boutons
                ReinitialiserEtat();
            }
        }



        private void BtnNouveau_Click_1(object sender, EventArgs e)
        {
            ViderChamps();
            BtnAjouter.Visible = true;
            BtnNouveau.Visible = false;
            BtnModifier.Enabled = false;
            BtnSupprimer.Enabled = false;
        }

        private void BtnAjouter_Click_1(object sender, EventArgs e)
        {
            if (comboSpecialites.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez une spécialité.");
                return;
            }

            Medecin m = new Medecin("0", txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTel.Text, txtDepartement.Text, (Specialite)comboSpecialites.SelectedItem);

            Manager.InsererMedecin(m);
            ActualiserListeMedecins();
            ViderChamps();
            MessageBox.Show("Médecin ajouté avec succès !");

            ReinitialiserEtat();
        }

        private void BtnModifier_Click_1(object sender, EventArgs e)
        {
            if (listMedecins.SelectedItem is Medecin m)
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                    string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                    string.IsNullOrWhiteSpace(txtAdresse.Text) ||
                    string.IsNullOrWhiteSpace(txtTel.Text) ||
                    string.IsNullOrWhiteSpace(txtDepartement.Text) ||
                    comboSpecialites.SelectedIndex == -1)
                {
                    MessageBox.Show("Informations incomplètes.");
                    return;
                }

                m.Nom = txtNom.Text;
                m.Prenom = txtPrenom.Text;
                m.Adresse = txtAdresse.Text;
                m.Tel = txtTel.Text;
                m.Departement = txtDepartement.Text;
                m.LaSpecialite = (Specialite)comboSpecialites.SelectedItem;

                Manager.ModifierMedecin(m);
                ActualiserListeMedecins();
                MessageBox.Show("Médecin modifié !");
                ReinitialiserEtat();
            }
        }

        private void BtnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (listMedecins.SelectedItem is Medecin m)
            {
                if (Manager.MedecinADesRapports(m))
                {
                    MessageBox.Show("Impossible de supprimer : médecin lié à des rapports.");
                    return;
                }

                if (MessageBox.Show("Confirmer suppression ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Manager.SupprimerMedecin(m);
                    ActualiserListeMedecins();
                    ViderChamps();
                    MessageBox.Show("Médecin supprimé.");
                    ReinitialiserEtat();
                }
            }
        }

        private void ActualiserListeMedecins()
        {
            listMedecins.BeginUpdate();
            listMedecins.Items.Clear();

            List<Medecin> lesMedecins = Manager.ChargerTousMedecins();

            foreach (Medecin m in lesMedecins)
            {
                Manager.ChargerSpecialiteDuMedecin(m); // Toujours appeler pour avoir les bons noms
                listMedecins.Items.Add(m);
            }

            listMedecins.EndUpdate();
        }


        private void ViderChamps()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAdresse.Text = "";
            txtTel.Text = "";
            txtDepartement.Text = "";
            comboSpecialites.SelectedIndex = -1;
        }

        private void ReinitialiserEtat()
        {
            BtnAjouter.Visible = false;
            BtnNouveau.Visible = true;
            listMedecins.Enabled = true;
            BtnModifier.Enabled = true;
            BtnSupprimer.Enabled = true;
        }
    }
}