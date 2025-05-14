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
    public partial class FrmNouveauMedicament : Form
    {
        public FrmNouveauMedicament()
        {
            InitializeComponent();
        }

        private void FrmNouveauMedicament_Load(object sender, EventArgs e)
        {
            comboFamilles.Items.Clear();
            List<Famille> lesFamilles = Manager.ChargerFamilles();
            foreach (Famille f in lesFamilles)
            {
                comboFamilles.Items.Add(f);
            }
            ActualiserListeMedicaments();

            BtnAjouter.Visible = false;
        }


        private void ActualiserListeMedicaments()
        {
            listMedicaments.Items.Clear();
            List<Medicament> lesMedicaments = Manager.ChargerMedicaments();
            foreach (Medicament med in lesMedicaments)
            {
                listMedicaments.Items.Add(med);
            }
        }

        private void listMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMedicaments.SelectedIndex == -1) return;

            Medicament med = (Medicament)listMedicaments.SelectedItem;

            txtId.Text = med.Id;
            txtNomCommercial.Text = med.NomCommercial;
            txtEffets.Text = med.Effets;
            txtComposition.Text = med.Composition;
            txtContreIndications.Text = med.ContreIndications;

            // Affiche la famille dans la combo
            for (int i = 0; i < comboFamilles.Items.Count; i++)
            {
                Famille f = (Famille)comboFamilles.Items[i];
                if (f.Id == med.Famille.Id)
                {
                    comboFamilles.SelectedIndex = i;
                    break;
                }
            }

            txtId.ReadOnly = true; // Pour éviter de modifier l'ID par erreur
            BtnAjouter.Hide();
            BtnNouveau.Show();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (!VerifierChamps())
            {
                return;
            }

            string id = txtId.Text.Trim();

            if (Manager.MedicamentExiste(id))
            {
                MessageBox.Show("L'ID existe déjà !");
                return;
            }

            Medicament med = CreerMedicamentDepuisChamps();
            Manager.InsererMedicament(med);

            MessageBox.Show("Médicament ajouté !");
            ActualiserListeMedicaments();
            ViderChamps();

            BtnAjouter.Visible = false;
            BtnNouveau.Visible = true;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (listMedicaments.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez un médicament.");
                return;
            }

            Medicament med = (Medicament)listMedicaments.SelectedItem;
            DialogResult result = MessageBox.Show("Confirmer suppression ?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Manager.SupprimerMedicament(med);
                MessageBox.Show("Médicament supprimé.");
                ActualiserListeMedicaments();
                ViderChamps();
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (listMedicaments.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez un médicament.");
                return;
            }

            if (!VerifierChamps())
            {
                return;
            }

            Medicament med = (Medicament)listMedicaments.SelectedItem;

            med.NomCommercial = txtNomCommercial.Text.Trim();
            med.Composition = txtComposition.Text.Trim();
            med.Effets = txtEffets.Text.Trim();
            med.ContreIndications = txtContreIndications.Text.Trim();
            med.Famille = (Famille)comboFamilles.SelectedItem;

            Manager.ModifierMedicament(med);

            MessageBox.Show("Médicament modifié !");
            ActualiserListeMedicaments();
            ViderChamps();
        }

        private Medicament CreerMedicamentDepuisChamps()
        {
            string id = txtId.Text.Trim();
            string nomCommercial = txtNomCommercial.Text.Trim();
            string composition = txtComposition.Text.Trim();
            string effets = txtEffets.Text.Trim();
            string contreIndications = txtContreIndications.Text.Trim();
            Famille famille = (Famille)comboFamilles.SelectedItem;

            return new Medicament(id, nomCommercial, composition, effets, contreIndications, famille);
        }

        private bool VerifierChamps()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNomCommercial.Text) ||
                string.IsNullOrWhiteSpace(txtComposition.Text) ||
                string.IsNullOrWhiteSpace(txtEffets.Text) ||
                string.IsNullOrWhiteSpace(txtContreIndications.Text) ||
                comboFamilles.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return false;
            }

            return true;
        }

        private void ViderChamps()
        {
            txtId.Text = "";
            txtNomCommercial.Text = "";
            txtComposition.Text = "";
            txtEffets.Text = "";
            txtContreIndications.Text = "";
            comboFamilles.SelectedIndex = -1;
            listMedicaments.ClearSelected();
            txtId.ReadOnly = false;
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            ViderChamps();
            txtId.ReadOnly = false;
            BtnNouveau.Visible = false;
            BtnAjouter.Visible = true;
        }
    }
}

