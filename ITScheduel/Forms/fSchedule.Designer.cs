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
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnCopy = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            btnBack = new Button();
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
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin trận đấu";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(167, 71);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(356, 38);
            comboBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(167, 157);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(356, 38);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(356, 38);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(18, 339);
            label4.Name = "label4";
            label4.Size = new Size(123, 38);
            label4.TabIndex = 9;
            label4.Text = "Lịch đấu";
            // 
            // dtpDate
            // 
            dtpDate.CalendarForeColor = Color.DodgerBlue;
            dtpDate.CalendarMonthBackground = Color.RoyalBlue;
            dtpDate.Location = new Point(170, 337);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(356, 36);
            dtpDate.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(15, 242);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 7;
            label2.Text = "Mã trận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(15, 153);
            label3.Name = "label3";
            label3.Size = new Size(131, 38);
            label3.TabIndex = 5;
            label3.Text = "Mã đội 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(15, 67);
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
            panel1.Size = new Size(1592, 464);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCopy);
            groupBox3.Controls.Add(btnCancel);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnBack);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(1100, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(477, 425);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
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
            btnCopy.Location = new Point(255, 295);
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
            btnCancel.Location = new Point(38, 295);
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
            btnDelete.Location = new Point(255, 169);
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
            btnAdd.Location = new Point(38, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(185, 95);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "     Thêm";
            btnAdd.UseVisualStyleBackColor = false;
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
            btnSave.Location = new Point(255, 49);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(185, 95);
            btnSave.TabIndex = 23;
            btnSave.Text = "     Lưu";
            btnSave.UseVisualStyleBackColor = false;
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
            btnBack.Location = new Point(38, 169);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(10, 0, 0, 0);
            btnBack.Size = new Size(185, 95);
            btnBack.TabIndex = 24;
            btnBack.Text = "      Nhập         lại      ";
            btnBack.UseVisualStyleBackColor = false;
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
            groupBox2.Location = new Point(550, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 425);
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
            label8.Location = new Point(458, 356);
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
            label9.Location = new Point(458, 261);
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
            label10.Location = new Point(458, 173);
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
            label11.Location = new Point(458, 91);
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
            label7.Location = new Point(193, 351);
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
            label6.Location = new Point(193, 257);
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
            label5.Location = new Point(193, 173);
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
            label13.Location = new Point(193, 91);
            label13.Name = "label13";
            label13.Size = new Size(60, 30);
            label13.TabIndex = 18;
            label13.Text = "(*Số)";
            // 
            // txtCardRed2
            // 
            txtCardRed2.Location = new Point(303, 354);
            txtCardRed2.Name = "txtCardRed2";
            txtCardRed2.PlaceholderText = "Số điểm 1";
            txtCardRed2.Size = new Size(129, 36);
            txtCardRed2.TabIndex = 17;
            // 
            // txtCardYellow2
            // 
            txtCardYellow2.Location = new Point(31, 350);
            txtCardYellow2.Name = "txtCardYellow2";
            txtCardYellow2.PlaceholderText = "Thẻ vàng 2";
            txtCardYellow2.Size = new Size(129, 36);
            txtCardYellow2.TabIndex = 16;
            // 
            // txtCardRed1
            // 
            txtCardRed1.Location = new Point(301, 259);
            txtCardRed1.Name = "txtCardRed1";
            txtCardRed1.PlaceholderText = "Số điểm 1";
            txtCardRed1.Size = new Size(129, 36);
            txtCardRed1.TabIndex = 15;
            // 
            // txtCardYellow1
            // 
            txtCardYellow1.Location = new Point(31, 257);
            txtCardYellow1.Name = "txtCardYellow1";
            txtCardYellow1.PlaceholderText = "Thẻ vàng 1";
            txtCardYellow1.Size = new Size(129, 36);
            txtCardYellow1.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 169);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Thẻ đỏ 2";
            textBox3.Size = new Size(129, 36);
            textBox3.TabIndex = 13;
            // 
            // txtWin2
            // 
            txtWin2.Location = new Point(31, 171);
            txtWin2.Name = "txtWin2";
            txtWin2.PlaceholderText = "Bàn thắng 2";
            txtWin2.Size = new Size(129, 36);
            txtWin2.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 83);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Thẻ đỏ 1";
            textBox2.Size = new Size(129, 36);
            textBox2.TabIndex = 11;
            // 
            // txtWin1
            // 
            txtWin1.Location = new Point(31, 85);
            txtWin1.Name = "txtWin1";
            txtWin1.PlaceholderText = "Bàn thắng 1";
            txtWin1.Size = new Size(129, 36);
            txtWin1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 453);
            panel3.Name = "panel3";
            panel3.Size = new Size(1592, 822);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1565, 816);
            dataGridView1.TabIndex = 0;
            // 
            // fSchedule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fSchedule";
            Text = "fSchedule";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox2;
        private Panel panel3;
        private DataGridView dataGridView1;
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
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private Button btnCopy;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSave;
        private Button btnBack;
    }
}