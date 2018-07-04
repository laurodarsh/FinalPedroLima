using System;
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
    public partial class UserAllForm : Form
    {

        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";

        public UserAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
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

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT [USER].ID, [USER].NAME, [USER].PASSWORD, [USER].EMAIL, [USER].ACTIVE, USER_PROFILE.NAME FROM [USER] INNER JOIN USER_PROFILE ON [USER].FK_USERPROFILE = USER_PROFILE.ID;", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUser.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            dgvUser.Columns["PASSWORD"].Visible = false;
            dgvUser.Columns["EMAIL"].HeaderText = "Email";
            dgvUser.Columns["NAME1"].HeaderText = "Perfil";
            dgvUser.Columns["ACTIVE"].HeaderText = "Ativo";

            dgvUser.Columns["ACTIVE"].DisplayIndex = 5;

            dgvUser.Columns["NAME1"].DisplayIndex = 4;

            foreach (DataGridViewColumn col in dgvUser.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Perfil de Usuario inativo!");
                ShowData();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este perfil de usuario!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }

        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {

            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            UserDetailsForm userDetails = new UserDetailsForm(idUser);
            userDetails.Show();

            this.Close();


        }
    }
    }

