namespace GUI.Forms
{
    partial class fRegist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegist));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            txtIdRep = new TextBox();
            label3 = new Label();
            txtIdTour = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            txtInputSearch = new TextBox();
            btnRefesh = new Button();
            btnGuide = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            btnBack = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdRep);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdTour);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 496);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng ký giải đấu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 36);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(28, 116);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 7;
            label4.Text = "Tên giải";
            // 
            // txtIdRep
            // 
            txtIdRep.Location = new Point(263, 191);
            txtIdRep.Name = "txtIdRep";
            txtIdRep.Size = new Size(466, 36);
            txtIdRep.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(28, 191);
            label3.Name = "label3";
            label3.Size = new Size(107, 38);
            label3.TabIndex = 5;
            label3.Text = "Mã đội";
            // 
            // txtIdTour
            // 
            txtIdTour.Location = new Point(261, 39);
            txtIdTour.Name = "txtIdTour";
            txtIdTour.Size = new Size(466, 36);
            txtIdTour.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 1;
            label1.Text = "Mã giải";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1592, 520);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtInputSearch);
            groupBox3.Controls.Add(btnRefesh);
            groupBox3.Controls.Add(btnGuide);
            groupBox3.Controls.Add(btnCancel);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(btnBack);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(815, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(762, 493);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // txtInputSearch
            // 
            txtInputSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInputSearch.Location = new Point(90, 48);
            txtInputSearch.Name = "txtInputSearch";
            txtInputSearch.PlaceholderText = "Nhập thông tin tìm kiếm....";
            txtInputSearch.Size = new Size(626, 45);
            txtInputSearch.TabIndex = 32;
            // 
            // btnRefesh
            // 
            btnRefesh.BackColor = Color.Transparent;
            btnRefesh.Cursor = Cursors.Hand;
            btnRefesh.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnRefesh.FlatAppearance.BorderSize = 3;
            btnRefesh.FlatStyle = FlatStyle.Flat;
            btnRefesh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefesh.ForeColor = Color.RoyalBlue;
            btnRefesh.Image = (Image)resources.GetObject("btnRefesh.Image");
            btnRefesh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefesh.Location = new Point(90, 365);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Padding = new Padding(10, 0, 0, 0);
            btnRefesh.Size = new Size(185, 95);
            btnRefesh.TabIndex = 30;
            btnRefesh.Text = "       Làm        mới";
            btnRefesh.UseVisualStyleBackColor = false;
            // 
            // btnGuide
            // 
            btnGuide.BackColor = Color.Transparent;
            btnGuide.Cursor = Cursors.Hand;
            btnGuide.Enabled = false;
            btnGuide.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnGuide.FlatAppearance.BorderSize = 3;
            btnGuide.FlatStyle = FlatStyle.Flat;
            btnGuide.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuide.ForeColor = Color.RoyalBlue;
            btnGuide.Image = (Image)resources.GetObject("btnGuide.Image");
            btnGuide.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuide.Location = new Point(531, 365);
            btnGuide.Name = "btnGuide";
            btnGuide.Padding = new Padding(10, 0, 0, 0);
            btnGuide.Size = new Size(185, 95);
            btnGuide.TabIndex = 29;
            btnGuide.Text = "       Hướng   dẫn";
            btnGuide.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Enabled = false;
            btnCancel.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.RoyalBlue;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(530, 244);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 0, 0);
            btnCancel.Size = new Size(185, 95);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "    Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.RoyalBlue;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(312, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(185, 95);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "     Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.RoyalBlue;
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(90, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "     Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnEdit.FlatAppearance.BorderSize = 3;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.RoyalBlue;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(312, 365);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(185, 95);
            btnEdit.TabIndex = 26;
            btnEdit.Text = "      Xuất";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.RoyalBlue;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(310, 116);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 23;
            btnSave.Text = "     Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.RoyalBlue;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(90, 239);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(10, 0, 0, 0);
            btnSearch.Size = new Size(185, 95);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "    Tìm ";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Enabled = false;
            btnBack.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnBack.FlatAppearance.BorderSize = 3;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.RoyalBlue;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(530, 119);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(10, 0, 0, 0);
            btnBack.Size = new Size(185, 95);
            btnBack.TabIndex = 24;
            btnBack.Text = "      Nhập         lại      ";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 523);
            panel3.Name = "panel3";
            panel3.Size = new Size(1592, 750);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1565, 854);
            dataGridView1.TabIndex = 0;
            // 
            // fRegist
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fRegist";
            Text = "fSchedule";
            Load += fSchedule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label4;
        private GroupBox groupBox3;
        public TextBox txtInputSearch;
        private Button btnRefesh;
        private Button btnGuide;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSave;
        private Button btnSearch;
        private Button btnBack;
        private TextBox textBox1;
        private TextBox txtIdRep;
        private TextBox txtIdTour;
    }
}