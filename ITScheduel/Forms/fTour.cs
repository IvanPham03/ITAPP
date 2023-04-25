using BUS;
using DAO;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
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
        public fMainAdmin main;
        public fTour(fMainAdmin main)
        {
            InitializeComponent();
            this.main = main;
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
            dgvTour.DataSource = TourBUS.Instance.LoadTour();
            dgvTour.DefaultCellStyle.Font = new System.Drawing.Font("", 12);
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
            checkFillTeam();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TourDTO tourDTO = new TourDTO();
            tourDTO.TOURNAME = txtNameTour.Text;
            tourDTO.DATESTART = dtpStart.Value.ToShortDateString();
            tourDTO.DATEEND = dtpStart.Value.ToShortDateString();
            String rs = TourBUS.Instance.AddTour(tourDTO);
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
            string key = txtInputSearch.Text;
            ResetDataGridview();
            dgvTour.DataSource = TourBUS.Instance.SearchTour(key);
            dgvTour.DefaultCellStyle.Font = new System.Drawing.Font("", 12);
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
            TourBUS.Instance.SaveTour(tourDTO);
            LoadListTour();
            btnBack.Enabled = false;
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng dữ liệu này", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TourDTO tourDTO = new TourDTO();
                tourDTO.TOURID = txtTourId.Text;
                int rs = TourBUS.Instance.DeleteTour(tourDTO);
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
            btnSchedule.Enabled = false;
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
            btnBack.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
        }
        public void checkFillTeam()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            TourDTO tourDTO = new TourDTO();
            tourDTO.TOURID = txtTourId.Text;
            dt = RegistBUS.Instance.LoadRegistTour(tourDTO);
            if (dt.Rows.Count == 16)
            {
                btnSchedule.Enabled = true;
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            if (dgvTour.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Envanter.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {

                            ErrorMessage = true;
                            MessageBox.Show("Have a problem!" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvTour.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dgvTour.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvTour.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 12f, 20f, 20f, 12f);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Success", "infor");

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Have a problem!" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("have a problem", "Infor");

            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            TourDTO tourDTO = new TourDTO();
            tourDTO.TOURID = txtTourId.Text;
           
            MainSchedule.Instance.RoundStage(tourDTO);
            

        }
    }
}
