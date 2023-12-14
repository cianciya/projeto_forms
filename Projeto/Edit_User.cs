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

namespace Projeto
{
    public partial class Edit_User : Form
    {
        private int edit;
        public Edit_User(int editaraid)
        {
            edit = editaraid;

            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE User_Projeto SET
            Nome = @Name,
            Endereco = @Endereco,
            Email = @Email,
            Telefone = @Telefone
            WHERE Id = @Id";

            sqlCommand.Parameters.AddWithValue("@Name", txbname.Text);
            sqlCommand.Parameters.AddWithValue("@Endereco", txbendereco.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", txbphone.Text);
            sqlCommand.Parameters.AddWithValue("@Id", edit);

            try
            {
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Atualizado com Sucesso", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception err)
            {
                MessageBox.Show("Erro: Problemas ao editar usuário no banco \n" + err.Message);
            }

            finally
            {
                connection.CloseConnection();
            }
            this.Close();
        }

        private void Edit_User_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT * FROM  User_Projeto WHERE id = @id";
            sqlCom.Parameters.AddWithValue("@id", edit);
            using (SqlDataReader dr = sqlCom.ExecuteReader())
            {
                if (dr.Read())
                {
                    txbname.Text = dr["Nome"].ToString();
                    txbendereco.Text = dr["Endereco"].ToString();
                    txbemail.Text = dr["Email"].ToString();
                    txbphone.Text = dr["Telefone"].ToString();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
      
}
