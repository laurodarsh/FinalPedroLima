﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";
        string name = "";
        bool active = false;


        void GetData()
        {
            name = tbxName.Text;
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
            cbxActive.Checked = false;

        }




        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userprofileallForm = new UserProfileAllForm();
            userprofileallForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                sqlConnect.Open();
                string sql = "INSERT INTO USER_PROFILE(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@active", active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");

                CleanData();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao adicionar perfil!" + ex.Message);
                CleanData();

            }

            finally
            {

                sqlConnect.Close();

            }

        }
    }
}
