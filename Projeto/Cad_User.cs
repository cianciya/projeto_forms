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
using System.Xml.Linq;

namespace Projeto
{
    public partial class Cad_User : Form
    {
        public Cad_User()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO User_Projeto VALUES 
            (@Name, @Endereco, @Email, @Telefone)";

            sqlCommand.Parameters.AddWithValue("@Name", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@Endereco", txbEndereco.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", txbPhone.Text);            

            try
            {
                //Insere o cliente
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            MessageBox.Show(
                "Cadastrado com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            txbEndereco.Clear();
            txbEmail.Clear();
            txbPhone.Clear();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
