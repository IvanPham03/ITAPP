using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class MainSchedule
    {

        // function schedule for group with 4 team
        public static void RoundRobinSchedulerForGroup(List<string> teamList)
        {
            // Check if number of teams is valid for round robin format
            if (teamList.Count != 4)
            {
                Console.WriteLine("Error: Number of teams in a group must be 4");
                return;
            }

            // Generate list of matches
            List<Tuple<string, string>> matches = new List<Tuple<string, string>>();
            matches.Add(new Tuple<string, string>(teamList[0], teamList[1]));
            matches.Add(new Tuple<string, string>(teamList[2], teamList[3]));
            matches.Add(new Tuple<string, string>(teamList[0], teamList[2]));
            matches.Add(new Tuple<string, string>(teamList[1], teamList[3]));
            matches.Add(new Tuple<string, string>(teamList[0], teamList[3]));
            matches.Add(new Tuple<string, string>(teamList[1], teamList[2]));

            // Print schedule
            Console.WriteLine("Round Robin Schedule for group:");
            for (int i = 0; i < matches.Count; i++)
            {
                Console.WriteLine("Round " + (i + 1) + ": " + matches[i].Item1 + " vs. " + matches[i].Item2);
            }
        }

    }

}
