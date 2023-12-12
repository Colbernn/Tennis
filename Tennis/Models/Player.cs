using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    internal class Player : Person
    {
        internal int rank;
        internal string gender;

        public Player() { }
        public Player(string firstname, string lastname, string nationality, int rank,string gender) : base(firstname,lastname,nationality){
            this.rank = rank;
            this.gender = gender;
        }

        int Rank { 
            get { return rank; }
            set { rank = value; }
        }
        string Gender { 
            get { return gender; }
            set { gender = value; } 
        }
	}
}
