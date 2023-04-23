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
        public DataTable GetListAccount()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadUser");
            return table;

        }
        public int AddAccount(UserDTO userDTO)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("EXEC dbo.InsertUser  @PHONENUM, @USERNAME, @ROLE, @Password", new object[] { userDTO.PHONENUMBER, userDTO.USERNAME, userDTO.ROLE, userDTO.PASSWORD });
        }
        public int SaveAccount(UserDTO userDTO)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("EXEC dbo.UpdateUser @PHONENUM, @USERNAME, @ROLE, @Password", new object[] { userDTO.PHONENUMBER, userDTO.USERNAME, userDTO.ROLE, userDTO.PASSWORD });
        }
        public int DeleteAccount(UserDTO userDTO)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("EXEC dbo.DeleteUser @PHONENUM", new object[] { userDTO.PHONENUMBER});
        }
        public DataTable SearchAccount(string key)
        {
            return DAO.DataProvider.Instance.ExecuteQuery("EXEC dbo.DeleteUser @key", new object[] { key});
        }
    }
}
