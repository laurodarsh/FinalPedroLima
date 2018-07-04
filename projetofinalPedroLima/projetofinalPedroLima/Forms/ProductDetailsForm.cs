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
    public partial class ProductDetailsForm : Form
    {
        public ProductDetailsForm()
        {
            InitializeComponent();
            cbmCategory.DisplayMember = "NAME";
            LoadComboBox();
        }

        private void InitializeComboBox(ComboBox cbmCategory, int indexCombo)
        {
            cbmCategory.Items.Add("Selecione.. ");
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);

                using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                {
                    while (reader.Read())
                    {
                        cbmCategory.Items.Add(reader["NAME"].ToString());
                    }
                }

                cbmCategory.SelectedItem = cbmCategory.Items[indexCombo];
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro de acesso ao banco de dados. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }


        public ProductDetailsForm(int idProduct)
        {

            InitializeComponent();

            lblId.Text = idProduct.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idProduct));

                    Product product = new Product(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            product.Id = Int32.Parse(reader["ID"].ToString());
                            product.Name = reader["NAME"].ToString();
                            product.Active = bool.Parse(reader["ACTIVE"].ToString());
                            product.Price = float.Parse(reader["PRICE"].ToString());

                            int indexCombo = 0;
                            if (product.Category != null)
                            {
                                indexCombo = product.Category.Id;
                            }

                            //Inicializa o dropDown com as informações do banco
                            InitializeComboBox(cbmCategory, indexCombo);

                        }
                    }

                    tbxName.Text = product.Name;
                    tbxPrice.Text = product.Price.ToString();
                    cbxActive.Checked = product.Active;


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

        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    categories.Add(c);
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
            foreach (Category c in categories)
            {
                cbmCategory.Items.Add(c);
            }
        }

        string name = "";
        float price = 0;
        string category = "";
        bool active = false;
        List<Category> categories = new List<Category>();

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

        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm productallForm = new ProductAllForm();
            productallForm.Show();
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
                    string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@category", ((Category)cbmCategory.SelectedItem).Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    CleanData();

                }
                catch (Exception ex)
                {
                    //Tratar exceções
                    MessageBox.Show("Erro ao adicionar produto!" + ex.Message);
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
                    string sql = "UPDATE CATEGORY SET NAME = @name, ACTIVE = @active PRICE = @price, FK_PRODUCT = @fk_product, Where ID = @id ";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", this.tbxName.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", this.cbxActive.Checked));
                    cmd.Parameters.Add(new SqlParameter("@price", this.tbxPrice.Text));

                    cmd.Parameters.Add(new SqlParameter("@fk_product", ((Category)cbmCategory.SelectedItem).Id));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Alterações salvas com sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
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
                    string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", Int32.Parse(lblId.Text)));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto inativo!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este produto!" + "\n\n" + Ex.Message);
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
