using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RegistBUS
    {
        private static RegistBUS instance;

        public static RegistBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegistBUS();
                }
                return instance;
            }

        }
        private RegistBUS()
        {

        }
        public DataTable LoadRegist()
        {
            DataTable dt = new DataTable();
            dt = DAO.RegistDAO.Instance.GetListRegist();
            return dt;
        }
        public DataTable LoadRegistTour(TourDTO tourDTO)
        {
            DataTable dt = new DataTable();
            dt = DAO.RegistDAO.Instance.GetListRegistTour(tourDTO);
            return dt;
        }
        
        public String AddRegist(RegistDTO registDTO)
        {
            if (String.IsNullOrEmpty(registDTO.TEAMID) || (String.IsNullOrEmpty(registDTO.TOURID)))
            {

                return "Lỗi tham số truyền vào, vui lòng kiểm tra lại Mã đội và mã giải!";

            }
            DataTable dt = new DataTable();
            dt = DAO.RegistDAO.Instance.GetListRegist();
            string SearchByColumn = "[Mã đội]='" + registDTO.TEAMID + "'";
            DataRow[] hasRows = dt.Select(SearchByColumn);
            if (hasRows.Length > 0)
            {
                foreach(DataRow row in hasRows)
                {
                    string idTour = new string(row["Mã giải"].ToString());
                    if (idTour.Equals(registDTO.TOURID.ToString()))
                    {
                        return "Bạn đã đăng ký vào giải đấu này!";
                    }
                }

            }

            return DAO.RegistDAO.Instance.AddRegist(registDTO).ToString();
        }
    }
}
