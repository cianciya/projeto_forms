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
    public partial class Home : Form
    {
        bool sidebarExpand;
        public Home()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            ltwNotification.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "select * from Aviso";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string aviso = (string)dr["Aviso"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(aviso);

                    ltwNotification.Items.Add(lv);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //Se o sidebar estiver espandido, minimizar. 
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                }
            }
        }

        private void menuButon_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cad_User cad_User = new Cad_User();
            cad_User.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro_timer.Start();
        }

        private void cadastro_Tick(object sender, EventArgs e)
        {
            if (panel_Cadastro.Height == 110)
            {
                panel_Cadastro.Height = 36;
            }
            else
            {
                panel_Cadastro.Height = 110;
            }
            cadastro_timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_User search_user = new Search_User();
            search_user.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbTatuador3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();

            int tatuador1ID = GetTatuadorID("Yago");
            int tatuador2ID = GetTatuadorID("Andre");
            int tatuador3ID = GetTatuadorID("Aline");
            int tatuador4ID = GetTatuadorID("Joao");

            if (ckbTatuador1.Checked)
            {
                InsertAviso(sqlCommand, txbNotification.Text, tatuador1ID);
            }

            if (ckbTatuador2.Checked)
            {
                InsertAviso(sqlCommand, txbNotification.Text, tatuador2ID);
            }

            if (ckbTatuador3.Checked)
            {
                InsertAviso(sqlCommand, txbNotification.Text, tatuador3ID);
            }

            if (ckbTatuador4.Checked)
            {
                InsertAviso(sqlCommand, txbNotification.Text, tatuador4ID);
            }

            connection.CloseConnection();

            MessageBox.Show(
                "Aviso inserido",
                "com sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }
        private void InsertAviso(SqlCommand sqlCommand, string aviso, int tatuador)
        {
            sqlCommand.CommandText = @"INSERT INTO Aviso (Aviso, Tatuador) VALUES (@Aviso, @Tatuador)";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Aviso", aviso);
            sqlCommand.Parameters.AddWithValue("@Tatuador", tatuador);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir o Aviso.\n" + err.Message);
            }
        }

        private int GetTatuadorID(string nomeTatuador)
        {
            // Lógica para obter o ID do tatuador com base no nome
            // Aqui você pode fazer uma consulta ao banco de dados para obter o ID correspondente ao nome do tatuador.
            // Vamos supor que você tenha uma função que consulta o banco de dados e retorna o ID correspondente.
            // Neste exemplo, vou retornar IDs fictícios baseados no nome do tatuador.
            if (nomeTatuador == "Yago")
                return 1;
            else if (nomeTatuador == "Andre")
                return 2;
            else if (nomeTatuador == "Aline")
                return 3;
            else if (nomeTatuador == "Joao")
                return 4;

            return -1; // Retorno de valor inválido se não encontrar o tatuador
        }





        private void ckbTatuador4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbTatuador2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbTatuador1_CheckedChanged(object sender, EventArgs e)
        {

        }

         private void lblNotification_Click(object sender, EventArgs e)
         {

         }

         private void txbNotification_TextChanged(object sender, EventArgs e)
         {

         }


    }
}
