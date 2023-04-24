namespace GUI.Forms
{
    partial class fPopupRegist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPopupRegist));
            btnRegist = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label4 = new Label();
            cbIdTour = new ComboBox();
            cbNameTour = new ComboBox();
            label2 = new Label();
            dtpEnd = new DateTimePicker();
            label5 = new Label();
            dtpStart = new DateTimePicker();
            SuspendLayout();
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.Transparent;
            btnRegist.Cursor = Cursors.Hand;
            btnRegist.Enabled = false;
            btnRegist.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnRegist.FlatAppearance.BorderSize = 3;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegist.ForeColor = Color.RoyalBlue;
            btnRegist.Image = (Image)resources.GetObject("btnRegist.Image");
            btnRegist.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegist.Location = new Point(281, 368);
            btnRegist.Name = "btnRegist";
            btnRegist.Padding = new Padding(10, 0, 0, 0);
            btnRegist.Size = new Size(236, 71);
            btnRegist.TabIndex = 30;
            btnRegist.Text = "    Đăng ký";
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.RoyalBlue;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(551, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 0, 0);
            btnCancel.Size = new Size(236, 71);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "    Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(66, 28);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 9;
            label1.Text = "Mã giải";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(66, 107);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 13;
            label4.Text = "Tên giải";
            // 
            // cbIdTour
            // 
            cbIdTour.FormattingEnabled = true;
            cbIdTour.Location = new Point(281, 28);
            cbIdTour.Name = "cbIdTour";
            cbIdTour.Size = new Size(506, 38);
            cbIdTour.TabIndex = 14;
            cbIdTour.SelectedIndexChanged += AutoChange_ID;
            // 
            // cbNameTour
            // 
            cbNameTour.Enabled = false;
            cbNameTour.FormattingEnabled = true;
            cbNameTour.Location = new Point(281, 107);
            cbNameTour.Name = "cbNameTour";
            cbNameTour.Size = new Size(506, 38);
            cbNameTour.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(66, 282);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 39;
            label2.Text = "Kết thúc";
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarForeColor = Color.DodgerBlue;
            dtpEnd.CalendarMonthBackground = Color.RoyalBlue;
            dtpEnd.Enabled = false;
            dtpEnd.Location = new Point(281, 282);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(506, 35);
            dtpEnd.TabIndex = 33;
            dtpEnd.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(70, 196);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 36;
            label5.Text = "Bắt đầu";
            // 
            // dtpStart
            // 
            dtpStart.CalendarForeColor = Color.DodgerBlue;
            dtpStart.CalendarMonthBackground = Color.RoyalBlue;
            dtpStart.Enabled = false;
            dtpStart.Location = new Point(281, 196);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(506, 35);
            dtpStart.TabIndex = 34;
            dtpStart.TabStop = false;
            // 
            // fPopupRegist
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 486);
            Controls.Add(label2);
            Controls.Add(dtpEnd);
            Controls.Add(label5);
            Controls.Add(dtpStart);
            Controls.Add(btnCancel);
            Controls.Add(btnRegist);
            Controls.Add(cbNameTour);
            Controls.Add(cbIdTour);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "fPopupRegist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký giải";
            Load += fPopupRegist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegist;
        private Button btnCancel;
        private Label label1;
        private Label label4;
        private ComboBox cbIdTour;
        private ComboBox cbNameTour;
        private Label label2;
        private DateTimePicker dtpEnd;
        private Label label5;
        private DateTimePicker dtpStart;
    }
}