using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    internal class Court
    {
        internal int id_court;
        internal int nbSpectators;
        internal bool covered;

        public Court() { }
        public Court(int nbSpectators, bool covered) {
            this.nbSpectators = nbSpectators;
            this.covered = covered;
        }
        int ID
        {
            get { return id_court; }
        }
        int NbSpectator {  
            get { return nbSpectators; } 
            set { nbSpectators = value; }
        }
        bool Covered {
            get { return covered; }
            set { covered = value;}
            }
	}
}
