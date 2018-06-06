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
    public partial class ProductDetailsForm : Form
    {
        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        string name = "";
        float price = 0;
        string category = "";
        bool active = false ;

        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            category = cbmCategory.Text;
            
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
            tbxPrice.Text = "";
            cbmCategory.SelectedIndex = 0;
            cbxActive.Checked = false;

        }
        

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm productallForm = new ProductAllForm();
            productallForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

        }

        
    }
}
