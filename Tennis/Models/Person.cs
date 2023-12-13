using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    internal class Person
    {
        internal int id;
		internal string firstname;
		internal string lastname;
		internal string nationality;

        public Person() { }
        public Person(string firstname, string lastname, string nationality)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.nationality = nationality;
        }

        int ID { 
            get { return ID; } 
        }
        string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
		string LastName
		{
			get { return lastname; }
			set { lastname = value; }
		}
		string Nationality
		{
			get { return nationality; }
			set { nationality = value; }
		}
	}
}
