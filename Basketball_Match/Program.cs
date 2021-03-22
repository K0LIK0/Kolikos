using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Matches
{

    class Program
    {        
    
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            teams.Add(new Team("Black_Guys", 120, 20, 7));
            teams.Add(new Team("White Guys", 105, 5, 15));
            teams.Add(new Team("Bobos", 110, 12, 13));
            teams.Add(new Team("comunists", 98, 12, 10));
            teams.Add(new Team("baby boys", 115, 16, 16));
            teams.Add(new Team("white whales", 107, 4, 8));

            MatchMaker mm = new MatchMaker(teams);
            mm.PrintResults(MatchMaker.Format.Plain, MatchMaker.Output.Console);
            
            Console.ReadKey();
        }
    }
}
