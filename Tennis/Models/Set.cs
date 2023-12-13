using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    internal class Set
    {
        private int scoreOp1;
        private int scoreOp2;

        public Set()
        {
            this.scoreOp1 = 0;
            this.scoreOp2=0;
        }

        int ScoreOp1
        {
            get { return scoreOp1; }
            set { scoreOp1 = value; }
        }
        int ScoreOp2
        {
            get { return scoreOp2; }
            set { scoreOp2 = value; }
        }

        public int Play()
        {
            int score1 = 0;
            int score2 = 0;
            while ((this.scoreOp1 < 6 && this.scoreOp2 < 6) || ((this.scoreOp1 - this.scoreOp2) < 2) || ((this.scoreOp2 - this.scoreOp1) < 2))
            {
                while (score1 < 4 && score2 < 4)
                {
                    Random random = new Random();
                    int point = random.Next(1, 3);
                    if (point == 1)
                    {
                        score1 += 1;
                    }
                    else if (point == 2)
                    {
                        score2 += 1;
                    }
                }
                if (score1 == 4)
                {
                    scoreOp1 += 1;
                }
                else
                {
                    scoreOp2 += 1;
                }
            }
            if(scoreOp1 >scoreOp2)
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
