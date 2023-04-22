using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBus
    {
        private static AccountBus instance;

        public static AccountBus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountBus();
                }
                return instance;
            }

        }
        private AccountBus()
        {

        }
        /*public DataTable LoadAccount()
        {
            DataTable dt = new DataTable();
            dt = DAO.AccountDAO.Instance.GetListAccount();
            return dt;
        }
        public String AddAccount(UserDTO userDTO)
        {
            if (String.IsNullOrEmpty(userDTO.TOURNAME))
            {

                return "Vui lòng nhập tên giải!";

            }
            return DAO.AccountDAO.Instance.AddTour(userDTO).ToString();
        }
        public int SaveAccount(UserDTO userDTO)
        {
            return DAO.AccountDAO.Instance.SaveTour(userDTO);
        }
        public int DeleteAccount(UserDTO userDTO)
        {
            return DAO.AccountDAO.Instance.DeleteTour(userDTO);
        }
        public DataTable SearchAccount(UserDTO userDTO)
        {
            if (String.IsNullOrEmpty(userDTO.TOURNAME) && String.IsNullOrEmpty(userDTO.TOURID))
            {
                DataTable errorTable = new DataTable();
                errorTable.Columns.Add("Vui lòng truyền ít nhất 1 tham số tìm kiếm như Mã giải hoặc Tên giải!");
                return errorTable;

            }
            return DAO.AccountDAO.Instance.SearchAccount(userDTO);
        }*/
    }
}
