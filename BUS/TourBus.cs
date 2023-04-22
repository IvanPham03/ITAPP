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
    
    public class TourBus
    {
        private static TourBus instance;

        public static TourBus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TourBus();
                }
                return instance;
            }

        }
        private TourBus()
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
        public DataTable SearchTour(TourDTO tourDTO)
        {
            if (String.IsNullOrEmpty(tourDTO.TOURNAME) && String.IsNullOrEmpty(tourDTO.TOURID))
            {
                DataTable errorTable = new DataTable();
                errorTable.Columns.Add("Vui lòng truyền ít nhất 1 tham số tìm kiếm như Mã giải hoặc Tên giải!");
                return errorTable;

            }
            return DAO.TourDAO.Instance.SearchTour(tourDTO);
        }
    }
}
