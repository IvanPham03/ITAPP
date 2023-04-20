namespace GUI.Forms
{
    partial class fRound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRound));
            panel1 = new Panel();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtNameRound = new TextBox();
            txtIdTour = new TextBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnResearch = new Button();
            btnRewrite = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbRoundStage = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            label5 = new Label();
            dataGridView5 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnResearch);
            panel1.Controls.Add(btnRewrite);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 1272);
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
            button4.Location = new Point(397, 444);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(185, 95);
            button4.TabIndex = 21;
            button4.Text = "     Sao            chép      ";
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNameRound);
            groupBox1.Controls.Add(txtIdTour);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(16, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 295);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vòng đấu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 2;
            label1.Text = "Tên vòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(6, 148);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 3;
            label2.Text = "Mã giải";
            // 
            // txtNameRound
            // 
            txtNameRound.Location = new Point(27, 102);
            txtNameRound.Name = "txtNameRound";
            txtNameRound.Size = new Size(329, 36);
            txtNameRound.TabIndex = 4;
            // 
            // txtIdTour
            // 
            txtIdTour.Location = new Point(27, 189);
            txtIdTour.Name = "txtIdTour";
            txtIdTour.Size = new Size(329, 36);
            txtIdTour.TabIndex = 5;
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
            btnExit.Location = new Point(589, 444);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(185, 95);
            btnExit.TabIndex = 18;
            btnExit.Text = "     Thoát";
            btnExit.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(206, 444);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(185, 95);
            btnDelete.TabIndex = 16;
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
            btnModify.Location = new Point(16, 444);
            btnModify.Name = "btnModify";
            btnModify.Padding = new Padding(10, 0, 0, 0);
            btnModify.Size = new Size(185, 95);
            btnModify.TabIndex = 15;
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
            btnResearch.Location = new Point(589, 329);
            btnResearch.Name = "btnResearch";
            btnResearch.Padding = new Padding(10, 0, 0, 0);
            btnResearch.Size = new Size(185, 95);
            btnResearch.TabIndex = 14;
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
            btnRewrite.Location = new Point(398, 329);
            btnRewrite.Name = "btnRewrite";
            btnRewrite.Padding = new Padding(10, 0, 0, 0);
            btnRewrite.Size = new Size(185, 95);
            btnRewrite.TabIndex = 13;
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
            btnSave.Location = new Point(207, 329);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 12;
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
            btnAdd.Location = new Point(16, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "     Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(407, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(367, 295);
            groupBox3.TabIndex = 10;
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
            button3.Location = new Point(87, 198);
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
            button2.Location = new Point(87, 122);
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
            button1.Location = new Point(87, 46);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 0;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lbRoundStage);
            flowLayoutPanel1.Controls.Add(dataGridView2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(dataGridView3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(dataGridView4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(dataGridView5);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(802, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(787, 1272);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // lbRoundStage
            // 
            lbRoundStage.AutoSize = true;
            lbRoundStage.BackColor = Color.RoyalBlue;
            lbRoundStage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRoundStage.ForeColor = Color.White;
            lbRoundStage.Location = new Point(3, 0);
            lbRoundStage.Name = "lbRoundStage";
            lbRoundStage.Padding = new Padding(20, 5, 40, 5);
            lbRoundStage.Size = new Size(216, 48);
            lbRoundStage.TabIndex = 0;
            lbRoundStage.Text = "Vòng bảng";
            lbRoundStage.Click += lbRoundStage_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 51);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(762, 331);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 385);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 5, 40, 5);
            label3.Size = new Size(226, 48);
            label3.TabIndex = 4;
            label3.Text = "Vòng tứ kết";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 436);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 72;
            dataGridView3.RowTemplate.Height = 37;
            dataGridView3.Size = new Size(762, 262);
            dataGridView3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 701);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 5, 40, 5);
            label4.Size = new Size(247, 48);
            label4.TabIndex = 6;
            label4.Text = "Vòng bán kết";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(3, 752);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 72;
            dataGridView4.RowTemplate.Height = 37;
            dataGridView4.Size = new Size(762, 262);
            dataGridView4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 1017);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 5, 40, 5);
            label5.Size = new Size(247, 48);
            label5.TabIndex = 8;
            label5.Text = "Vòng bán kết";
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 1068);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 72;
            dataGridView5.RowTemplate.Height = 37;
            dataGridView5.Size = new Size(762, 262);
            dataGridView5.TabIndex = 9;
            // 
            // fRound
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "fRound";
            Text = "fSchedule";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnDelete;
        private Button btnModify;
        private Button btnResearch;
        private Button btnRewrite;
        private Button btnSave;
        private Button btnAdd;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNameRound;
        private TextBox txtIdTour;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbRoundStage;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
        private Label label4;
        private DataGridView dataGridView4;
        private Label label5;
        private DataGridView dataGridView5;
    }
}