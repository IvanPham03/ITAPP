namespace GUI.Forms
{
    partial class fTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTour));
            groupBox1 = new GroupBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin giải đấu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(62, 300);
            label4.Name = "label4";
            label4.Size = new Size(122, 38);
            label4.TabIndex = 7;
            label4.Text = "Kết thúc";
            label4.Click += label4_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.DodgerBlue;
            dateTimePicker2.CalendarMonthBackground = Color.RoyalBlue;
            dateTimePicker2.Location = new Point(237, 303);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(350, 36);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 36);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(62, 147);
            label3.Name = "label3";
            label3.Size = new Size(114, 38);
            label3.TabIndex = 5;
            label3.Text = "Tên giải";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(62, 223);
            label2.Name = "label2";
            label2.Size = new Size(115, 38);
            label2.TabIndex = 3;
            label2.Text = "Bắt đầu";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.DodgerBlue;
            dateTimePicker1.CalendarMonthBackground = Color.RoyalBlue;
            dateTimePicker1.Location = new Point(237, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 36);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 36);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(62, 63);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 1;
            label1.Text = "Mã giải";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 403);
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
            button4.Location = new Point(1201, 277);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(185, 95);
            button4.TabIndex = 20;
            button4.Text = "     Sao            chép      ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.RoyalBlue;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.RoyalBlue;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1392, 277);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(185, 95);
            button5.TabIndex = 19;
            button5.Text = "     Thoát";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.RoyalBlue;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.RoyalBlue;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(1010, 277);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(185, 95);
            button6.TabIndex = 18;
            button6.Text = "     Xóa tất     cả";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.RoyalBlue;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.RoyalBlue;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(1392, 147);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(185, 95);
            button7.TabIndex = 17;
            button7.Text = "     Xóa";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.RoyalBlue;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.RoyalBlue;
            button8.Image = Properties.Resources.plus;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(1010, 21);
            button8.Name = "button8";
            button8.Padding = new Padding(10, 0, 0, 0);
            button8.Size = new Size(185, 95);
            button8.TabIndex = 12;
            button8.Text = "     Thêm";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.RoyalBlue;
            button9.FlatAppearance.BorderSize = 3;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.RoyalBlue;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(1201, 147);
            button9.Name = "button9";
            button9.Padding = new Padding(10, 0, 0, 0);
            button9.Size = new Size(185, 95);
            button9.TabIndex = 16;
            button9.Text = "     Sửa";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.RoyalBlue;
            button10.FlatAppearance.BorderSize = 3;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.RoyalBlue;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(1201, 21);
            button10.Name = "button10";
            button10.Padding = new Padding(10, 0, 0, 0);
            button10.Size = new Size(185, 95);
            button10.TabIndex = 13;
            button10.Text = "     Lưu";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderColor = Color.RoyalBlue;
            button11.FlatAppearance.BorderSize = 3;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.RoyalBlue;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(1010, 147);
            button11.Name = "button11";
            button11.Padding = new Padding(10, 0, 0, 0);
            button11.Size = new Size(185, 95);
            button11.TabIndex = 15;
            button11.Text = "     Tìm ";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderColor = Color.RoyalBlue;
            button12.FlatAppearance.BorderSize = 3;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.RoyalBlue;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(1392, 21);
            button12.Name = "button12";
            button12.Padding = new Padding(10, 0, 0, 0);
            button12.Size = new Size(185, 95);
            button12.TabIndex = 14;
            button12.Text = "     Nhập        lại      ";
            button12.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(664, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 365);
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
            button3.Location = new Point(78, 284);
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
            button2.Location = new Point(78, 157);
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
            button1.Location = new Point(78, 35);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 0;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 397);
            panel3.Name = "panel3";
            panel3.Size = new Size(1584, 863);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1565, 848);
            dataGridView1.TabIndex = 0;
            // 
            // fTour
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fTour";
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
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}