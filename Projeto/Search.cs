using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto
{
    public partial class Search_User : Form
    {
        public Search_User()
        {
            InitializeComponent();

        }

        private void UpdateListView()
        {
            ltvList.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "select * from User_Projeto";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["Nome"];
                    string endereco = (string)dr["Endereco"];
                    string email = (string)dr["Email"];
                    string telefone = (string)dr["Telefone"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(endereco);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(telefone);
                    ltvList.Items.Add(lv);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateListView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void Search_User_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ltvList.SelectedItems.Count > 0)
            {
                ListViewItem lvid = ltvList.SelectedItems[0];
                string sid = lvid.SubItems[0].Text;
                int editarid = Convert.ToInt32(sid);


                Edit_User editar = new Edit_User(editarid);
                editar.ShowDialog();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ltvList.SelectedItems.Count > 0)
            {
                ListViewItem lvid = ltvList.SelectedItems[0];
                string sid = lvid.SubItems[0].Text;
                int editarid = Convert.ToInt32(sid);


                Connection conn = new Connection();
                SqlCommand sqlCom = new SqlCommand();

                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = "DELETE from User_Projeto WHERE id = @id";
                sqlCom.Parameters.AddWithValue("@id", editarid);

                SqlDataReader dr = sqlCom.ExecuteReader();
            }




        }
    }
}
