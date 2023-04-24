using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TeamDAO
    {
        private static TeamDAO instance;

        public static TeamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TeamDAO();
                }
                return instance;
            }

        }
        public TeamDAO()
        {
        }
        public DataTable GetListTeam()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadTeam");
            return table;

        }
       
        public int AddTeam(TeamDTO teamDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.InsertTeam @TEAMNAME , @NUMBEROFMEMBER ;", new object[] { teamDTO.TEAMNAME, teamDTO.NUMBEROFMEMBER });
        }
        public int SaveTeam(TeamDTO teamDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.UpdateTeam @TEAMNAME , @NUMBEROFMEMBER , @TEAMID ;", new object[] { teamDTO.TEAMNAME, teamDTO.NUMBEROFMEMBER , teamDTO.TEAMID});
        }
        public int DeleteTeam(TeamDTO teamDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.DeleteTeam @TeamID ", new object[] { teamDTO.TEAMID});
        }
        public DataTable SearchTeam(string key)
        {

            return DataProvider.Instance.ExecuteQuery("EXEC dbo.SeachTeam @key ", new object[] { key });
        }

    }

}
