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
    public partial class UserProfileDetailsForm : Form
    {
        public UserProfileDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userprofileallForm = new UserProfileAllForm();
            userprofileallForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

        }
    }
}
