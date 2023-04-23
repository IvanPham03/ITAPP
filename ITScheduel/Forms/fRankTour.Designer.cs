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
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(1592, 1018);
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
            dataGridView1.Size = new Size(1565, 1079);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(595, 65);
            label1.TabIndex = 33;
            label1.Text = "Kết quả xếp hạng giải đấu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1565, 137);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin giải đấu";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(937, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(530, 38);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(530, 38);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(799, 55);
            label2.Name = "label2";
            label2.Size = new Size(114, 38);
            label2.TabIndex = 2;
            label2.Text = "Tên giải";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(15, 55);
            label3.Name = "label3";
            label3.Size = new Size(112, 38);
            label3.TabIndex = 3;
            label3.Text = "Mã giải";
            // 
            // fRankTour
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Name = "fRankTour";
            Text = "fSchedule";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
    }
}