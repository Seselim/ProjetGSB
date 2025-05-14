using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoucheAccesDonnees;
using CoucheMetier;


namespace CoucheLogiqueMetier
{
    public class Manager
    {
        // Liste des médicaments
        private static List<Medicament> lesMeds;


        // Constructeur
        public Manager()
        {
        }

        /// <summary>
        /// Charge la liste des médicaments à partir de la base de données en utilisant la classe Passerelle
        /// </summary>
        /// <returns>la liste des médicaments</returns>
        public static List<Medicament> ChargerMedicaments()
        {
            lesMeds = Passerelle.GetTousMedicaments();

            // 🔁 Associer une famille à chaque médicament
            foreach (Medicament m in lesMeds)
            {
                m.Famille = Passerelle.GetFamilleDuMedicament(m.Id);
            }

            return lesMeds;
        }

        /// <summary>
        /// Accesseur en lecture pour un médicament
        /// </summary>
        /// <param name="index">l'indice du médicament voulu</param>
        /// <returns>le médicament situé à l'indice index</returns>
        public static Medicament GetMedicament(int index)
        {
            return lesMeds[index];
        }

        // Récupère la famille d'un médicament
        public static Famille GetFamilleDuMedicament(Medicament unMed)
        {
            // Récupère la famille du médicament grâce à son id
            Famille laFamille = Passerelle.GetFamilleDuMedicament(unMed.Id);
            // Attribue cette famille au médicament
            unMed.Famille = laFamille;
            // Retourne la famille
            return laFamille;
        }








        private static List<Medecin> lesMedecins;

        // Charge tous les médecins via la Passerelle
        public static List<Medecin> ChargerTousMedecins()
        {
            lesMedecins = Passerelle.GetTousMedecins();
            // 🔄 On parcourt les médecins et on leur associe leur spécialité
            foreach (Medecin m in lesMedecins)
            {
                Specialite s = Passerelle.GetSpecialiteDuMedecin(m.Id);
                m.LaSpecialite = s;
            }
            return lesMedecins;
        }

        // Accesseur pour un médecin selon l’index
        public static Medecin GetMedecin(int index)
        {
            return lesMedecins[index];
        }

        // Récupère la spécialité d’un médecin via la Passerelle et l’associe
        public static Specialite ChargerSpecialiteDuMedecin(Medecin unMedecin)
        {
            Specialite laSpecialite = Passerelle.GetSpecialiteDuMedecin(unMedecin.Id);
            unMedecin.LaSpecialite = laSpecialite;
            return laSpecialite;
        }
        // Charger toutes les spécialités
        private static List<Specialite> lesSpecialites;

        public static List<Specialite> ChargerToutesLesSpecialites()
        {
            if (lesSpecialites == null)
            {
                lesSpecialites = Passerelle.GetToutesLesSpecialites();
            }
            return lesSpecialites;
        }

        // Insérer un nouveau médecin
        public static void InsererMedecin(Medecin m)
        {
            Passerelle.InsererMedecin(m);
            ChargerTousMedecins(); // Rafraîchit la liste
        }

        // Modifier un médecin
        public static void ModifierMedecin(Medecin m)
        {
            Passerelle.ModifierMedecin(m);
            ChargerTousMedecins(); // Rafraîchit la liste
        }

        // Vérifier si le médecin a des rapports
        public static bool MedecinADesRapports(Medecin m)
        {
            return Passerelle.MedecinADesRapports(m.Id);
        }

        // Supprimer un médecin
        public static void SupprimerMedecin(Medecin m)
        {
            Passerelle.SupprimerMedecin(m.Id);
            ChargerTousMedecins(); // Rafraîchit la liste
        }



        // Liste Famille et Médicament
        private static List<Famille> lesFamilles;
        private static List<Medicament> lesMedicaments = new List<Medicament>();

        public static List<Famille> ChargerFamilles()
        {
            if (lesFamilles == null)
            {
                lesFamilles = Passerelle.GetToutesLesFamilles(); 
            }
            return lesFamilles;
        }


        public static Famille GetFamilles(int index)
        {
            return lesFamilles[index];
        }

        public static void AjouterMedicament(Medicament m)
        {
            lesMedicaments.Add(m);
            
        }

        public static void InsererMedicament(Medicament unMed)
        {
            Passerelle.InsererMedicament(unMed);
            lesMedicaments.Add(unMed); 
            ChargerMedicaments(); // recharge depuis la base
        }


        //supprimer medoc
        public static void SupprimerMedicament(Medicament m)
        {
            Passerelle.SupprimerMedicament(m.Id);
            lesMedicaments.Remove(m); // facultatif
        }
        //modifier medoc
        public static void ModifierMedicament(Medicament m)
        {
            Passerelle.ModifierMedicament(m);
            // 🔁 Mettre à jour aussi dans la liste mémoire (lesMedicaments)
            for (int i = 0; i < lesMedicaments.Count; i++)
            {
                if (lesMedicaments[i].Id == m.Id)
                {
                    lesMedicaments[i] = m;
                    break;
                }
            }

        }

        public static bool MedicamentExiste(string id)
        {
            return Passerelle.MedicamentExiste(id);
        }







        private static List<Visiteur> lesVisiteurs;

        // Charger
        public static List<Visiteur> ChargerTousVisiteurs()
        {
            lesVisiteurs = Passerelle.GetTousVisiteurs();
            return lesVisiteurs;
        }

        // Insertion
        public static void InsererVisiteur(Visiteur v)
        {
            Passerelle.InsererVisiteur(v);
            lesVisiteurs.Add(v);
        }

        // Modification
        public static void ModifierVisiteur(Visiteur v)
        {
            Passerelle.ModifierVisiteur(v);
        }

        // Suppression
        public static void SupprimerVisiteur(Visiteur v)
        {
            Passerelle.SupprimerVisiteur(v.Id); 
            lesVisiteurs.Remove(v);
        }



        // Vérifier rapports
        public static bool VisiteurADesRapports(Visiteur v)
        {
            return Passerelle.VisiteurADesRapports(v.Id);
        }

        public static List<Rapport> ChargerTousRapports()
        {
            return Passerelle.GetTousRapports();  // À condition que ta passerelle ait cette méthode
        }



        public static List<Rapport> ChargerRapportsVisiteur(string idVisiteur)
        {
            return Passerelle.GetRapportsParVisiteur(idVisiteur);
        }

        public static List<Rapport> ChargerRapportsParMedecin(string idMedecin)
        {
            return Passerelle.GetRapportsParMedecin(idMedecin);
        }
        public static Visiteur GetVisiteurById(string id)
        {
            return Passerelle.GetVisiteurById(id);
        }

        public static Medecin GetMedecinById(string id)
        {
            return Passerelle.GetMedecinById(id);
        }


        public static List<Offrir> ChargerOffresParRapport(string idRapport)
        {
            return Passerelle.GetOffresParRapport(idRapport);
        }











    }
}