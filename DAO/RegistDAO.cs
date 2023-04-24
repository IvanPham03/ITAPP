using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class RegistDAO
    {
        private static RegistDAO instance;

        public static RegistDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegistDAO();
                }
                return instance;
            }

        }
        public RegistDAO()
        {
        }
        public DataTable GetListRegist()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadRegist");
            return table;
                
        }
        public DataTable GetListRegistTour(TourDTO tourDTO)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadRegistTour @TourID ", new object[] { tourDTO.TOURID});
            return table;

        }
        

        public int AddRegist(RegistDTO RegistDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.InsertRegist @TEAMID , @TOURID  ;", new object[] { RegistDTO.TEAMID, RegistDTO.TOURID} );
        }
      /*  public int SaveRegist(RegistDTO RegistDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.UpdateRegist @RegistName , @DateStart , @DateEnd , @RegistID ;", new object[] { RegistDTO.RegistNAME, RegistDTO.DATESTART, RegistDTO.DATEEND, RegistDTO.RegistID });
        }
        public int DeleteRegist(RegistDTO RegistDTO)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC dbo.DeleteRegist @RegistID ", new object[] {RegistDTO.RegistID });
        }
        public DataTable SearchRegist(string key)
        {
            
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.SeachRegist @RegistName , @RegistID ", new object[] { key });
        }*/
    }
}
