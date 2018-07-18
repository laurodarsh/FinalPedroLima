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

        private void InitializeComboBox(ComboBox cmbProfile, int indexCombo)
        {
            cmbProfile.Items.Add("Selecione.. ");
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);

                using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                {
                    while (reader.Read())
                    {
                        UserProfile userprofile = new UserProfile(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                        cmbProfile.Items.Add(userprofile);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro de acesso ao perfil de usuario. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }
        
        public UserDetailsForm(int idUser)
        {

            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            lblId.Text = idUser.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Password = reader["PASSWORD"].ToString();
                            user.Email = reader["EMAIL"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());

                            user.Userprofile = new UserProfile
                            {
                                Id = Int32.Parse(reader["FK_USERPROFILE"].ToString())
                            };
                        }
                    }

                    tbxName.Text = user.Name;
                    tbxPassword.Text = user.Password;
                    tbxEmail.Text = user.Email;
                    cbxActive.Checked = user.Active;

                    int indexCombo = 0;

                    if (user.Userprofile != null)
                    {
                        indexCombo = user.Userprofile.Id;
                    }

                    //Inicializa o dropDown com as informações do banco
                    InitializeComboBox(cmbProfile, indexCombo);


                }
                catch (Exception EX)
                {
                    //Tratar exce??es
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
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
            if (string.IsNullOrEmpty(lblId.Text))
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
                Log.SalvarLog("Usuario Adicionado", "Adição", DateTime.Now);

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
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET NAME = @name, PASSWORD = @password, EMAIL = @email, ACTIVE = @active, FK_USERPROFILE = @fk_userprofile Where ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", this.tbxName.Text));
                    cmd.Parameters.Add(new SqlParameter("@password", this.tbxPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", this.tbxEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", this.cbxActive.Checked));

                    cmd.Parameters.Add(new SqlParameter("@fk_userprofile", ((UserProfile)cmbProfile.SelectedItem).Id));
                    cmd.Parameters.Add(new SqlParameter("@id", this.lblId.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Alterações salvas com sucesso!");
                    Log.SalvarLog("Produto Editado", "Edição", DateTime.Now);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este usuario!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    UserAllForm userAllForm = new UserAllForm();
                    userAllForm.Show();
                    this.Hide();
                }
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(lblId.Text)) //-----
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", Int32.Parse(lblId.Text)));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario inativo!");
                    Log.SalvarLog("Usuario Excluido", "Exclusão", DateTime.Now);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este usuario!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }

        }
    }
}
