namespace GUI
{
    partial class fMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainAdmin));
            panelMenu = new Panel();
            btnAccount = new Button();
            btnRankTour = new Button();
            btnRankRound = new Button();
            btnLogOut = new Button();
            btnRound = new Button();
            btnTeam = new Button();
            btnRegist = new Button();
            btnTournament = new Button();
            panelLogo = new Panel();
            label3 = new Label();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            lbRole = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnRankTour);
            panelMenu.Controls.Add(btnRankRound);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnRound);
            panelMenu.Controls.Add(btnTeam);
            panelMenu.Controls.Add(btnRegist);
            panelMenu.Controls.Add(btnTournament);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(382, 1413);
            panelMenu.TabIndex = 0;
            // 
            // btnAccount
            // 
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.DimGray;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 615);
            btnAccount.Margin = new Padding(10, 3, 3, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(20, 0, 0, 0);
            btnAccount.Size = new Size(382, 80);
            btnAccount.TabIndex = 12;
            btnAccount.TabStop = false;
            btnAccount.Text = " Tài khoản";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnRankTour
            // 
            btnRankTour.Cursor = Cursors.Hand;
            btnRankTour.Dock = DockStyle.Top;
            btnRankTour.FlatAppearance.BorderSize = 0;
            btnRankTour.FlatStyle = FlatStyle.Flat;
            btnRankTour.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnRankTour.ForeColor = Color.DimGray;
            btnRankTour.Image = (Image)resources.GetObject("btnRankTour.Image");
            btnRankTour.ImageAlign = ContentAlignment.MiddleLeft;
            btnRankTour.Location = new Point(0, 535);
            btnRankTour.Margin = new Padding(10, 3, 3, 3);
            btnRankTour.Name = "btnRankTour";
            btnRankTour.Padding = new Padding(20, 0, 0, 0);
            btnRankTour.Size = new Size(382, 80);
            btnRankTour.TabIndex = 11;
            btnRankTour.TabStop = false;
            btnRankTour.Text = " Xếp hạng giải";
            btnRankTour.TextAlign = ContentAlignment.MiddleLeft;
            btnRankTour.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRankTour.UseVisualStyleBackColor = true;
            btnRankTour.Click += btnRankTour_Click;
            // 
            // btnRankRound
            // 
            btnRankRound.Cursor = Cursors.Hand;
            btnRankRound.Dock = DockStyle.Top;
            btnRankRound.FlatAppearance.BorderSize = 0;
            btnRankRound.FlatStyle = FlatStyle.Flat;
            btnRankRound.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnRankRound.ForeColor = Color.DimGray;
            btnRankRound.Image = (Image)resources.GetObject("btnRankRound.Image");
            btnRankRound.ImageAlign = ContentAlignment.MiddleLeft;
            btnRankRound.Location = new Point(0, 455);
            btnRankRound.Margin = new Padding(10, 3, 3, 3);
            btnRankRound.Name = "btnRankRound";
            btnRankRound.Padding = new Padding(20, 0, 0, 0);
            btnRankRound.Size = new Size(382, 80);
            btnRankRound.TabIndex = 10;
            btnRankRound.TabStop = false;
            btnRankRound.Text = " Xếp hạng vòng";
            btnRankRound.TextAlign = ContentAlignment.MiddleLeft;
            btnRankRound.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRankRound.UseVisualStyleBackColor = true;
            btnRankRound.Click += btnRankRound_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.Red;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(0, 1325);
            btnLogOut.Margin = new Padding(0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(10, 0, 0, 0);
            btnLogOut.Size = new Size(382, 88);
            btnLogOut.TabIndex = 7;
            btnLogOut.TabStop = false;
            btnLogOut.Text = " Đăng xuất";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRound
            // 
            btnRound.Cursor = Cursors.Hand;
            btnRound.Dock = DockStyle.Top;
            btnRound.FlatAppearance.BorderSize = 0;
            btnRound.FlatStyle = FlatStyle.Flat;
            btnRound.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnRound.ForeColor = Color.DimGray;
            btnRound.Image = (Image)resources.GetObject("btnRound.Image");
            btnRound.ImageAlign = ContentAlignment.MiddleLeft;
            btnRound.Location = new Point(0, 375);
            btnRound.Margin = new Padding(10, 3, 3, 3);
            btnRound.Name = "btnRound";
            btnRound.Padding = new Padding(20, 0, 0, 0);
            btnRound.Size = new Size(382, 80);
            btnRound.TabIndex = 6;
            btnRound.TabStop = false;
            btnRound.Text = " Lịch thi đấu";
            btnRound.TextAlign = ContentAlignment.MiddleLeft;
            btnRound.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRound.UseVisualStyleBackColor = true;
            btnRound.Click += btnRound_Click;
            // 
            // btnTeam
            // 
            btnTeam.BackColor = Color.Transparent;
            btnTeam.Cursor = Cursors.Hand;
            btnTeam.Dock = DockStyle.Top;
            btnTeam.FlatAppearance.BorderSize = 0;
            btnTeam.FlatStyle = FlatStyle.Flat;
            btnTeam.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeam.ForeColor = Color.DimGray;
            btnTeam.Image = (Image)resources.GetObject("btnTeam.Image");
            btnTeam.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeam.Location = new Point(0, 295);
            btnTeam.Margin = new Padding(10, 3, 3, 3);
            btnTeam.Name = "btnTeam";
            btnTeam.Padding = new Padding(20, 0, 0, 0);
            btnTeam.Size = new Size(382, 80);
            btnTeam.TabIndex = 2;
            btnTeam.TabStop = false;
            btnTeam.Text = " Đội";
            btnTeam.TextAlign = ContentAlignment.MiddleLeft;
            btnTeam.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTeam.UseVisualStyleBackColor = false;
            btnTeam.Click += btnTeam_Click;
            // 
            // btnRegist
            // 
            btnRegist.Cursor = Cursors.Hand;
            btnRegist.Dock = DockStyle.Top;
            btnRegist.FlatAppearance.BorderSize = 0;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegist.ForeColor = Color.DimGray;
            btnRegist.Image = (Image)resources.GetObject("btnRegist.Image");
            btnRegist.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegist.Location = new Point(0, 215);
            btnRegist.Margin = new Padding(10, 3, 3, 3);
            btnRegist.Name = "btnRegist";
            btnRegist.Padding = new Padding(20, 0, 0, 0);
            btnRegist.Size = new Size(382, 80);
            btnRegist.TabIndex = 13;
            btnRegist.TabStop = false;
            btnRegist.Text = " Đăng ký giải";
            btnRegist.TextAlign = ContentAlignment.MiddleLeft;
            btnRegist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegist.UseVisualStyleBackColor = true;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnTournament
            // 
            btnTournament.BackColor = Color.LightGray;
            btnTournament.Cursor = Cursors.Hand;
            btnTournament.Dock = DockStyle.Top;
            btnTournament.FlatAppearance.BorderSize = 0;
            btnTournament.FlatStyle = FlatStyle.Flat;
            btnTournament.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnTournament.ForeColor = Color.RoyalBlue;
            btnTournament.Image = (Image)resources.GetObject("btnTournament.Image");
            btnTournament.ImageAlign = ContentAlignment.MiddleLeft;
            btnTournament.Location = new Point(0, 135);
            btnTournament.Margin = new Padding(10, 3, 3, 3);
            btnTournament.Name = "btnTournament";
            btnTournament.Padding = new Padding(20, 0, 0, 0);
            btnTournament.Size = new Size(382, 80);
            btnTournament.TabIndex = 0;
            btnTournament.TabStop = false;
            btnTournament.Text = " Giải đấu";
            btnTournament.TextAlign = ContentAlignment.MiddleLeft;
            btnTournament.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTournament.UseVisualStyleBackColor = false;
            btnTournament.Click += btnTour_Click;
            // 
            // panelLogo
            // 
            panelLogo.AccessibleDescription = "logo";
            panelLogo.BackColor = Color.RoyalBlue;
            panelLogo.Controls.Add(label3);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(5, 4, 5, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(382, 135);
            panelLogo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 25);
            label3.Name = "label3";
            label3.Size = new Size(239, 79);
            label3.TabIndex = 1;
            label3.Text = "IT APP";
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.Transparent;
            panelDesktop.Location = new Point(385, 131);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1613, 1246);
            panelDesktop.TabIndex = 1;
            panelDesktop.Paint += panelDesktop_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1871, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 88);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbRole.Location = new Point(1715, 41);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(119, 45);
            lbRole.TabIndex = 2;
            lbRole.Text = "Admin";
            // 
            // fMainAdmin
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2001, 1413);
            Controls.Add(lbRole);
            Controls.Add(pictureBox1);
            Controls.Add(panelMenu);
            Controls.Add(panelDesktop);
            Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "fMainAdmin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += fMainAdmin_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Label label3;
        private Button btnTournament;
        private Button btnLogOut;
        private Button btnRound;
        private Button btnTeam;
        private Button btnRankTour;
        private Button btnRankRound;
        private Panel panelDesktop;
        private Button btnAccount;
        private PictureBox pictureBox1;
        private Button btnRegist;
        private Label lbRole;
    }
}