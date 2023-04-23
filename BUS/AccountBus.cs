using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountBUS();
                }
                return instance;
            }

        }
        private AccountBUS()
        {

        }
        public DataTable LoadAccount()
        {
            DataTable dt = new DataTable();
            dt = DAO.AccountDAO.Instance.GetListAccount();
            return dt;
        }
        public String AddAccount(UserDTO userDTO)
        { 
            return DAO.AccountDAO.Instance.AddAccount(userDTO).ToString();
        }
        public int SaveAccount(UserDTO userDTO)
        {
            return DAO.AccountDAO.Instance.SaveAccount(userDTO);
        }
        public int DeleteAccount(UserDTO userDTO)
        {
            return DAO.AccountDAO.Instance.DeleteAccount(userDTO);
        }
        public DataTable SearchAccount(string key)
        {
            return DAO.AccountDAO.Instance.SearchAccount(key);
        }
    }
}
