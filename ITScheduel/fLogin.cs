using BUS;
using DTO;
using GUI;
using System.Data;
using System.Diagnostics;

namespace ITScheduel
{

    public partial class fLogin : Form
    {
        public static fMainAdmin mainAdmin = new fMainAdmin();

        public fLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.PHONENUMBER = txtPhoneNumber.Text;
            userDTO.PASSWORD = txtPassword.Text;
            string result = (string)UserBus.Instance.Login(userDTO);
            mainAdmin.Message = result;
            if (!string.IsNullOrEmpty(result))
            {
                this.Hide();
                mainAdmin.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập không chính xác!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnEye_Click_Down(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnEye_Click_Leave(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}