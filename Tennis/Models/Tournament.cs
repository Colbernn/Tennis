using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    internal class Tournament
    {
        private int id_tournament;
        private string name;

       int ID { get { return id_tournament; } }
       string Name
        {
            get { return name; }
            set { name = value; }
        }
	}
}
