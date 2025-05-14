using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoucheAccesDonnees;
using CoucheMetier;
using CoucheLogiqueMetier;

namespace AppliGSB
{
    public partial class FrmMedicament : Form
    {
        public FrmMedicament()
        {
            InitializeComponent();
        }


        private void FrmMedicament_Load(object sender, EventArgs e)
        {
            // 1️⃣ Charger et afficher les familles dans la combo
            comboFamilles.Items.Clear();
            List<Famille> familles = Manager.ChargerFamilles();
            foreach (Famille f in familles)
            {
                comboFamilles.Items.Add(f);
            }
            comboFamilles.DisplayMember = "Libelle";

            // 2️⃣ Charger les médicaments APRÈS avoir les familles
            listMedicaments.Items.Clear();
            List<Medicament> medicaments = Manager.ChargerMedicaments(); // doit avoir les familles liées déjà
            foreach (Medicament m in medicaments)
            {
                listMedicaments.Items.Add(m);
            }
        }


        private void listMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupération de l'indice du médicament sélectionné
            int indexMed = this.listMedicaments.SelectedIndex;

            // récupération du médicament dans la classe manager
            Medicament unMed = Manager.GetMedicament(indexMed);

            // mise à jour des champs de texte
            this.txtId.Text = unMed.Id;
            this.txtNomCommercial.Text = unMed.NomCommercial;
            this.txtEffets.Text = unMed.Effets;
            this.txtComposition.Text = unMed.Composition;
            this.txtContreIndications.Text = unMed.ContreIndications;


            // Récupération de la famille du médicament grâce au Manager
            Famille laFamille = Manager.GetFamilleDuMedicament(unMed);

            // 🔁 Afficher la bonne famille dans la combo
            for (int i = 0; i < comboFamilles.Items.Count; i++)
            {
                Famille f = (Famille)comboFamilles.Items[i];
                if (f.Id == laFamille.Id)
                {
                    comboFamilles.SelectedIndex = i;
                    break;
                }
            }


        }

        private void comboFamilles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
