using projetofinalPedroLima.Classes;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        public HomeForm(User aux)
        {
            InitializeComponent();
            if (aux.UserProfile.Id != 1)
            {
                pbxLog.Visible = false;
                pbxUser.Visible = false;
                pbxUserProfile.Visible = false;
                
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ProductAllForm productallForm = new ProductAllForm();
            productallForm.Show();
           

        }

        private void pbxProduto_MouseEnter(object sender, EventArgs e)
        {

            pbxProduto.BackColor = Color.Aquamarine;
            lblProduct.Visible = true;
        }

        private void pbxProduto_MouseLeave(object sender, EventArgs e)
        {
            pbxProduto.BackColor = Color.Transparent;
            lblProduct.Visible = false;
        }

        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Aquamarine;
            lblCategory.Visible = true;
        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Transparent;
            lblCategory.Visible = false;

        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.Aquamarine;
            lblUserProfile.Visible = true;

        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        { 
            pbxUserProfile.BackColor = Color.Transparent;
            lblUserProfile.Visible = false;

        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Aquamarine;
            lblUser.Visible = true;

        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Transparent;
            lblUser.Visible = false;
        }

        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Aquamarine;
            lblLog.Visible = true;

        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Transparent;
            lblLog.Visible = false;
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {

            CategoryAllForm categoryallForm = new CategoryAllForm();
            categoryallForm.Show();
            

        }

        private void pbxUser_Click(object sender, EventArgs e)
        {

            UserAllForm userallForm = new UserAllForm();
            userallForm.Show();
            

        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {

            UserProfileAllForm userprofileallForm = new UserProfileAllForm();
            userprofileallForm.Show();
            

        }

        private void pbxLog_Click(object sender, EventArgs e)
        {


            LogForm logForm = new LogForm();
            logForm.Show();
            

        }

        
    }
}
