namespace GUI.Forms
{
    partial class fRankRound
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
            groupBox1 = new GroupBox();
            rdD = new RadioButton();
            rdC = new RadioButton();
            rdB = new RadioButton();
            rdA = new RadioButton();
            cbbRoundName = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(1591, 972);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1565, 1095);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(rdD);
            groupBox1.Controls.Add(rdC);
            groupBox1.Controls.Add(rdB);
            groupBox1.Controls.Add(rdA);
            groupBox1.Controls.Add(cbbRoundName);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1565, 197);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vòng đấu";
            // 
            // rdD
            // 
            rdD.AutoSize = true;
            rdD.Location = new Point(1377, 125);
            rdD.Name = "rdD";
            rdD.Size = new Size(108, 34);
            rdD.TabIndex = 13;
            rdD.TabStop = true;
            rdD.Text = "Bảng D";
            rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            rdC.AutoSize = true;
            rdC.Location = new Point(1243, 125);
            rdC.Name = "rdC";
            rdC.Size = new Size(106, 34);
            rdC.TabIndex = 12;
            rdC.TabStop = true;
            rdC.Text = "Bảng C";
            rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            rdB.AutoSize = true;
            rdB.Location = new Point(1093, 125);
            rdB.Name = "rdB";
            rdB.Size = new Size(106, 34);
            rdB.TabIndex = 11;
            rdB.TabStop = true;
            rdB.Text = "Bảng B";
            rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            rdA.AutoSize = true;
            rdA.Location = new Point(935, 125);
            rdA.Name = "rdA";
            rdA.Size = new Size(107, 34);
            rdA.TabIndex = 10;
            rdA.TabStop = true;
            rdA.Text = "Bảng A";
            rdA.UseVisualStyleBackColor = true;
            // 
            // cbbRoundName
            // 
            cbbRoundName.FormattingEnabled = true;
            cbbRoundName.Items.AddRange(new object[] { "Vòng bảng", "Vòng tứ kết", "Vòng bán kết", "Vòng chung kết" });
            cbbRoundName.Location = new Point(937, 55);
            cbbRoundName.Name = "cbbRoundName";
            cbbRoundName.Size = new Size(548, 38);
            cbbRoundName.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(554, 38);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(799, 48);
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
            label2.Location = new Point(15, 50);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 3;
            label2.Text = "Mã giải";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(0, 4);
            label3.Name = "label3";
            label3.Size = new Size(496, 65);
            label3.TabIndex = 34;
            label3.Text = "Kết quả xếp vòng đấu";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(554, 38);
            comboBox2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(15, 121);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 14;
            label4.Text = "Tên giải";
            // 
            // fRankRound
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1589, 1272);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Name = "fRankRound";
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
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox cbbRoundName;
        private Label label3;
        private RadioButton rdD;
        private RadioButton rdC;
        private RadioButton rdB;
        private RadioButton rdA;
        private ComboBox comboBox2;
        private Label label4;
    }
}