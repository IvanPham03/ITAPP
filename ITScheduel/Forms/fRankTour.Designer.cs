namespace GUI.Forms
{
    partial class fRankTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRankTour));
            groupBox1 = new GroupBox();
            txtWin = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtLoss = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtScore = new TextBox();
            label2 = new Label();
            txtIdTeam = new TextBox();
            label3 = new Label();
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
            btnRestore = new Button();
            btnBackup = new Button();
            btnExport = new Button();
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
            groupBox1.Controls.Add(txtWin);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtLoss);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtScore);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdTeam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdTour);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 366);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả giải đấu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtWin
            // 
            txtWin.Location = new Point(179, 239);
            txtWin.Name = "txtWin";
            txtWin.Size = new Size(343, 36);
            txtWin.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(528, 179);
            label13.Name = "label13";
            label13.Size = new Size(60, 30);
            label13.TabIndex = 16;
            label13.Text = "(*Số)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(528, 245);
            label12.Name = "label12";
            label12.Size = new Size(60, 30);
            label12.TabIndex = 15;
            label12.Text = "(*Số)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(528, 308);
            label11.Name = "label11";
            label11.Size = new Size(60, 30);
            label11.TabIndex = 14;
            label11.Text = "(*Số)";
            // 
            // txtLoss
            // 
            txtLoss.Location = new Point(179, 305);
            txtLoss.Name = "txtLoss";
            txtLoss.Size = new Size(343, 36);
            txtLoss.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(14, 307);
            label5.Name = "label5";
            label5.Size = new Size(130, 38);
            label5.TabIndex = 11;
            label5.Text = "Bàn thua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(14, 238);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 9;
            label4.Text = "Bàn thắng";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(179, 175);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(343, 36);
            txtScore.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(15, 176);
            label2.Name = "label2";
            label2.Size = new Size(113, 38);
            label2.TabIndex = 7;
            label2.Text = "Hiệu số";
            // 
            // txtIdTeam
            // 
            txtIdTeam.Location = new Point(179, 105);
            txtIdTeam.Name = "txtIdTeam";
            txtIdTeam.Size = new Size(343, 36);
            txtIdTeam.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(17, 105);
            label3.Name = "label3";
            label3.Size = new Size(107, 38);
            label3.TabIndex = 5;
            label3.Text = "Mã đội";
            label3.Click += label3_Click;
            // 
            // txtIdTour
            // 
            txtIdTour.Location = new Point(179, 43);
            txtIdTour.Name = "txtIdTour";
            txtIdTour.Size = new Size(343, 36);
            txtIdTour.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(17, 43);
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
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 415);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            button4.Location = new Point(1200, 287);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(185, 95);
            button4.TabIndex = 29;
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
            btnExit.Location = new Point(1391, 287);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(185, 95);
            btnExit.TabIndex = 28;
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
            btnDeleteAll.Location = new Point(1009, 287);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Padding = new Padding(10, 0, 0, 0);
            btnDeleteAll.Size = new Size(185, 95);
            btnDeleteAll.TabIndex = 27;
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
            btnDelete.Location = new Point(1391, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(185, 95);
            btnDelete.TabIndex = 26;
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
            btnAdd.Location = new Point(1009, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 21;
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
            btnModify.Location = new Point(1200, 157);
            btnModify.Name = "btnModify";
            btnModify.Padding = new Padding(10, 0, 0, 0);
            btnModify.Size = new Size(185, 95);
            btnModify.TabIndex = 25;
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
            btnSave.Location = new Point(1200, 31);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 22;
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
            btnResearch.Location = new Point(1009, 157);
            btnResearch.Name = "btnResearch";
            btnResearch.Padding = new Padding(10, 0, 0, 0);
            btnResearch.Size = new Size(185, 95);
            btnResearch.TabIndex = 24;
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
            btnRewrite.Location = new Point(1391, 31);
            btnRewrite.Name = "btnRewrite";
            btnRewrite.Padding = new Padding(10, 0, 0, 0);
            btnRewrite.Size = new Size(185, 95);
            btnRewrite.TabIndex = 23;
            btnRewrite.Text = "     Nhập        lại      ";
            btnRewrite.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRestore);
            groupBox3.Controls.Add(btnBackup);
            groupBox3.Controls.Add(btnExport);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(616, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 366);
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
            btnRestore.Location = new Point(93, 233);
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
            btnBackup.Location = new Point(93, 137);
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
            btnExport.Location = new Point(93, 38);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(200, 60);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 409);
            panel3.Name = "panel3";
            panel3.Size = new Size(1584, 851);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1561, 814);
            dataGridView1.TabIndex = 0;
            // 
            // fRankTour
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fRankTour";
            Text = "fSchedule";
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
        private TextBox txtIdTeam;
        private Label label3;
        private TextBox txtIdTour;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button btnRestore;
        private Button btnBackup;
        private Button btnExport;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox txtScore;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtLoss;
        private TextBox txtWin;
        private Label label13;
        private Label label12;
        private Label label11;
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