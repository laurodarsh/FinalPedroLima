﻿using System;
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
    public partial class CategoryDetailsForm : Form
    {
        public CategoryDetailsForm()
        {
            InitializeComponent();
        }

       

        private void pbxSave_Click(object sender, EventArgs e)
        {

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            CategoryAllForm categoryallForm = new CategoryAllForm();
            categoryallForm.Show();
            this.Hide();
        }
    }
}
