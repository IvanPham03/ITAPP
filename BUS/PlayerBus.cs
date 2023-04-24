using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PlayerBUS
    {
        private static PlayerBUS instance;

        public static PlayerBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerBUS();
                }
                return instance;
            }

        }
        private PlayerBUS()
        {

        }
        public DataTable LoadPlayer(PlayerDTO playerDTO)
        {
            DataTable dt = new DataTable();
            dt = DAO.PlayerDAO.Instance.GetListPlayer(playerDTO);
            return dt;
        }
        public int CalculateAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            // For leap years we need this
            if (birthDate > now.AddYears(-age))
                age--;
            // Don't use:
            // if (birthDate.AddYears(age) > now) 
            //     age--;

            return age;
        }
        public String AddPlayer(PlayerDTO playerDTO)
        {
            if (String.IsNullOrEmpty(playerDTO.PLAYERNAME.ToString()))
            {

                return "Vui lòng nhập tên thành viên!";

            }
            if (CalculateAge(DateTime.Parse(playerDTO.DOB), DateTime.Now) <18)
            {

                return "Vui lòng chọn lại ngày sinh hợp lý!";

            }
            DataTable dt = new DataTable();
            dt = DAO.PlayerDAO.Instance.GetListAllPlayer();
            string SearchByColumn = "[Số điện thoại]='" + playerDTO.PHONE + "'";
            DataRow[] hasRows = dt.Select(SearchByColumn);
            if (hasRows.Length == 1)
            {
                //your logic goes here
                return "Số điện thoại đã tồn tại!";
            }
          
            return DAO.PlayerDAO.Instance.AddPlayer(playerDTO).ToString();
        }
        public int SavePlayer(PlayerDTO PlayerDTO)
        {
            return DAO.PlayerDAO.Instance.SavePlayer(PlayerDTO);
        }
        public int DeletePlayer(PlayerDTO PlayerDTO)
        {
            return DAO.PlayerDAO.Instance.DeletePlayer(PlayerDTO);
        }
        public DataTable SearchPlayer(string key)
        {
            if (String.IsNullOrEmpty(key))
            {
                DataTable errorTable = new DataTable();
                errorTable.Columns.Add("Vui lòng nhập thông tin tìm kiếm!");
                return errorTable;

            }
            return DAO.PlayerDAO.Instance.SearchPlayer(key);
        }
    }
}
