using DTO;
using GUI.Forms;
using ITScheduel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class fMainAdmin : Form
    {
        private Button currentButton;
        private Form activeForm;
        public static fLogin login = new fLogin();
        public string strRole;
        private string permissionRole;

        public fMainAdmin()
        {
            InitializeComponent();
            OpenChildForm(new fTour(this), btnTournament);
        }

        private void fMainAdmin_Load(object sender, EventArgs e)
        {
            permissionRole = strRole;
        }
        public string Message
        {
            get { return strRole; }
            set { strRole = value; }
        }


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.RoyalBlue;
                    currentButton.BackColor = Color.LightGray;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    if (previousBtn.Name != "btnLogOut")
                    {
                        previousBtn.ForeColor = Color.DimGray;
                        previousBtn.BackColor = Color.Transparent;
                    }
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            childForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            childForm.BringToFront();
            childForm.Show();
        }
        //---click
        private void btnTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fTour(this), sender);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fTeam(), sender);
        }


        private void btnRound_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fRound(), sender);
        }

        private void btnRankRound_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fRankRound(), sender);
        }

        private void btnRankTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fRankTour(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (permissionRole.Equals("admin"))
            {
                OpenChildForm(new Forms.fSettingAdmin(this), sender);
                }
             else
            {
                 OpenChildForm(new Forms.fSettingOther(), sender);
             }
        }
        // =============load data


        private void panelDesktop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fRegist(), sender);
        }
    }
}

