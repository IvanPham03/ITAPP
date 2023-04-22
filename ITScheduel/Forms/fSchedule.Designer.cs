namespace GUI.Forms
{
    partial class fSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSchedule));
            groupBox1 = new GroupBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            txtIdMatch = new TextBox();
            label2 = new Label();
            txtIdTeam2 = new TextBox();
            label3 = new Label();
            txtIdTeam1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnRestore = new Button();
            btnBackup = new Button();
            btnExport = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label13 = new Label();
            txtCardRed2 = new TextBox();
            txtCardYellow2 = new TextBox();
            txtCardRed1 = new TextBox();
            txtCardYellow1 = new TextBox();
            textBox3 = new TextBox();
            txtWin2 = new TextBox();
            textBox2 = new TextBox();
            txtWin1 = new TextBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnResearch = new Button();
            btnRewrite = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(txtIdMatch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdTeam2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdTeam1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lịch thi đấu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(30, 292);
            label4.Name = "label4";
            label4.Size = new Size(123, 38);
            label4.TabIndex = 9;
            label4.Text = "Lịch đấu";
            // 
            // dtpDate
            // 
            dtpDate.CalendarForeColor = Color.DodgerBlue;
            dtpDate.CalendarMonthBackground = Color.RoyalBlue;
            dtpDate.Location = new Point(200, 297);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(343, 36);
            dtpDate.TabIndex = 8;
            // 
            // txtIdMatch
            // 
            txtIdMatch.Location = new Point(200, 219);
            txtIdMatch.Name = "txtIdMatch";
            txtIdMatch.Size = new Size(343, 36);
            txtIdMatch.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(30, 216);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 7;
            label2.Text = "Mã trận";
            // 
            // txtIdTeam2
            // 
            txtIdTeam2.Location = new Point(200, 140);
            txtIdTeam2.Name = "txtIdTeam2";
            txtIdTeam2.Size = new Size(343, 36);
            txtIdTeam2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(30, 140);
            label3.Name = "label3";
            label3.Size = new Size(131, 38);
            label3.TabIndex = 5;
            label3.Text = "Mã đội 2";
            // 
            // txtIdTeam1
            // 
            txtIdTeam1.Location = new Point(200, 70);
            txtIdTeam1.Name = "txtIdTeam1";
            txtIdTeam1.Size = new Size(343, 36);
            txtIdTeam1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(30, 69);
            label1.Name = "label1";
            label1.Size = new Size(126, 38);
            label1.TabIndex = 1;
            label1.Text = "Mã đội 1";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 380);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRestore);
            groupBox3.Controls.Add(btnBackup);
            groupBox3.Controls.Add(btnExport);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(1254, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 365);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // btnRestore
            // 
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnRestore.FlatAppearance.BorderSize = 3;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestore.ForeColor = Color.RoyalBlue;
            btnRestore.Location = new Point(72, 279);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(200, 60);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "Phục hồi";
            btnRestore.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnBackup.FlatAppearance.BorderSize = 3;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackup.ForeColor = Color.RoyalBlue;
            btnBackup.Location = new Point(72, 173);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(200, 60);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Sao lưu";
            btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnExport.FlatAppearance.BorderSize = 3;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.RoyalBlue;
            btnExport.Location = new Point(72, 68);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(200, 60);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtCardRed2);
            groupBox2.Controls.Add(txtCardYellow2);
            groupBox2.Controls.Add(txtCardRed1);
            groupBox2.Controls.Add(txtCardYellow1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(txtWin2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(txtWin1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.RoyalBlue;
            groupBox2.Location = new Point(607, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 362);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết kết quả";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(550, 297);
            label8.Name = "label8";
            label8.Size = new Size(60, 30);
            label8.TabIndex = 25;
            label8.Text = "(*Số)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(550, 215);
            label9.Name = "label9";
            label9.Size = new Size(60, 30);
            label9.TabIndex = 24;
            label9.Text = "(*Số)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(550, 140);
            label10.Name = "label10";
            label10.Size = new Size(60, 30);
            label10.TabIndex = 23;
            label10.Text = "(*Số)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(550, 72);
            label11.Name = "label11";
            label11.Size = new Size(60, 30);
            label11.TabIndex = 22;
            label11.Text = "(*Số)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(252, 297);
            label7.Name = "label7";
            label7.Size = new Size(60, 30);
            label7.TabIndex = 21;
            label7.Text = "(*Số)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(252, 217);
            label6.Name = "label6";
            label6.Size = new Size(60, 30);
            label6.TabIndex = 20;
            label6.Text = "(*Số)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(252, 141);
            label5.Name = "label5";
            label5.Size = new Size(60, 30);
            label5.TabIndex = 19;
            label5.Text = "(*Số)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(252, 72);
            label13.Name = "label13";
            label13.Size = new Size(60, 30);
            label13.TabIndex = 18;
            label13.Text = "(*Số)";
            // 
            // txtCardRed2
            // 
            txtCardRed2.Location = new Point(318, 294);
            txtCardRed2.Name = "txtCardRed2";
            txtCardRed2.PlaceholderText = "Số điểm 1";
            txtCardRed2.Size = new Size(228, 36);
            txtCardRed2.TabIndex = 17;
            // 
            // txtCardYellow2
            // 
            txtCardYellow2.Location = new Point(18, 294);
            txtCardYellow2.Name = "txtCardYellow2";
            txtCardYellow2.PlaceholderText = "Thẻ vàng 2";
            txtCardYellow2.Size = new Size(228, 36);
            txtCardYellow2.TabIndex = 16;
            // 
            // txtCardRed1
            // 
            txtCardRed1.Location = new Point(316, 213);
            txtCardRed1.Name = "txtCardRed1";
            txtCardRed1.PlaceholderText = "Số điểm 1";
            txtCardRed1.Size = new Size(228, 36);
            txtCardRed1.TabIndex = 15;
            // 
            // txtCardYellow1
            // 
            txtCardYellow1.Location = new Point(18, 215);
            txtCardYellow1.Name = "txtCardYellow1";
            txtCardYellow1.PlaceholderText = "Thẻ vàng 1";
            txtCardYellow1.Size = new Size(228, 36);
            txtCardYellow1.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 139);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Thẻ đỏ 2";
            textBox3.Size = new Size(228, 36);
            textBox3.TabIndex = 13;
            // 
            // txtWin2
            // 
            txtWin2.Location = new Point(18, 137);
            txtWin2.Name = "txtWin2";
            txtWin2.PlaceholderText = "Bàn thắng 2";
            txtWin2.Size = new Size(228, 36);
            txtWin2.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 70);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Thẻ đỏ 1";
            textBox2.Size = new Size(228, 36);
            textBox2.TabIndex = 11;
            // 
            // txtWin1
            // 
            txtWin1.Location = new Point(18, 66);
            txtWin1.Name = "txtWin1";
            txtWin1.PlaceholderText = "Bàn thắng 1";
            txtWin1.Size = new Size(228, 36);
            txtWin1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnDeleteAll);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnModify);
            panel2.Controls.Add(btnResearch);
            panel2.Controls.Add(btnRewrite);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(0, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(1584, 149);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.RoyalBlue;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1385, 25);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(185, 95);
            btnExit.TabIndex = 10;
            btnExit.Text = "     Thoát";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Transparent;
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnDeleteAll.FlatAppearance.BorderSize = 3;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAll.ForeColor = Color.RoyalBlue;
            btnDeleteAll.Image = (Image)resources.GetObject("btnDeleteAll.Image");
            btnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAll.Location = new Point(1190, 25);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Padding = new Padding(10, 0, 0, 0);
            btnDeleteAll.Size = new Size(185, 95);
            btnDeleteAll.TabIndex = 9;
            btnDeleteAll.Text = "     Xóa tất     cả";
            btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.RoyalBlue;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(992, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(185, 95);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "     Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Transparent;
            btnModify.Cursor = Cursors.Hand;
            btnModify.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnModify.FlatAppearance.BorderSize = 3;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModify.ForeColor = Color.RoyalBlue;
            btnModify.Image = (Image)resources.GetObject("btnModify.Image");
            btnModify.ImageAlign = ContentAlignment.MiddleLeft;
            btnModify.Location = new Point(796, 25);
            btnModify.Name = "btnModify";
            btnModify.Padding = new Padding(10, 0, 0, 0);
            btnModify.Size = new Size(185, 95);
            btnModify.TabIndex = 7;
            btnModify.Text = "     Sửa";
            btnModify.UseVisualStyleBackColor = false;
            // 
            // btnResearch
            // 
            btnResearch.BackColor = Color.Transparent;
            btnResearch.Cursor = Cursors.Hand;
            btnResearch.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnResearch.FlatAppearance.BorderSize = 3;
            btnResearch.FlatStyle = FlatStyle.Flat;
            btnResearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResearch.ForeColor = Color.RoyalBlue;
            btnResearch.Image = (Image)resources.GetObject("btnResearch.Image");
            btnResearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnResearch.Location = new Point(597, 25);
            btnResearch.Name = "btnResearch";
            btnResearch.Padding = new Padding(10, 0, 0, 0);
            btnResearch.Size = new Size(185, 95);
            btnResearch.TabIndex = 6;
            btnResearch.Text = "     Tìm";
            btnResearch.UseVisualStyleBackColor = false;
            // 
            // btnRewrite
            // 
            btnRewrite.BackColor = Color.Transparent;
            btnRewrite.Cursor = Cursors.Hand;
            btnRewrite.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnRewrite.FlatAppearance.BorderSize = 3;
            btnRewrite.FlatStyle = FlatStyle.Flat;
            btnRewrite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRewrite.ForeColor = Color.RoyalBlue;
            btnRewrite.Image = (Image)resources.GetObject("btnRewrite.Image");
            btnRewrite.ImageAlign = ContentAlignment.MiddleLeft;
            btnRewrite.Location = new Point(401, 26);
            btnRewrite.Name = "btnRewrite";
            btnRewrite.Padding = new Padding(10, 0, 0, 0);
            btnRewrite.Size = new Size(185, 95);
            btnRewrite.TabIndex = 5;
            btnRewrite.Text = "     Nhập        lại      ";
            btnRewrite.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.RoyalBlue;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(205, 26);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 4;
            btnSave.Text = "     Lưu";
            btnSave.UseVisualStyleBackColor = false;
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
            btnAdd.Location = new Point(12, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "     Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 530);
            panel3.Name = "panel3";
            panel3.Size = new Size(1584, 730);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1565, 680);
            dataGridView1.TabIndex = 0;
            // 
            // fSchedule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fSchedule";
            Text = "fSchedule";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdTeam2;
        private Label label3;
        private TextBox txtIdTeam1;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button btnRestore;
        private Button btnBackup;
        private Button btnExport;
        private GroupBox groupBox2;
        private Panel panel2;
        private Button btnExit;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnModify;
        private Button btnResearch;
        private Button btnRewrite;
        private Button btnSave;
        private Button btnAdd;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox txtIdMatch;
        private Label label2;
        private Label label4;
        private DateTimePicker dtpDate;
        private TextBox txtCardRed2;
        private TextBox txtCardYellow2;
        private TextBox txtCardRed1;
        private TextBox txtCardYellow1;
        private TextBox textBox3;
        private TextBox txtWin2;
        private TextBox textBox2;
        private TextBox txtWin1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
    }
}