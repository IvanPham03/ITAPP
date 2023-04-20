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
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class fMainAdmin : Form
    {
        private Button currentButton;
        private Form activeForm;
        public static fLogin login = new fLogin();

        public fMainAdmin()
        {
            InitializeComponent();
            OpenChildForm(new fTour(), btnTournament);
        }

        private void fMainAdmin_Load(object sender, EventArgs e)
        {

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
            /*
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            *//*childForm.Dock = DockStyle.Fill;*//*
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            
            *//* lblTitle.Text = childForm.Text;*/
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            childForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            childForm.BringToFront();
            childForm.Show();
        }





        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        //---click
        private void btnScheduel_Click(object sender, EventArgs e)
        {

        }
        private void btnTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fTour(), sender);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fTeam(), sender);
        }

        private void btnPLayer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fPlayer(), sender);
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fRegist(), sender);
        }


        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fSchedule(), sender);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fRound(), sender);
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fMatch(), sender);
        }

        private void btnParticipate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fParticipant(), sender);
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
    }
}

