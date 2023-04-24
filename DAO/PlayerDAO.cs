using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PlayerDAO
    {
        private static PlayerDAO instance;

        public static PlayerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerDAO();
                }
                return instance;
            }

        }
        private PlayerDAO()
        {

        }
        public DataTable GetListPlayer(PlayerDTO playerDTO)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadPlayer @PlayerID ", new object[]{playerDTO.TEAMID});
            return table;

        }
        public DataTable GetListAllPlayer()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadAllPlayer");
            return table;

        }

        public int AddPlayer(PlayerDTO playerDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.InsertPlayer @PLAYERNAME , @DOB , @CAPTAIN , @TEAMID , @PHONE ;", new object[] { playerDTO.PLAYERNAME, playerDTO.DOB, playerDTO.TEAMID, playerDTO.CAPTAIN, playerDTO.PHONE});
        }
        public int SavePlayer(PlayerDTO playerDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.UpdatePlayer  @PLAYERNAME , @DOB , @CAPTAIN , @PHONE ;", new object[] { playerDTO.PLAYERNAME, playerDTO.DOB, playerDTO.CAPTAIN, playerDTO.PHONE});
        }
        public int DeletePlayer(PlayerDTO playerDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.DeletePlayer @PlayerID ", new object[] { playerDTO.PLAYERID });
        }
        public DataTable SearchPlayer(string key)
        {

            return DataProvider.Instance.ExecuteQuery("EXEC dbo.SeachPlayer @key ", new object[] { key });
        }
    }
}
