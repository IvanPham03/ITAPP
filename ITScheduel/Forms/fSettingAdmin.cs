using BUS;
using DAO;
using DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fSettingAdmin : Form
    {

        public fMainAdmin main;
        public fSettingAdmin(fMainAdmin main)
        {
            InitializeComponent();
            this.main = main;
            LoadListAccount();
        }

        private void fSettingAdmin_Load(object sender, EventArgs e)
        {

        }
        public void LoadListAccount()
        {
            dgvAccount.DataSource = AccountBUS.Instance.LoadAccount();
            dgvAccount.DefaultCellStyle.Font = new Font("", 12);
        }
        public void ResetDataGridview()
        {
            dgvAccount.DataSource = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvAccount.Rows[e.RowIndex];
                txtNameUser.Text = selectRow.Cells[1].Value.ToString();
                txtPhoneNumber.Text = selectRow.Cells[0].Value.ToString();
                txtRole.Text = selectRow.Cells[2].Value.ToString();
                txtPassword.Text = selectRow.Cells[5].Value.ToString();
            }
            btnCancel.Enabled = true;
            txtPhoneNumber.Enabled = false;
            btnDelete.Enabled = true;
            btnSearch.Enabled = false;
            btnEdit.Enabled = true;
            btnGuide.Enabled = true;
            btnAdd.Enabled = false;
        }

        public bool IsPhoneNumber(string number)
        {
            string motif = @"[0-9]$";
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtNameUser.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên người dùng!");
                txtNameUser.Focus();
            }
            else if (String.IsNullOrEmpty(txtPhoneNumber.Text) || txtPhoneNumber.Text.Length != 10 || IsPhoneNumber(txtPhoneNumber.Text) != true)
            {
                MessageBox.Show("Vui lòng kiểm tra lại số điện thoại!");
                txtPhoneNumber.Focus();

            }
            else if (String.IsNullOrEmpty(txtRole.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại nhập vai trò!");
                txtRole.Focus();

            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại password!");
                txtPassword.Focus();

            }
            else
            {
                UserDTO userDTO = new UserDTO();
                userDTO.PHONENUMBER = txtPhoneNumber.Text;
                userDTO.USERNAME = txtNameUser.Text;
                userDTO.ROLE = txtRole.Text;
                userDTO.PASSWORD = txtPassword.Text;
                String rs = AccountBUS.Instance.AddAccount(userDTO);
                if (rs != "1")
                {
                    MessageBox.Show(rs.ToString(), "Thêm dữ liệu");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thêm dữ liệu");
                }
                LoadListAccount();
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            TourDTO tourDTO = new TourDTO();
            string inputSearch = txtInputSearch.Text;
            ResetDataGridview();
            dgvAccount.DataSource = AccountBUS.Instance.SearchAccount(inputSearch);
            dgvAccount.DefaultCellStyle.Font = new Font("", 12);
        }

        private void ResetDataGridview(object sender, EventArgs e)
        {
            ResetDataGridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.PHONENUMBER = txtPhoneNumber.Text;
            userDTO.USERNAME = txtNameUser.Text;
            userDTO.ROLE = txtRole.Text;
            userDTO.PASSWORD = txtPassword.Text;
            AccountBUS.Instance.SaveAccount(userDTO);
            LoadListAccount();
            btnBack.Enabled = false;
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng dữ liệu này", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserDTO userDTO = new UserDTO();
                userDTO.PHONENUMBER = txtPhoneNumber.Text;
                int rs = AccountBUS.Instance.DeleteAccount(userDTO);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetForm();
                LoadListAccount();
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
            dgvAccount.ClearSelection();
            ResetForm();
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnGuide.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            txtPhoneNumber.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtNameUser.Focus();
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
            txtNameUser.Text = null;
            txtPhoneNumber.Text = null;
            txtRole.Text = null;
            txtPassword.Text = null;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListAccount();
            ResetForm();
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadListAccount();
            ResetForm();
        }

    }
}
