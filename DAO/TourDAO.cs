using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class TourDAO
    {
        private static TourDAO instance;

        public static TourDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TourDAO();
                }
                return instance;
            }

        }
        public TourDAO()
        {
        }
        public DataTable GetListTour()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadTour");
            return table;

        }
        public int AddTour(TourDTO tourDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.InsertTour @TourName , @DateStart , @DateEnd ;", new object[] { tourDTO.TOURNAME, tourDTO.DATESTART, tourDTO.DATEEND} );
        }
        public int SaveTour(TourDTO tourDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.UpdateTour @TourName , @DateStart , @DateEnd , @TourID ;", new object[] { tourDTO.TOURNAME, tourDTO.DATESTART, tourDTO.DATEEND, tourDTO.TOURID });
        }
        public int DeleteTour(TourDTO tourDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.DeleteTour @TourID ", new object[] {tourDTO.TOURID });
        }
        public DataTable SearchTour(TourDTO tourDTO)
        {
            
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.SeachTour @TourName , @TourID ", new object[] { tourDTO.TOURNAME, tourDTO.TOURID });
        }
    }
}
