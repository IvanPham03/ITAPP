using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }

        }
        public AccountDAO()
        {
        }
        /*public DataTable GetListAccount()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadTour");
            return table;

        }
        public int AddAccount(UserDTO userDTO)
        {
            
        }
        public int SaveAccount(UserDTO userDTO)
        {
            
        }
        public int DeleteAccount(UserDTO userDTO)
        {
            return 
        }
        public DataTable SearchAccount(UserDTO userDTO)
        {

            return 
    }*/
    }
}
