using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Offrir
    {
        public string IdRapport { get; set; }
        public string IdMedicament { get; set; }
        public string Quantite { get; set; }

        public Offrir(string idRapport, string idMedicament, string quantite)
        {
            IdRapport = idRapport;
            IdMedicament = idMedicament;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return $"{IdMedicament} ({Quantite})";
        }
    }
}