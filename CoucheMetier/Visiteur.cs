using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Visiteur : Personne
    {
        public string DateEmbauche { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }

        public Visiteur(string id, string nom, string prenom, string adresse, string dateEmbauche, string cp, string ville, string login, string mdp)
            : base(id, nom, prenom, adresse)
        {
            DateEmbauche = dateEmbauche;
            Cp = cp;
            Ville = ville;
            Login = login;
            Mdp = mdp;
        }

        public override string ToString()
        {
            return $"{Id} - {Nom} {Prenom} - {Ville}";
        }
    }
}