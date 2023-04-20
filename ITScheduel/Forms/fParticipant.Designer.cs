namespace GUI.Forms
{
    partial class fParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParticipant));
            groupBox1 = new GroupBox();
            label4 = new Label();
            dtpDoB = new DateTimePicker();
            txtName = new TextBox();
            label2 = new Label();
            txtIdTeam = new TextBox();
            label3 = new Label();
            txtIdPlayer = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            btnExit = new Button();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnResearch = new Button();
            btnRewrite = new Button();
            groupBox4 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDoB);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdTeam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdPlayer);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(10, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 365);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tham gia thi đấu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(15, 295);
            label4.Name = "label4";
            label4.Size = new Size(100, 38);
            label4.TabIndex = 9;
            label4.Text = "Vai trò";
            // 
            // dtpDoB
            // 
            dtpDoB.CalendarForeColor = Color.DodgerBlue;
            dtpDoB.CalendarMonthBackground = Color.RoyalBlue;
            dtpDoB.Location = new Point(243, 297);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(350, 36);
            dtpDoB.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(240, 221);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 36);
            txtName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(15, 217);
            label2.Name = "label2";
            label2.Size = new Size(77, 38);
            label2.TabIndex = 7;
            label2.Text = "Vị trí";
            // 
            // txtIdTeam
            // 
            txtIdTeam.Location = new Point(240, 138);
            txtIdTeam.Name = "txtIdTeam";
            txtIdTeam.Size = new Size(350, 36);
            txtIdTeam.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(15, 136);
            label3.Name = "label3";
            label3.Size = new Size(199, 38);
            label3.TabIndex = 5;
            label3.Text = "Mã thành viên";
            // 
            // txtIdPlayer
            // 
            txtIdPlayer.Location = new Point(240, 52);
            txtIdPlayer.Name = "txtIdPlayer";
            txtIdPlayer.Size = new Size(350, 36);
            txtIdPlayer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(15, 58);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 1;
            label1.Text = "Mã trận";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDeleteAll);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnResearch);
            panel1.Controls.Add(btnRewrite);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 413);
            panel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.RoyalBlue;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1198, 294);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(185, 95);
            button4.TabIndex = 20;
            button4.Text = "     Sao            chép      ";
            button4.UseVisualStyleBackColor = false;
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
            btnExit.Location = new Point(1389, 294);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(185, 95);
            btnExit.TabIndex = 19;
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
            btnDeleteAll.Location = new Point(1007, 294);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Padding = new Padding(10, 0, 0, 0);
            btnDeleteAll.Size = new Size(185, 95);
            btnDeleteAll.TabIndex = 18;
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
            btnDelete.Location = new Point(1389, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(185, 95);
            btnDelete.TabIndex = 17;
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
            btnAdd.Location = new Point(1007, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "     Thêm";
            btnAdd.UseVisualStyleBackColor = false;
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
            btnModify.Location = new Point(1198, 166);
            btnModify.Name = "btnModify";
            btnModify.Padding = new Padding(10, 0, 0, 0);
            btnModify.Size = new Size(185, 95);
            btnModify.TabIndex = 16;
            btnModify.Text = "     Sửa";
            btnModify.UseVisualStyleBackColor = false;
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
            btnSave.Location = new Point(1198, 40);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 13;
            btnSave.Text = "     Lưu";
            btnSave.UseVisualStyleBackColor = false;
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
            btnResearch.Location = new Point(1007, 166);
            btnResearch.Name = "btnResearch";
            btnResearch.Padding = new Padding(10, 0, 0, 0);
            btnResearch.Size = new Size(185, 95);
            btnResearch.TabIndex = 15;
            btnResearch.Text = "     Tìm ";
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
            btnRewrite.Location = new Point(1389, 40);
            btnRewrite.Name = "btnRewrite";
            btnRewrite.Padding = new Padding(10, 0, 0, 0);
            btnRewrite.Size = new Size(185, 95);
            btnRewrite.TabIndex = 14;
            btnRewrite.Text = "     Nhập        lại      ";
            btnRewrite.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button3);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.RoyalBlue;
            groupBox4.Location = new Point(647, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(350, 365);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dữ liệu";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(87, 281);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 2;
            button1.Text = "Phục hồi";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(87, 175);
            button2.Name = "button2";
            button2.Size = new Size(200, 60);
            button2.TabIndex = 1;
            button2.Text = "Sao lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.RoyalBlue;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(87, 70);
            button3.Name = "button3";
            button3.Size = new Size(200, 60);
            button3.TabIndex = 0;
            button3.Text = "Xuất";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(2, 420);
            panel3.Name = "panel3";
            panel3.Size = new Size(1584, 838);
            panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1565, 835);
            dataGridView1.TabIndex = 0;
            // 
            // fParticipant
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fParticipant";
            Text = "fParticipant";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dtpDoB;
        private TextBox txtName;
        private Label label2;
        private TextBox txtIdTeam;
        private Label label3;
        private TextBox txtIdPlayer;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button btnExit;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnResearch;
        private Button btnRewrite;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}