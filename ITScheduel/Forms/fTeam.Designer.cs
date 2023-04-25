namespace GUI.Forms
{
    partial class fTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTeam));
            groupBox1 = new GroupBox();
            cbNumber = new ComboBox();
            btnRegist = new Button();
            btnPlayer = new Button();
            label4 = new Label();
            txtNameTeam = new TextBox();
            label3 = new Label();
            txtTeamID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            txtInputSearch = new TextBox();
            btnRefesh = new Button();
            btnCopy = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            btnBack = new Button();
            panel3 = new Panel();
            dgvTeam = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeam).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbNumber);
            groupBox1.Controls.Add(btnRegist);
            groupBox1.Controls.Add(btnPlayer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNameTeam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTeamID);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đội";
            // 
            // cbNumber
            // 
            cbNumber.FormattingEnabled = true;
            cbNumber.Items.AddRange(new object[] { "5", "6", "7", "8", "9", "10", "11" });
            cbNumber.Location = new Point(283, 188);
            cbNumber.Name = "cbNumber";
            cbNumber.Size = new Size(407, 38);
            cbNumber.TabIndex = 16;
            cbNumber.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnRegist
            // 
            btnRegist.Cursor = Cursors.Hand;
            btnRegist.Enabled = false;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegist.ForeColor = Color.RoyalBlue;
            btnRegist.Image = (Image)resources.GetObject("btnRegist.Image");
            btnRegist.Location = new Point(283, 378);
            btnRegist.Margin = new Padding(10, 3, 3, 3);
            btnRegist.Name = "btnRegist";
            btnRegist.Padding = new Padding(50, 0, 0, 0);
            btnRegist.Size = new Size(407, 80);
            btnRegist.TabIndex = 15;
            btnRegist.TabStop = false;
            btnRegist.Text = " Đăng ký giải";
            btnRegist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegist.UseVisualStyleBackColor = true;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnPlayer
            // 
            btnPlayer.Cursor = Cursors.Hand;
            btnPlayer.Enabled = false;
            btnPlayer.FlatStyle = FlatStyle.Flat;
            btnPlayer.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlayer.ForeColor = Color.RoyalBlue;
            btnPlayer.Image = (Image)resources.GetObject("btnPlayer.Image");
            btnPlayer.Location = new Point(283, 269);
            btnPlayer.Margin = new Padding(10, 3, 3, 3);
            btnPlayer.Name = "btnPlayer";
            btnPlayer.Padding = new Padding(60, 0, 0, 0);
            btnPlayer.Size = new Size(407, 80);
            btnPlayer.TabIndex = 14;
            btnPlayer.TabStop = false;
            btnPlayer.Text = " Thành viên";
            btnPlayer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPlayer.UseVisualStyleBackColor = true;
            btnPlayer.Click += btnPlayer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(34, 188);
            label4.Name = "label4";
            label4.Size = new Size(198, 38);
            label4.TabIndex = 7;
            label4.Text = "Số thành viên ";
            label4.Click += label4_Click;
            // 
            // txtNameTeam
            // 
            txtNameTeam.Location = new Point(283, 117);
            txtNameTeam.Name = "txtNameTeam";
            txtNameTeam.Size = new Size(407, 36);
            txtNameTeam.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(34, 113);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 5;
            label3.Text = "Tên đội";
            // 
            // txtTeamID
            // 
            txtTeamID.Enabled = false;
            txtTeamID.Location = new Point(283, 51);
            txtTeamID.Name = "txtTeamID";
            txtTeamID.Size = new Size(407, 36);
            txtTeamID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 1;
            label1.Text = "Mã đội";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1577, 533);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtInputSearch);
            groupBox3.Controls.Add(btnRefesh);
            groupBox3.Controls.Add(btnCopy);
            groupBox3.Controls.Add(btnCancel);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(btnBack);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(780, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(797, 498);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // txtInputSearch
            // 
            txtInputSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInputSearch.Location = new Point(109, 39);
            txtInputSearch.Name = "txtInputSearch";
            txtInputSearch.PlaceholderText = "Nhập thông tin tìm kiếm....";
            txtInputSearch.Size = new Size(619, 45);
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
            btnRefesh.Location = new Point(109, 362);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Padding = new Padding(10, 0, 0, 0);
            btnRefesh.Size = new Size(185, 95);
            btnRefesh.TabIndex = 30;
            btnRefesh.Text = "       Làm        mới";
            btnRefesh.UseVisualStyleBackColor = false;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Transparent;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.Enabled = false;
            btnCopy.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnCopy.FlatAppearance.BorderSize = 3;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopy.ForeColor = Color.RoyalBlue;
            btnCopy.Image = (Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopy.Location = new Point(544, 362);
            btnCopy.Name = "btnCopy";
            btnCopy.Padding = new Padding(10, 0, 0, 0);
            btnCopy.Size = new Size(185, 95);
            btnCopy.TabIndex = 29;
            btnCopy.Text = "       Hướng   dẫn";
            btnCopy.UseVisualStyleBackColor = false;
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
            btnCancel.Location = new Point(544, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 0, 0);
            btnCancel.Size = new Size(185, 95);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "    Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnDelete.Location = new Point(326, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(185, 95);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "     Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_click;
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
            btnAdd.Location = new Point(109, 112);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "     Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            btnEdit.Location = new Point(326, 362);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(185, 95);
            btnEdit.TabIndex = 26;
            btnEdit.Text = "      Xuất";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
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
            btnSave.Location = new Point(326, 112);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 23;
            btnSave.Text = "     Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnSearch.Location = new Point(110, 236);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(10, 0, 0, 0);
            btnSearch.Size = new Size(185, 95);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "    Tìm ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            btnBack.Location = new Point(544, 112);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(10, 0, 0, 0);
            btnBack.Size = new Size(185, 95);
            btnBack.TabIndex = 24;
            btnBack.Text = "      Nhập         lại      ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvTeam);
            panel3.Location = new Point(0, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(1591, 744);
            panel3.TabIndex = 3;
            // 
            // dgvTeam
            // 
            dgvTeam.AllowUserToAddRows = false;
            dgvTeam.AllowUserToDeleteRows = false;
            dgvTeam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeam.Location = new Point(12, 3);
            dgvTeam.Name = "dgvTeam";
            dgvTeam.ReadOnly = true;
            dgvTeam.RowHeadersWidth = 72;
            dgvTeam.RowTemplate.Height = 37;
            dgvTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeam.Size = new Size(1565, 738);
            dgvTeam.TabIndex = 0;
            dgvTeam.CellClick += dgvTeam_CellContentClick;
            // 
            // fTeam
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fTeam";
            Text = "fSchedule";
            Load += fTeam_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private TextBox txtNameTeam;
        private Label label3;
        private DateTimePicker tdateTimePicker1;
        private TextBox txtTeamID;
        private Label label1;
        private Panel panel1;
        private RadioButton radioButton2;
        private Panel panel3;
        private DataGridView dgvTeam;
        private Label label6;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnRefesh;
        private Button btnCopy;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSave;
        private Button btnSearch;
        private Button btnBack;
        private Button btnPlayer;
        private Button btnRegist;
        public TextBox txtInputSearch;
        private ComboBox cbNumber;
    }
}