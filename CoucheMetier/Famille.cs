using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Famille
    {
            // Champs (attributs privés)
            private string id;
            private string libelle;

            // Propriétés publiques
            public string Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Libelle
            {
                get { return libelle; }
                set { libelle = value; }
            }

            // Constructeur
            public Famille(string id, string libelle)
            {
                this.id = id;
                this.libelle = libelle;
            }

            // Méthode ToString
            public override string ToString()
            {
                return $"{id} - {libelle}";
            }
        }
    }
