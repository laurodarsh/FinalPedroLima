using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetofinalPedroLima.Forms
{
    public partial class UserAllForm : Form
    {
        public UserAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm userDetailsForm = new UserDetailsForm();
            userDetailsForm.Show();
            this.Hide();
        }
    }
}
