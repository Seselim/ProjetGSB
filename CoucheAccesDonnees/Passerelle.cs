using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using CoucheMetier;


namespace CoucheAccesDonnees
{
    public class Passerelle
    {
        // CONNEXION
        private static MySqlConnection connexion = null;

        private static MySqlConnection GetConnexion()
        {
            if (connexion != null)
            {
                return connexion;
            }
            else
            {
                string chConnexion = "SERVER=localhost;DATABASE=bdgsb;UID=root;";
                connexion = new MySqlConnection(chConnexion);
                connexion.Open();
                return connexion;
            }
        }

        public static Medicament GetUnMedicament(string idMedicament)
        {
            Medicament unMedicament = null;

            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM medicament WHERE id = '" + idMedicament + "'";
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                // Appel direct de la méthode MapperLigneMedicament
                unMedicament = MapperLigneMedicament(rdr);
            }

            rdr.Close();
            return unMedicament;
        }



        public static List<Medicament> GetTousMedicaments()
        {
            List<Medicament> lesMedicaments = new List<Medicament>();

            //Connexion
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM medicament";
            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                // Appel direct de la méthode MapperLigneMedicament
                Medicament unMedicament = MapperLigneMedicament(rdr);
                lesMedicaments.Add(unMedicament);
            }

            rdr.Close();
            return lesMedicaments;
        }


        /// <summary>
        /// Crée un médicament à partir d'une ligne de résultat du jeu d'enregistrements
        /// </summary>
        /// <param name="rdr">le jeu d'enregistrements</param>
        /// <returns>le médicament correspondant à la ligne lue</returns>
        private static Medicament MapperLigneMedicament(MySqlDataReader rdr)
        {
            string id, nomCommercial, composition, effets, contreIndications;

            // Récupération des informations du médicament
            id = rdr["id"].ToString();
            nomCommercial = rdr["nomCommercial"].ToString();
            composition = rdr["composition"].ToString();
            effets = rdr["effets"].ToString();
            contreIndications = rdr["contreIndications"].ToString();
            // on s'occupera de la famille plus tard

            // Instanciation du médicament
            Medicament unMedicament = new Medicament(id, nomCommercial, composition, effets, contreIndications, null);

            return unMedicament;
        }




        // FAMILLE DU MEDICAMENT
        // Récupère la famille du médicament dont l'id est passé en paramètre
        public static Famille GetFamilleDuMedicament(string idMedicament)
        {
            Famille laFamille = null;

            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT famille.* FROM famille INNER JOIN medicament "
                            + "ON medicament.idFamille = famille.id WHERE medicament.id = '" + idMedicament + "'";

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                // fait appel à MapperLigneFamille
                laFamille = MapperLigneFamille(rdr);
            }
            rdr.Close();
            return laFamille;
        }

        // FAMILLE DU MEDICAMENT
        // Crée une famille à partir d'une ligne de résultat du jeu d'enregistrements
        private static Famille MapperLigneFamille(MySqlDataReader rdr)
        {
            string id, libelle;
            id = rdr["id"].ToString();
            libelle = rdr["libelle"].ToString();

            Famille laFamille = new Famille(id, libelle);
            return laFamille;
        }


        public static List<Famille> GetToutesLesFamilles()
        {
            List<Famille> familles = new List<Famille>();

            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM famille";

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string id = rdr["id"].ToString();
                string libelle = rdr["libelle"].ToString();

                Famille f = new Famille(id, libelle);
                familles.Add(f);
            }
            rdr.Close();
            return familles;
        }

        public static void InsererMedicament(Medicament unMed)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO medicament (id, nomCommercial, composition, effets, contreIndications, idFamille) " +
                              "VALUES (@id, @nomCommercial, @composition, @effets, @contreIndications, @idFamille)";

            cmd.Parameters.AddWithValue("@id", unMed.Id);
            cmd.Parameters.AddWithValue("@nomCommercial", unMed.NomCommercial);
            cmd.Parameters.AddWithValue("@composition", unMed.Composition);
            cmd.Parameters.AddWithValue("@effets", unMed.Effets);
            cmd.Parameters.AddWithValue("@contreIndications", unMed.ContreIndications);
            cmd.Parameters.AddWithValue("@idFamille", unMed.Famille.Id);

            cmd.ExecuteNonQuery();
        }




        // Récupère tous les médecins
        public static List<Medecin> GetTousMedecins()
        {
            List<Medecin> lesMedecins = new List<Medecin>();

            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT medecin.*, specialite.id as idSpecialite, specialite.Specialite " +
                              "FROM medecin INNER JOIN specialite ON medecin.idSpecialite = specialite.id";

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Medecin unMedecin = MapperLigneMedecin(rdr);
                lesMedecins.Add(unMedecin);
            }

            rdr.Close();
            return lesMedecins;
        }

        // Convertit une ligne SQL en objet Medecin
        private static Medecin MapperLigneMedecin(MySqlDataReader rdr)
        {
            string id = rdr["id"].ToString();
            string nom = rdr["nom"].ToString();
            string prenom = rdr["prenom"].ToString();
            string adresse = rdr["adresse"].ToString();
            string tel = rdr["tel"].ToString();
            string departement = rdr["departement"].ToString();

            // Mapper la spécialité
            Specialite laSpecialite = MapperLigneSpecialite(rdr);

            Medecin unMedecin = new Medecin(id, nom, prenom, adresse, tel, departement, laSpecialite);
            return unMedecin;
        }

        // Récupère la spécialité d’un médecin en base
        public static Specialite GetSpecialiteDuMedecin(string idMedecin)
        {
            Specialite laSpecialite = null;

            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT specialite.* FROM specialite " +
                              "INNER JOIN medecin ON medecin.idSpecialite = specialite.id " +
                              "WHERE medecin.id = '" + idMedecin + "'";

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                laSpecialite = MapperLigneSpecialite(rdr);
            }

            rdr.Close();
            return laSpecialite;
        }
        public static List<Specialite> GetToutesLesSpecialites()
        {
            List<Specialite> liste = new List<Specialite>();

            using (MySqlCommand cmd = GetConnexion().CreateCommand())
            {
                cmd.CommandText = "SELECT id, specialite FROM specialite;";

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string id = rdr["id"].ToString();
                        string libelle = rdr["specialite"].ToString();

                        liste.Add(new Specialite(id, libelle));
                    }
                }
            }

            return liste;
        }


        // Convertit une ligne SQL en objet Specialite
        private static Specialite MapperLigneSpecialite(MySqlDataReader rdr)
        {
            string id = rdr["id"].ToString();
            string libelle = rdr["specialite"].ToString();

            return new Specialite(id, libelle);
        }

        public static void InsererMedecin(Medecin m)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO medecin(nom, prenom, adresse, tel, departement, idSpecialite) VALUES (@nom, @prenom, @adresse, @tel, @departement, @idSpecialite)";
            cmd.Parameters.AddWithValue("@nom", m.Nom);
            cmd.Parameters.AddWithValue("@prenom", m.Prenom);
            cmd.Parameters.AddWithValue("@adresse", m.Adresse);
            cmd.Parameters.AddWithValue("@tel", m.Tel);
            cmd.Parameters.AddWithValue("@departement", m.Departement);
            cmd.Parameters.AddWithValue("@idSpecialite", m.LaSpecialite.Id);
            cmd.ExecuteNonQuery();
        }

        public static void ModifierMedecin(Medecin m)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE medecin SET nom=@nom, prenom=@prenom, adresse=@adresse, tel=@tel, departement=@departement, idSpecialite=@idSpecialite WHERE id=@id";
            cmd.Parameters.AddWithValue("@nom", m.Nom);
            cmd.Parameters.AddWithValue("@prenom", m.Prenom);
            cmd.Parameters.AddWithValue("@adresse", m.Adresse);
            cmd.Parameters.AddWithValue("@tel", m.Tel);
            cmd.Parameters.AddWithValue("@departement", m.Departement);
            cmd.Parameters.AddWithValue("@idSpecialite", m.LaSpecialite.Id);
            cmd.Parameters.AddWithValue("@id", m.Id);
            cmd.ExecuteNonQuery();
        }

        public static void SupprimerMedecin(string idMedecin)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM medecin WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", idMedecin);
            cmd.ExecuteNonQuery();
        }

        public static bool MedecinADesRapports(string idMedecin)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM rapport WHERE idMedecin=@id";
            cmd.Parameters.AddWithValue("@id", idMedecin);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }




        //supprimer un medicament
        public static void SupprimerMedicament(string idMedicament)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM medicament WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", idMedicament);
            cmd.ExecuteNonQuery();
        }


        // modifier un medicament
        public static void ModifierMedicament(Medicament m)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE medicament SET nomCommercial = @nom, composition = @composition, effets = @effets, contreIndications = @contre, idFamille = @idFamille WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", m.Id);
            cmd.Parameters.AddWithValue("@nom", m.NomCommercial);
            cmd.Parameters.AddWithValue("@composition", m.Composition);
            cmd.Parameters.AddWithValue("@effets", m.Effets);
            cmd.Parameters.AddWithValue("@contre", m.ContreIndications);
            cmd.Parameters.AddWithValue("@idFamille", m.Famille.Id);

            cmd.ExecuteNonQuery();
        }

        public static bool MedicamentExiste(string id)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM medicament WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }


        public static List<Visiteur> GetTousVisiteurs()
        {
            List<Visiteur> liste = new List<Visiteur>();

            // ✅ Connexion directe à la base comme dans GererMedecin
            MySqlConnection conn = new MySqlConnection("server=localhost;database=bdgsb;uid=root;pwd=;");
            conn.Open();

            string sql = "SELECT * FROM visiteur";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string id = rdr["id"].ToString();
                string nom = rdr["nom"].ToString();
                string prenom = rdr["prenom"].ToString();
                string adresse = rdr["adresse"].ToString();
                string dateEmbauche = rdr["dateEmbauche"].ToString();
                string cp = rdr["cp"].ToString();
                string ville = rdr["ville"].ToString();
                string login = rdr["login"].ToString();
                string mdp = rdr["mdp"].ToString();

                Visiteur v = new Visiteur(id, nom, prenom, adresse, dateEmbauche, cp, ville, login, mdp);
                liste.Add(v);
            }

            rdr.Close();
            conn.Close();

            return liste;
        }

        // Insérer visiteur
        public static void InsererVisiteur(Visiteur v)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO visiteur (id, nom, prenom, adresse, ville, cp, dateEmbauche, login, mdp) VALUES (@id, @nom, @prenom, @adresse, @ville, @cp, @dateEmbauche, @login, @mdp)";
            cmd.Parameters.AddWithValue("@id", v.Id);
            cmd.Parameters.AddWithValue("@nom", v.Nom);
            cmd.Parameters.AddWithValue("@prenom", v.Prenom);
            cmd.Parameters.AddWithValue("@adresse", v.Adresse);
            cmd.Parameters.AddWithValue("@ville", v.Ville);
            cmd.Parameters.AddWithValue("@cp", v.Cp);

            // ✅ Conversion propre vers 'yyyy-MM-dd'
            string dateSql = DateTime.Parse(v.DateEmbauche).ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@dateEmbauche", dateSql);

            cmd.Parameters.AddWithValue("@login", v.Login);
            cmd.Parameters.AddWithValue("@mdp", v.Mdp);

            cmd.ExecuteNonQuery();
        }



        // Modifier visiteur
        public static void ModifierVisiteur(Visiteur v)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE visiteur SET nom = @nom, prenom = @prenom, adresse = @adresse, ville = @ville, cp = @cp, dateEmbauche = @dateEmbauche WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", v.Id);
            cmd.Parameters.AddWithValue("@nom", v.Nom);
            cmd.Parameters.AddWithValue("@prenom", v.Prenom);
            cmd.Parameters.AddWithValue("@adresse", v.Adresse);
            cmd.Parameters.AddWithValue("@ville", v.Ville);
            cmd.Parameters.AddWithValue("@cp", v.Cp);
            cmd.Parameters.AddWithValue("@dateEmbauche", v.DateEmbauche);

            cmd.ExecuteNonQuery();
        }

        // Supprimer visiteur
        public static void SupprimerVisiteur(string id)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM visiteur WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }


        // Vérifier rapports
        public static bool VisiteurADesRapports(string id)
        {
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM rapport WHERE idVisiteur = @id";
            cmd.Parameters.AddWithValue("@id", id);
            object result = cmd.ExecuteScalar();
            int count = Convert.ToInt32(result);
            return count > 0;
        }


        public static List<Visiteur> ChargerTousVisiteurs()
        {
            List<Visiteur> visiteurs = new List<Visiteur>();
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM visiteur ORDER BY nom";
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Visiteur v = new Visiteur(
                    rdr["id"].ToString(),
                    rdr["nom"].ToString(),
                    rdr["prenom"].ToString(),
                    rdr["adresse"].ToString(),
                    rdr["ville"].ToString(),
                    rdr["cp"].ToString(),
                    rdr["login"].ToString(),
                    rdr["mdp"].ToString(),
                    rdr["dateEmbauche"].ToString()
                );
                visiteurs.Add(v);
            }
            rdr.Close();
            return visiteurs;
        }















        public static List<Rapport> GetTousRapports()
        {
            List<Rapport> rapports = new List<Rapport>();

            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM rapport";

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Rapport r = new Rapport(
                     int.Parse(rdr["id"].ToString()),
                    DateTime.Parse(rdr["date"].ToString()),
                    rdr["motif"].ToString(),
                    rdr["bilan"].ToString(),
                    rdr["idVisiteur"].ToString(),
                    int.Parse(rdr["idMedecin"].ToString())
                );
                rapports.Add(r);
            }
            rdr.Close();
            return rapports;
        }



        // Rapports par visiteur

        public static List<Rapport> GetRapportsParVisiteur(string idVisiteur)
        {
            List<Rapport> rapports = new List<Rapport>();
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM rapport WHERE idVisiteur = @idVisiteur";
            cmd.Parameters.AddWithValue("@idMedecin", idVisiteur);

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Rapport r = new Rapport(
                    int.Parse(rdr["id"].ToString()),
                    DateTime.Parse(rdr["date"].ToString()),
                    rdr["motif"].ToString(),
                    rdr["bilan"].ToString(),
                    rdr["idVisiteur"].ToString(),
                    int.Parse(rdr["idMedecin"].ToString())
                );
                rapports.Add(r);
            }
            rdr.Close();
            return rapports;
        }

        public static List<Rapport> GetRapportsParMedecin(string idMedecin)
        {
            List<Rapport> rapports = new List<Rapport>();
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM rapport WHERE idMedecin = @idMedecin";
            cmd.Parameters.AddWithValue("@idMedecin", idMedecin);

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Rapport r = new Rapport(
                    int.Parse(rdr["id"].ToString()),
                    DateTime.Parse(rdr["date"].ToString()),
                    rdr["motif"].ToString(),
                    rdr["bilan"].ToString(),
                    rdr["idVisiteur"].ToString(),
                    int.Parse(rdr["idMedecin"].ToString())
                );
                rapports.Add(r);
            }
            rdr.Close();
            return rapports;
        }

        public static Visiteur GetVisiteurById(string id)
        {
            Visiteur v = null;
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM visiteur WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                v = new Visiteur(
                    rdr["id"].ToString(),
                    rdr["nom"].ToString(),
                    rdr["prenom"].ToString(),
                    rdr["adresse"].ToString(),
                    rdr["dateEmbauche"].ToString(),
                    rdr["cp"].ToString(),
                    rdr["ville"].ToString(),
                    rdr["login"].ToString(),
                    rdr["mdp"].ToString()
                );
            }
            rdr.Close();
            return v;
        }


        public static Medecin GetMedecinById(string id)
        {
            Medecin m = null;
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT medecin.*, specialite.id as idSpecialite, specialite.specialite " +
                              "FROM medecin INNER JOIN specialite ON medecin.idSpecialite = specialite.id " +
                              "WHERE medecin.id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Specialite s = new Specialite(
                    rdr["idSpecialite"].ToString(),
                    rdr["specialite"].ToString()
                );

                m = new Medecin(
                    rdr["id"].ToString(),
                    rdr["nom"].ToString(),
                    rdr["prenom"].ToString(),
                    rdr["adresse"].ToString(),
                    rdr["tel"].ToString(),
                    rdr["departement"].ToString(),
                    s
                );
            }
            rdr.Close();
            return m;
        }









        public static List<Offrir> GetOffresParRapport(string idRapport)
         {
            List<Offrir> offres = new List<Offrir>();
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM offrir WHERE idRapport = @idRapport";
            cmd.Parameters.AddWithValue("@idRapport", idRapport);

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Medicament medoc = GetMedicamentById(rdr["idMedicament"].ToString());
                Offrir o = new Offrir(idRapport, rdr["idMedicament"].ToString(), rdr["quantite"].ToString());
                offres.Add(o);
            }
            rdr.Close();
            return offres;
         }

        public static Medicament GetMedicamentById(string id)
        {
            Medicament m = null;
            MySqlCommand cmd = GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM medicament WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                m = new Medicament(
                    rdr["id"].ToString(),
                    rdr["nomCommercial"].ToString(),
                    rdr["composition"].ToString(),
                    rdr["effets"].ToString(),
                    rdr["contreIndication"].ToString(),
                    GetFamilleDuMedicament(rdr["id"].ToString())

                );
            }
            rdr.Close();
            return m;
        }

    }

}