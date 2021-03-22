using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Matches
{
    class Team
    {
        public int pointRate { get; }
        public int foulRate { get; }
        public int spread { get; }
        public string name { get; }

        public Team(string Name, int PointRate, int FoulRate, int Spread)
        {
            name = Name;
            pointRate = PointRate;
            foulRate = FoulRate;
            spread = Spread;            
        }
    }
}
