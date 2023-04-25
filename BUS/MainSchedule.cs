using DAO;
using DTO;
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


        private static MainSchedule instance;

        public static MainSchedule Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainSchedule();
                }
                return instance;
            }

        }
        private MainSchedule()
        {

        }

        // function schedule for group with 4 team
        public void RoundRobinSchedulerForGroup(List<string> teamList)
        {
            // Check if number of teams is valid for round robin format
            List<Tuple<string, string>> matches = new List<Tuple<string, string>>();
            if (teamList.Count != 4)
            {
                Console.WriteLine("Error: Number of teams in a group must be 4");
            }

            // Generate list of matches
            matches.Add(new Tuple<string, string>(teamList[0], teamList[1]));
            matches.Add(new Tuple<string, string>(teamList[2], teamList[3]));
            matches.Add(new Tuple<string, string>(teamList[0], teamList[2]));
            matches.Add(new Tuple<string, string>(teamList[1], teamList[3]));
            matches.Add(new Tuple<string, string>(teamList[0], teamList[3]));
            matches.Add(new Tuple<string, string>(teamList[1], teamList[2]));
            // Print schedule
            System.Diagnostics.Debug.WriteLine("Round Robin Schedule for group:");
            for (int i = 0; i < matches.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Round " + (i + 1) + ": " + matches[i].Item1 + " vs. " + matches[i].Item2);
            }
        }
        public void RoundStage(TourDTO tourDTO)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = RegistBUS.Instance.LoadRegistTour(tourDTO);
            List<String> ls = new List<string>();
            List<String> A = new List<string>();
            List<String> B = new List<string>();
            List<String> C = new List<string>();
            List<String> D = new List<string>();
            foreach (DataRow item in dt.Rows)
            {
                ls.Add(new String(item["Mã đội"].ToString()));
                
            }

            for(int i = 0; i< 16; i = i+ 4)
            {
                for(int j = i; j< i+4; j++)
                {
                    if (i == 0)
                    {
                        A.Add(ls[j]);
                    }
                    if(i == 4)
                    {
                        B.Add(ls[j]);
                    }
                    if (i == 8)
                    {
                        C.Add(ls[j]);
                    }
                    if (i == 12)
                    {
                        D.Add(ls[j]);

                    }
                }

            }
            RoundRobinSchedulerForGroup(A);
            RoundRobinSchedulerForGroup(B);
            RoundRobinSchedulerForGroup(C);
            RoundRobinSchedulerForGroup(D);  


        }
        

    }

}
