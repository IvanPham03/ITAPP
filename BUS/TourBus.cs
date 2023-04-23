using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Data;
using Microsoft.IdentityModel.Tokens;

namespace BUS
{
    
    public class TourBUS
    {
        private static TourBUS instance;

        public static TourBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TourBUS();
                }
                return instance;
            }

        }
        private TourBUS()
        {

        }
        public DataTable LoadTour()
        {
            DataTable dt = new DataTable();
            dt = DAO.TourDAO.Instance.GetListTour();
            return dt;
        }
        public String AddTour(TourDTO tourDTO) {
            if (String.IsNullOrEmpty(tourDTO.TOURNAME))
            {

                return "Vui lòng nhập tên giải!";

            }
            return DAO.TourDAO.Instance.AddTour(tourDTO).ToString();
        }
        public int SaveTour(TourDTO tourDTO)
        {
            return DAO.TourDAO.Instance.SaveTour(tourDTO);
        }
        public int DeleteTour(TourDTO tourDTO)
        {
            return DAO.TourDAO.Instance.DeleteTour(tourDTO);
        }
        public DataTable SearchTour(string key)
        {
            if (String.IsNullOrEmpty(key))
            {
                DataTable errorTable = new DataTable();
                errorTable.Columns.Add("Vui lòng nhập thông tin tìm kiếm!");
                return errorTable;

            }
            return DAO.TourDAO.Instance.SearchTour(key);
        }
    }
}
