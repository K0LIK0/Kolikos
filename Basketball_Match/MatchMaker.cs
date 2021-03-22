using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Matches
{
    class MatchMaker
    {
        public enum Format
        {
            Plain,
            Table
        }
        public enum Output
        {
            Console,
            Excel
        }

        public List<Match> matches { get; }

        public MatchMaker(List<Team> teams)
        {
            this.matches = CreateMatches(teams);
        }

        private List<Match> CreateMatches(List<Team> teams)
        {
            List<Match> matchesList = new List<Match>();
            int i = 0;
            foreach (Team homeTeam in teams)
            {
                int j = 0;
                foreach (Team visitingTeam in teams)
                {
                    if (homeTeam != visitingTeam && j > i)
                        matchesList.Add(new Match(homeTeam, visitingTeam));
                    j++;
                }
                i++;
            }
            return matchesList;
        }

        public void PrintResults(Format format, Output output)
        {
            switch(format)
            {
                case MatchMaker.Format.Plain:
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.home.name + " x " + match.visiting.name + " - " + match.result.ResultHome.ToString() + " : " + match.result.ResultVisiting.ToString());
                    }
                    break;

                case MatchMaker.Format.Table:
                    Console.WriteLine("Tabulka");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.home.name + " x " + match.visiting.name + " - " + match.result.ResultHome.ToString() + " : " + match.result.ResultVisiting.ToString());
                    }
                    break;

            }


        }
    }
        
        
}
