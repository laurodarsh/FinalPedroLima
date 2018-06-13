using projetofinalPedroLima.Classes;
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
    public partial class UserDetailsForm : Form
    {
        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }
        List<UserProfile> profiles = new List<UserProfile>();

        string name = "";
        string email = "";
        string password = "";
        string conf = "";
        string profile = "";
        bool active = false;
        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";

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

        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile userprofile = new UserProfile(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    profiles.Add(userprofile);
                }
            }
            catch (Exception ex)
            {
                //Erro ao carregar banco
            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile c in profiles)
            {
                cmbProfile.Items.Add(c);
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm userallForm = new UserAllForm();
            userallForm.Show();
            this.Hide();

        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                //Conectar
                sqlConnect.Open();
                string sql = "INSERT INTO [USER](NAME, PASSWORD , EMAIL, ACTIVE ,FK_USERPROFILE) VALUES (@name, @password, @email, @active, @userprofile)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                cmd.Parameters.Add(new SqlParameter("@userprofile", ((UserProfile)cmbProfile.SelectedItem).Id));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();

            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar usuario!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();

            }

        }
    }
}
