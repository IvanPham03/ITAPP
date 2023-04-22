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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fTour : Form
    {
        public fTour()
        {
            InitializeComponent();
            LoadListTour();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void fSchedule_Load(object sender, EventArgs e)
        {

        }

        public void ResetDataGridview()
        {
            dgvTour.DataSource = null;
        }
        //==
        public void LoadListTour()
        {
            dgvTour.DataSource = TourBus.Instance.LoadTour();
            dgvTour.DefaultCellStyle.Font = new Font("", 12);
        }

        private void dgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvTour.Rows[e.RowIndex];
                txtNameTour.Text = selectRow.Cells[0].Value.ToString();
                txtTourId.Text = selectRow.Cells[1].Value.ToString();
                dtpStart.Value = DateTime.Parse(selectRow.Cells[2].Value.ToString());
                dtpEnd.Value = DateTime.Parse(selectRow.Cells[3].Value.ToString());
            }
            btnCancel.Enabled = true;
            txtTourId.Enabled = false;
            btnDelete.Enabled = true;
            btnSearch.Enabled = false;
            btnEdit.Enabled = true;
            btnCopy.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TourDTO tourDTO = new TourDTO();
            tourDTO.TOURNAME = txtNameTour.Text;
            tourDTO.DATESTART = dtpStart.Value.ToShortDateString();
            tourDTO.DATEEND = dtpStart.Value.ToShortDateString();
            String rs = TourBus.Instance.AddTour(tourDTO);
            if (rs != "1")
            {
                MessageBox.Show(rs.ToString(), "Thêm dữ liệu");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thêm dữ liệu");
            }
            LoadListTour();

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            TourDTO tourDTO = new TourDTO();
            tourDTO.TOURNAME = txtNameTour.Text;
            tourDTO.TOURID = txtTourId.Text;
            ResetDataGridview();
            dgvTour.DataSource = TourBus.Instance.SearchTour(tourDTO);
            dgvTour.DefaultCellStyle.Font = new Font("", 12);
        }

        private void ResetDataGridview(object sender, EventArgs e)
        {
            ResetDataGridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TourDTO tourDTO = new TourDTO();
            tourDTO.TOURNAME = txtNameTour.Text;
            tourDTO.TOURID = txtTourId.Text;
            tourDTO.DATESTART = dtpStart.Value.ToShortDateString();
            tourDTO.DATEEND = dtpStart.Value.ToShortDateString();
            TourBus.Instance.SaveTour(tourDTO);
            LoadListTour();
            btnBack.Enabled = false;
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng dữ liệu này", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TourDTO tourDTO = new TourDTO();
                tourDTO.TOURID = txtTourId.Text;
                int rs = TourBus.Instance.DeleteTour(tourDTO);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetForm();
                LoadListTour();
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
            dgvTour.ClearSelection();
            ResetForm();
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnCopy.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            txtTourId.Enabled = true;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtNameTour.Focus();
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
            txtNameTour.Text = null;
            txtTourId.Text = null;
            dtpStart.Value = DateAndTime.Now;
            dtpEnd.Value = DateAndTime.Now;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListTour();
            ResetForm();
        }
    }
}
