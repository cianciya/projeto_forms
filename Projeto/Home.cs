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

namespace Projeto
{
    public partial class Home : Form
    {
        bool sidebarExpand;
        public Home()
        {
            InitializeComponent();
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
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
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
    }
}
