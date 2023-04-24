using BUS;
using DTO;
using Microsoft.VisualBasic;
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
    public partial class fTeam : Form
    {
        public fTeam()
        {
            InitializeComponent();
            LoadListTeam();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            return;

        }

        private void fTeam_Load(object sender, EventArgs e)
        {


        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            fPlayer Player = new fPlayer(txtTeamID.Text, cbNumber.Text);
            Player.ShowDialog();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            fPopupRegist PopupRegist = new fPopupRegist(txtTeamID.Text);
            PopupRegist.ShowDialog();
        }
        public void ResetDataGridview()
        {
            dgvTeam.DataSource = null;
        }
        //==
        public void LoadListTeam()
        {
            dgvTeam.DataSource = TeamBUS.Instance.LoadTeam();
            dgvTeam.DefaultCellStyle.Font = new Font("", 12);
        }

        private void dgvTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvTeam.Rows[e.RowIndex];
                txtTeamID.Text = selectRow.Cells[0].Value.ToString();
                txtNameTeam.Text = selectRow.Cells[1].Value.ToString();
                cbNumber.Text = selectRow.Cells[2].Value.ToString();
            }
            btnCancel.Enabled = true;
            txtTeamID.Enabled = false;
            btnDelete.Enabled = true;
            btnSearch.Enabled = false;
            btnEdit.Enabled = true;
            btnCopy.Enabled = true;
            btnAdd.Enabled = false;
            btnBack.Enabled = true;
            btnSave.Enabled = true;
            btnPlayer.Enabled = true;
            btnRegist.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeamDTO teamDTO = new TeamDTO();
            teamDTO.TEAMNAME = txtNameTeam.Text;
            teamDTO.NUMBEROFMEMBER = cbNumber.Text;
            string rs = TeamBUS.Instance.AddTour(teamDTO);
            if (rs != "1")
            {
                MessageBox.Show(rs.ToString(), "Thêm dữ liệu");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thêm dữ liệu");
            }
            LoadListTeam();

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            TeamDTO teamDTO = new TeamDTO();
            string key = txtInputSearch.Text;
            ResetDataGridview();
            dgvTeam.DataSource = TeamBUS.Instance.SearchTeam(key);
            dgvTeam.DefaultCellStyle.Font = new Font("", 12);
        }

        private void ResetDataGridview(object sender, EventArgs e)
        {
            ResetDataGridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TeamDTO teamDTO = new TeamDTO();
            teamDTO.TEAMID = txtTeamID.Text;
            teamDTO.TEAMNAME = txtNameTeam.Text;
            teamDTO.NUMBEROFMEMBER = cbNumber.Text;
            TeamBUS.Instance.SaveTeam(teamDTO);
            LoadListTeam();
            btnBack.Enabled = false;
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng dữ liệu này", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                TeamDTO teamDTO = new TeamDTO();
                teamDTO.TEAMID = txtTeamID.Text;
                int rs = TeamBUS.Instance.DeleteTeam(teamDTO);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetForm();
                LoadListTeam();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvTeam.ClearSelection();
            ResetForm();
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnCopy.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            txtTeamID.Enabled = true;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            btnPlayer.Enabled = false;
            btnRegist.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtTeamID.Focus();
        }

        private void changeInput(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetForm();
            btnBack.Enabled = false;
            btnSave.Enabled = false;
        }
        public void ResetForm()
        {
            txtTeamID.Text = null;
            txtNameTeam.Text = null;
            cbNumber.SelectedIndex = -1;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListTeam();
            ResetForm();
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnPlayer.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
