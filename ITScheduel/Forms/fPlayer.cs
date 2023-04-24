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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fPlayer : Form
    {
        private string teamID;
        private string number;
        public fPlayer(String teamID, string number)
        {
            InitializeComponent();
            this.teamID = teamID;
            this.number = number;
            LoadListPlayer();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void ResetDataGridview()
        {
            dgvPlayer.DataSource = null;
        }
        //==
        public void LoadListPlayer()
        {
            txtIdTeam.Text = teamID;
            PlayerDTO playerDTO = new PlayerDTO();
            playerDTO.TEAMID = teamID;
            var rs = PlayerBUS.Instance.LoadPlayer(playerDTO);
            dgvPlayer.DataSource = rs;
            dgvPlayer.ColumnHeadersDefaultCellStyle.Font = new Font("", 14, FontStyle.Bold);
            if (rs.Rows.Count == Int32.Parse(number))
            {
                btnAdd.Enabled = false;
            }

        }

        private void dgvPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvPlayer.Rows[e.RowIndex];
                txtIdTeam.Text = selectRow.Cells[0].Value.ToString();
                txtPlayerID.Text = selectRow.Cells[1].Value.ToString();
                txtName.Text = selectRow.Cells[2].Value.ToString();
                dtpDoB.Value = DateTime.Parse(selectRow.Cells[3].Value.ToString());
                if (selectRow.Cells[4].Value.ToString() == "1")
                {
                    chbCaptain.Checked = true;
                }
                else
                {
                    chbCaptain.Checked = false;
                }

            }
            btnCancel.Enabled = true;
            txtIdTeam.Enabled = false;
            btnDelete.Enabled = true;
            btnSearch.Enabled = false;
            btnEdit.Enabled = true;
            btnCopy.Enabled = true;
            btnAdd.Enabled = false;
            btnBack.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có hiệu lực!", "Thông báo");
            }
            else
            {
                PlayerDTO playerDTO = new PlayerDTO();
                playerDTO.PLAYERNAME = txtName.Text;
                playerDTO.CAPTAIN = chbCaptain.Checked;
                playerDTO.DOB = dtpDoB.Value.ToString();
                playerDTO.TEAMID = txtIdTeam.Text;
                playerDTO.PHONE = txtPhone.Text;
                string rs = PlayerBUS.Instance.AddPlayer(playerDTO);
                if (rs != "1")
                {
                    MessageBox.Show(rs.ToString(), "Thêm dữ liệu");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thêm dữ liệu");
                }
                LoadListPlayer();
                ResetForm();
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtInputSearch.Text;
            ResetDataGridview();
            dgvPlayer.DataSource = TeamBUS.Instance.SearchTeam(key);
            dgvPlayer.DefaultCellStyle.Font = new Font("", 12);
        }

        private void ResetDataGridview(object sender, EventArgs e)
        {
            ResetDataGridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có hiệu lực!", "Thông báo");
            }
            else
            {
                PlayerDTO playerDTO = new PlayerDTO();
                playerDTO.PLAYERNAME = txtName.Text;
                playerDTO.CAPTAIN = chbCaptain.Checked;
                playerDTO.DOB = dtpDoB.Value.ToString();
                playerDTO.PLAYERID = txtIdTeam.Text;
                playerDTO.PHONE = txtPhone.Text;
                PlayerBUS.Instance.SavePlayer(playerDTO);
                LoadListPlayer();
                btnBack.Enabled = false;
            }
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng dữ liệu này", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                PlayerDTO playerDTO = new PlayerDTO();
                playerDTO.PLAYERID = txtIdTeam.Text;
                int rs = PlayerBUS.Instance.DeletePlayer(playerDTO);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetForm();
                LoadListPlayer();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool IsPhoneNumber(string number)
        {
            string motif = @"[0-9]$";
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvPlayer.ClearSelection();
            ResetForm();
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnCopy.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            txtPlayerID.Enabled = true;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            txtPlayerID.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtPlayerID.Focus();
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
            txtName.Text = null;
            dtpDoB.Text = null;
            chbCaptain.Checked = false;
            txtInputSearch.Text = null;
            txtPhone.Text = null;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListPlayer();
            ResetForm();
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void fPlayer_Load(object sender, EventArgs e)
        {

        }

    }
}
