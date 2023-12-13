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
		private int[] set;

		public Match() { }
		public Match(DateTime date, int duration, int round) { 
			this.date = date; 
			this.duration = duration;
			this.set[0] = 0;
            this.set[1] = 0;
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

		public void Play()
		{
			int gagnant;
			while (this.set[0]<5 && this.set[1] < 5)
			{
				Set set = new Set();
				gagnant=set.Play();
				if(gagnant==1)
				{
					this.set[0]++;
				}
				else if(gagnant==2)
				{
                    this.set[1]++;
                }
			}
		}

		public int GetWinner()
		{
			if (this.set[0] == 5)
			{
				return 1;
			}
			else 
			{
				return 2;
			}
		}

	}
}
