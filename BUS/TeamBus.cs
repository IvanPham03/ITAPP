using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TeamBUS
    {
        private static TeamBUS instance;

        public static TeamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TeamBUS();
                }
                return instance;
            }

        }
        private TeamBUS()
        {

        }
        public DataTable LoadTeam()
        {
            DataTable dt = new DataTable();
            dt = DAO.TeamDAO.Instance.GetListTeam();
            return dt;
        }
        public String AddTour(TeamDTO teamDTO)
        {
            if (String.IsNullOrEmpty(teamDTO.TEAMNAME.ToString()))
            {

                return "Vui lòng nhập tên đội!";

            }
            if (String.IsNullOrEmpty(teamDTO.NUMBEROFMEMBER.ToString()))
            {

                return "Vui lòng chọn số lượng thành viên!";

            }
            return DAO.TeamDAO.Instance.AddTeam(teamDTO).ToString();
        }
        public int SaveTeam(TeamDTO teamDTO)
        {
            return DAO.TeamDAO.Instance.SaveTeam(teamDTO);
        }
        public int DeleteTeam(TeamDTO teamDTO)
        {
            return DAO.TeamDAO.Instance.DeleteTeam(teamDTO);
        }
        public DataTable SearchTeam(string key)
        {
            if (String.IsNullOrEmpty(key))
            {
                DataTable errorTable = new DataTable();
                errorTable.Columns.Add("Vui lòng nhập thông tin tìm kiếm!");
                return errorTable;

            }
            return DAO.TeamDAO.Instance.SearchTeam(key);
        }

    }
}
