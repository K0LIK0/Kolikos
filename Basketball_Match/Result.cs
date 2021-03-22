using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Matches
{
    class Result
    {
        public int pointsQ1H { get; set; }
        public int pointsQ2H { get; set; }
        public int pointsQ3H { get; set; }
        public int pointsQ4H { get; set; }

        public int pointsQ1V { get; set; }
        public int pointsQ2V { get; set; }
        public int pointsQ3V { get; set; }
        public int pointsQ4V { get; set; }

        public int ResultHome { get; set; } = 0;
        public int ResultVisiting { get; set; } = 0;
        public Result()
        {
            /*this.pointsQ1H = pointsQ1;
            this.pointsQ2H = pointsQ2;
            this.pointsQ3H = pointsQ3;
            this.pointsQ4H = pointsQ4;
            this.pointsQ1V = pointsQ1;
            this.pointsQ2V = pointsQ2;
            this.pointsQ3V = pointsQ3;
            this.pointsQ4V = pointsQ4;*/
        }
    }
}
