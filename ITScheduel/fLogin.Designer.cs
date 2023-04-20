namespace ITScheduel
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            btnEye = new Button();
            btnCloseLogin = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnEye);
            panel1.Controls.Add(btnCloseLogin);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 636);
            panel1.TabIndex = 2;
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.White;
            btnEye.Cursor = Cursors.Hand;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEye.FlatAppearance.MouseOverBackColor = Color.White;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.ForeColor = SystemColors.InfoText;
            btnEye.Image = (Image)resources.GetObject("btnEye.Image");
            btnEye.Location = new Point(771, 343);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(55, 44);
            btnEye.TabIndex = 8;
            btnEye.TabStop = false;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.MouseDown += btnEye_Click_Down;
            btnEye.MouseUp += btnEye_Click_Leave;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.AutoSize = true;
            btnCloseLogin.BackColor = Color.White;
            btnCloseLogin.Cursor = Cursors.Hand;
            btnCloseLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseLogin.ForeColor = Color.Crimson;
            btnCloseLogin.Location = new Point(205, 438);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(266, 61);
            btnCloseLogin.TabIndex = 4;
            btnCloseLogin.Text = "Thoát";
            btnCloseLogin.UseVisualStyleBackColor = false;
            btnCloseLogin.Click += btnClose;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.RoyalBlue;
            btnLogin.Location = new Point(560, 438);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(266, 61);
            btnLogin.TabIndex = 3;
            btnLogin.Tag = "0";
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(205, 343);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Nhập mật khẩu...";
            txtPassword.Size = new Size(572, 44);
            txtPassword.TabIndex = 2;
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(204, 219);
            txtPhoneNumber.Margin = new Padding(10, 3, 3, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Nhập số điện thoại....";
            txtPhoneNumber.Size = new Size(622, 44);
            txtPhoneNumber.TabIndex = 1;
            txtPhoneNumber.Tag = "";
            txtPhoneNumber.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(200, 303);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(198, 181);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Arial Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(414, 36);
            label1.Name = "label1";
            label1.Size = new Size(239, 79);
            label1.TabIndex = 0;
            label1.Text = "IT APP";
            label1.Click += label1_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1029, 636);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "1";
            Text = "Đăng nhập";
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCloseLogin;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtPhoneNumber;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEye;
    }
}