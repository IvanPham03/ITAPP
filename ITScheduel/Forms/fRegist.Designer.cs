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
            txtIdRep = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpDateAt = new DateTimePicker();
            txtIdTour = new TextBox();
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
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            groupBox1.Controls.Add(txtIdRep);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpDateAt);
            groupBox1.Controls.Add(txtIdTour);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng ký giải đấu";
            // 
            // txtIdRep
            // 
            txtIdRep.Location = new Point(252, 106);
            txtIdRep.Name = "txtIdRep";
            txtIdRep.Size = new Size(350, 36);
            txtIdRep.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(168, 38);
            label3.TabIndex = 5;
            label3.Text = "Mã đại diện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(19, 170);
            label2.Name = "label2";
            label2.Size = new Size(194, 38);
            label2.TabIndex = 3;
            label2.Text = "Ngày đăng ký";
            // 
            // dtpDateAt
            // 
            dtpDateAt.CalendarForeColor = Color.DodgerBlue;
            dtpDateAt.CalendarMonthBackground = Color.RoyalBlue;
            dtpDateAt.Location = new Point(252, 172);
            dtpDateAt.Name = "dtpDateAt";
            dtpDateAt.Size = new Size(350, 36);
            dtpDateAt.TabIndex = 2;
            // 
            // txtIdTour
            // 
            txtIdTour.Location = new Point(252, 38);
            txtIdTour.Name = "txtIdTour";
            txtIdTour.Size = new Size(350, 36);
            txtIdTour.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 1;
            label1.Text = "Mã giải";
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
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 415);
            panel1.TabIndex = 1;
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
            button4.Location = new Point(1196, 289);
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
            btnExit.Location = new Point(1387, 289);
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
            btnDeleteAll.Location = new Point(1005, 289);
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
            btnDelete.Location = new Point(1387, 159);
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
            btnAdd.Location = new Point(1005, 33);
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
            btnModify.Location = new Point(1196, 159);
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
            btnSave.Location = new Point(1196, 33);
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
            btnResearch.Location = new Point(1005, 159);
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
            btnRewrite.Location = new Point(1387, 33);
            btnRewrite.Name = "btnRewrite";
            btnRewrite.Padding = new Padding(10, 0, 0, 0);
            btnRewrite.Size = new Size(185, 95);
            btnRewrite.TabIndex = 14;
            btnRewrite.Text = "     Nhập        lại      ";
            btnRewrite.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(645, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(346, 367);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.RoyalBlue;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(87, 245);
            button3.Name = "button3";
            button3.Size = new Size(200, 60);
            button3.TabIndex = 2;
            button3.Text = "Phục hồi";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(87, 142);
            button2.Name = "button2";
            button2.Size = new Size(200, 60);
            button2.TabIndex = 1;
            button2.Text = "Sao lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(87, 40);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 0;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 416);
            panel3.Name = "panel3";
            panel3.Size = new Size(1584, 844);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1560, 826);
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
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdRep;
        private Label label3;
        private DateTimePicker dtpDateAt;
        private TextBox txtIdTour;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button4;
        private Button btnExit;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnResearch;
        private Button btnRewrite;
    }
}