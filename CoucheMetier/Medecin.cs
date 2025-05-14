using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Medecin : Personne
    {
        private string tel;
        private string departement;
        private Specialite laSpecialite;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Departement
        {
            get { return departement; }
            set { departement = value; }
        }

        public Specialite LaSpecialite
        {
            get { return laSpecialite; }
            set { laSpecialite = value; }
        }

        public Medecin(string id, string nom, string prenom, string adresse, string tel, string departement, Specialite laSpecialite)
            : base(id, nom, prenom, adresse)
        {
            this.tel = tel;
            this.departement = departement;
            this.laSpecialite = laSpecialite;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {departement} - {tel} - {laSpecialite.LibSpecialite}";
        }
    }
}