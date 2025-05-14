using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Specialite
    {
        private string id;
        private string libSpecialite;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string LibSpecialite
        {
            get { return libSpecialite; }
            set { libSpecialite = value; }
        }

        public Specialite(string id, string libSpecialite)
        {
            this.id = id;
            this.libSpecialite = libSpecialite;
        }

        public override string ToString()
        {
            return libSpecialite;
        }
    }
}
