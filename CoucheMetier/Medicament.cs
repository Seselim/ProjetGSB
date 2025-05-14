using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Medicament
    {
        // Champs (attributs privés)
        private string id;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndications;
        private Famille laFamille;

        // Propriétés publiques
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomCommercial
        {
            get { return nomCommercial; }
            set { nomCommercial = value; }
        }

        public string Composition
        {
            get { return composition; }
            set { composition = value; }
        }

        public string Effets
        {
            get { return effets; }
            set { effets = value; }
        }

        public string ContreIndications
        {
            get { return contreIndications; }
            set { contreIndications = value; }
        }

        public Famille Famille
        {
            get { return laFamille; }
            set { laFamille = value; }
        }

        // Constructeur
        public Medicament(string id, string nomCommercial, string composition, string effets, string contreIndications, Famille laFamille)
        {
            this.id = id;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.laFamille = laFamille;
        }

        // Méthode ToString
        public override string ToString()
        {
            if (Famille != null)
            {
                return $"{Id} - {NomCommercial} ({Famille?.Libelle})";
            }
            else
            {
                return $"{Id} - {NomCommercial}";
            }
        }
    }
}