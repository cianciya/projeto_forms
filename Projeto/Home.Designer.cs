﻿namespace Projeto
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButon = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAvulso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.cadastro_timer = new System.Windows.Forms.Timer(this.components);
            this.panel_Cadastro = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButon)).BeginInit();
            this.panel_Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sidebar.Controls.Add(this.pMenu);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Controls.Add(this.panel_Cadastro);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(219, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(66, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(219, 450);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.label1);
            this.pMenu.Controls.Add(this.menuButon);
            this.pMenu.Location = new System.Drawing.Point(3, 3);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(216, 100);
            this.pMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuButon
            // 
            this.menuButon.Image = global::Projeto.Properties.Resources.menu_4_32;
            this.menuButon.Location = new System.Drawing.Point(9, 38);
            this.menuButon.Name = "menuButon";
            this.menuButon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuButon.Size = new System.Drawing.Size(42, 32);
            this.menuButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuButon.TabIndex = 0;
            this.menuButon.TabStop = false;
            this.menuButon.Click += new System.EventHandler(this.menuButon_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Projeto.Properties.Resources.home_5_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 109);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(216, 36);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "             Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::Projeto.Properties.Resources.home_5_32;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(-3, 45);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(216, 37);
            this.btnCadastro.TabIndex = 7;
            this.btnCadastro.Text = "             Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = global::Projeto.Properties.Resources.home_5_32;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(216, 36);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "             Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAvulso
            // 
            this.btnAvulso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvulso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvulso.ForeColor = System.Drawing.Color.White;
            this.btnAvulso.Image = global::Projeto.Properties.Resources.home_5_32;
            this.btnAvulso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvulso.Location = new System.Drawing.Point(-3, 126);
            this.btnAvulso.Name = "btnAvulso";
            this.btnAvulso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAvulso.Size = new System.Drawing.Size(216, 36);
            this.btnAvulso.TabIndex = 3;
            this.btnAvulso.Text = "             Teste";
            this.btnAvulso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvulso.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Projeto.Properties.Resources.home_5_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 88);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(216, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "             Teste";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // cadastro_timer
            // 
            this.cadastro_timer.Interval = 10;
            this.cadastro_timer.Tick += new System.EventHandler(this.cadastro_Tick);
            // 
            // panel_Cadastro
            // 
            this.panel_Cadastro.Controls.Add(this.btnCadastro);
            this.panel_Cadastro.Controls.Add(this.btnAvulso);
            this.panel_Cadastro.Controls.Add(this.button1);
            this.panel_Cadastro.Controls.Add(this.btnCadastrar);
            this.panel_Cadastro.Location = new System.Drawing.Point(3, 151);
            this.panel_Cadastro.MaximumSize = new System.Drawing.Size(216, 172);
            this.panel_Cadastro.MinimumSize = new System.Drawing.Size(216, 45);
            this.panel_Cadastro.Name = "panel_Cadastro";
            this.panel_Cadastro.Size = new System.Drawing.Size(216, 45);
            this.panel_Cadastro.TabIndex = 8;
            this.panel_Cadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Cadastro_Paint_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Name = "Home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButon)).EndInit();
            this.panel_Cadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox menuButon;
        private System.Windows.Forms.Button btnAvulso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Timer cadastro_timer;
        private System.Windows.Forms.Panel panel_Cadastro;
    }
}
