namespace GUI.Forms
{
    partial class fSettingAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettingAdmin));
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            lbHelp = new Label();
            btnRefesh = new Button();
            btnCopy = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            txtRole = new TextBox();
            txtPassword = new TextBox();
            dtpDateAt = new DateTimePicker();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            dtpUpdatedAt = new DateTimePicker();
            label1 = new Label();
            txtNameUser = new TextBox();
            panel2 = new Panel();
            dgvAccount = new DataGridView();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 1272);
            panel1.TabIndex = 34;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbHelp);
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
            groupBox3.Location = new Point(3, 612);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(680, 603);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // lbHelp
            // 
            lbHelp.AutoSize = true;
            lbHelp.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbHelp.Location = new Point(607, 528);
            lbHelp.Name = "lbHelp";
            lbHelp.Size = new Size(39, 51);
            lbHelp.TabIndex = 31;
            lbHelp.Text = "?";
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
            btnRefesh.Location = new Point(461, 375);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Padding = new Padding(10, 0, 0, 0);
            btnRefesh.Size = new Size(185, 95);
            btnRefesh.TabIndex = 30;
            btnRefesh.Text = "       Làm        mới";
            btnRefesh.UseVisualStyleBackColor = false;
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
            btnCopy.Location = new Point(13, 374);
            btnCopy.Name = "btnCopy";
            btnCopy.Padding = new Padding(10, 0, 0, 0);
            btnCopy.Size = new Size(185, 95);
            btnCopy.TabIndex = 29;
            btnCopy.Text = "       Sao            chép      ";
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
            btnCancel.Location = new Point(461, 243);
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
            btnDelete.Location = new Point(237, 243);
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
            btnAdd.Location = new Point(13, 113);
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
            btnEdit.Location = new Point(237, 375);
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
            btnSave.Location = new Point(237, 113);
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
            btnSearch.Location = new Point(13, 243);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(10, 0, 0, 0);
            btnSearch.Size = new Size(185, 95);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "     Tìm ";
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
            btnBack.Location = new Point(461, 111);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(10, 0, 0, 0);
            btnBack.Size = new Size(185, 95);
            btnBack.TabIndex = 24;
            btnBack.Text = "      Nhập         lại      ";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRole);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(dtpDateAt);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(dtpUpdatedAt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNameUser);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(3, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 557);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(296, 201);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(356, 36);
            txtRole.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(296, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(356, 36);
            txtPassword.TabIndex = 15;
            // 
            // dtpDateAt
            // 
            dtpDateAt.Location = new Point(296, 420);
            dtpDateAt.Name = "dtpDateAt";
            dtpDateAt.Size = new Size(356, 36);
            dtpDateAt.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(296, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 36);
            txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(17, 348);
            label7.Name = "label7";
            label7.Size = new Size(138, 38);
            label7.TabIndex = 12;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(17, 491);
            label6.Name = "label6";
            label6.Size = new Size(202, 38);
            label6.TabIndex = 11;
            label6.Text = "Ngày cập nhật";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(17, 420);
            label5.Name = "label5";
            label5.Size = new Size(134, 38);
            label5.TabIndex = 10;
            label5.Text = "Ngày tạo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(19, 274);
            label4.Name = "label4";
            label4.Size = new Size(86, 38);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(17, 195);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 8;
            label3.Text = "Vai trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(17, 125);
            label2.Name = "label2";
            label2.Size = new Size(185, 38);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(296, 127);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(356, 36);
            txtPhoneNumber.TabIndex = 6;
            // 
            // dtpUpdatedAt
            // 
            dtpUpdatedAt.Location = new Point(296, 491);
            dtpUpdatedAt.Name = "dtpUpdatedAt";
            dtpUpdatedAt.Size = new Size(356, 36);
            dtpUpdatedAt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(17, 61);
            label1.Name = "label1";
            label1.Size = new Size(104, 38);
            label1.TabIndex = 2;
            label1.Text = "Họ tên";
            // 
            // txtNameUser
            // 
            txtNameUser.Location = new Point(296, 61);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.Size = new Size(356, 36);
            txtNameUser.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAccount);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(689, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 1272);
            panel2.TabIndex = 35;
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(0, 0);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 72;
            dgvAccount.RowTemplate.Height = 37;
            dgvAccount.Size = new Size(900, 1272);
            dgvAccount.TabIndex = 0;
            // 
            // fSettingAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fSettingAdmin";
            Text = "fSetting";
            Load += fSettingAdmin_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtRole;
        private TextBox txtPassword;
        private DateTimePicker dtpDateAt;
        private TextBox txtEmail;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPhoneNumber;
        private DateTimePicker dtpUpdatedAt;
        private Label label1;
        private TextBox txtNameUser;
        private Panel panel2;
        private DataGridView dgvAccount;
        private GroupBox groupBox3;
        private Label lbHelp;
        private Button btnRefesh;
        private Button btnCopy;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSave;
        private Button btnSearch;
        private Button btnBack;
    }
}