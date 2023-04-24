using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fPopupRegist : Form
    {
        private string idTeam;
        public fPopupRegist(string idTeam)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            LoadListTour();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadListTour()
        {
            DataTable dt = new DataTable();
            dt = TourBUS.Instance.LoadTour();
            /*List<string> lsTourName = new List<string>();*/
            string id, name;
            foreach (DataRow item in dt.Rows)
            {
                cbIdTour.Items.Add(item["Mã giải"].ToString());
                cbNameTour.Items.Add(item["Tên giải"].ToString());
            }

        }
        public void AutoChange_ID(object sender, EventArgs e)
        {
            string SearchByColumn = "[Mã giải]='" + cbIdTour.Text + "'";
            DataTable dt = new DataTable();
            dt = TourBUS.Instance.LoadTour();
            DataRow[] hasRows = dt.Select(SearchByColumn);
            if (hasRows.Length == 0)
            {
                //your logic goes here
                MessageBox.Show("Giải đấu không tồn tại");
                btnRegist.Enabled = false;
            }
            else
            {
                DataRow row = hasRows[0];
                dtpStart.Value = DateTime.Parse(new string(row["Ngày bắt đầu"].ToString()));
                dtpStart.Value = DateTime.Parse(new string(row["Ngày kết thúc"].ToString()));
                cbNameTour.Text = row["Tên giải"].ToString();
                btnRegist.Enabled = true;
                //your logic goes here
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            RegistDTO registDTO = new RegistDTO();
            registDTO.TOURID = cbIdTour.Text;
            registDTO.TEAMID = idTeam;
            String rs = RegistBUS.Instance.AddRegist(registDTO);
            if (rs != "1")
            {
                MessageBox.Show(rs.ToString(), "Thêm dữ liệu!");
            }
            else
            {
                MessageBox.Show("Bạn đã đăng ký thành công!", "Thêm dữ liệu");
                this.Close();
            }
        }

        private void fPopupRegist_Load(object sender, EventArgs e)
        {

        }
    }
}
