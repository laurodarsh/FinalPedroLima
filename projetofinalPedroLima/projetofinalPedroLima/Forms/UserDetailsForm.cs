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
    public partial class UserDetailsForm : Form
    {
        public UserDetailsForm()
        {
            InitializeComponent();
        }

        string name = "";
        string email = "";
        string password = "";
        string conf = "";
        string profile = "";
        bool active = false;

        void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            profile = cmbProfile.Text;
            conf = tbxConf.Text;


            if (cbxActive.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }
        }
        void CleanData()
        {

            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConf.Text = "";
            cmbProfile.SelectedIndex = 0;
            cbxActive.Checked = false;
        } 


        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm userallForm = new UserAllForm();
            userallForm.Show();
            this.Hide();

        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

        }
    }
}
