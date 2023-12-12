using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    internal class Match
    {
		private int id_match;
		private DateTime date;
		private int duration;
		private int round;

		public Match() { }
		public Match(DateTime date, int duration, int round) { 
			this.date = date; 
			this.duration = duration;
		}

		int ID
		{
			get { return id_match; }
		}
		DateTime Date { 
			get {  return date; }
			set { date = value; }
		}
		int Duration
		{
			get { return duration; }
			set { duration = value;  }
		}
		int Round {
			get { return round; }
			set { round = value; }
		}
	}
}
