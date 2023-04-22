using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class fSettingAdmin : Form
    {
        public fSettingAdmin()
        {
            InitializeComponent();
        }

        private void fSettingAdmin_Load(object sender, EventArgs e)
        {

        }
        public void LoadListAccount()
        {
           /* dgvAccount.DataSource = AccountBus.Instance.LoadAccount();
            dgvAccount.DefaultCellStyle.Font = new Font("", 12);*/
        }
    }
}
