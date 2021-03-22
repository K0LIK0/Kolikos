using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Matches
{
    class Match
    {
        private readonly Random _random = new Random();
        

        public Team home;
        public Team visiting;
        public Result result;
                            
        public Match (Team Home, Team Visiting)
        {
            this.home = Home;
            this.visiting = Visiting;
            this.result = ResultofMatch();
        }
        private Result ResultofMatch()
        {
            Result matchResult = new Result();

            for (int i = 0; i < 4; i++)
            {
                int punishmantH = 0;
                int punishmantV = 0;
                //Home                  

                if (RandomNumber(0, 100) < this.home.foulRate) //Foul
                    punishmantH = 4;

                int SpreadH = RandomNumber(-this.home.spread - punishmantH, this.home.spread) * (this.home.pointRate / 100); //Spread
                int PointsForthH = this.home.pointRate / 4 + SpreadH; //Result after one forth

                if (i == 0)
                    matchResult.pointsQ1H = PointsForthH;
                else if (i == 1)
                    matchResult.pointsQ2H = PointsForthH;
                else if (i == 2)
                    matchResult.pointsQ3H = PointsForthH;
                else if (i == 3)
                    matchResult.pointsQ4H = PointsForthH;

                matchResult.ResultHome = matchResult.ResultHome + PointsForthH;               

                    // Visiting
                 
                if (RandomNumber(0, 100) < this.visiting.foulRate) //Foul
                    punishmantV = 4;

                int SpreadV = RandomNumber(-this.visiting.spread - punishmantV, this.visiting.spread) * (this.visiting.pointRate / 100); //Spread
                int PointsForthV = this.visiting.pointRate / 4 + SpreadV; //Result after one forth

                if (i == 0)
                    matchResult.pointsQ1V = PointsForthV;
                else if (i == 1)
                    matchResult.pointsQ2V = PointsForthV;
                else if (i == 2)
                    matchResult.pointsQ3V = PointsForthV;
                else if (i == 3)
                    matchResult.pointsQ4V = PointsForthV;

                matchResult.ResultVisiting = matchResult.ResultVisiting + PointsForthV;

                

            }
            return matchResult;
        }

        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }


    }
}
