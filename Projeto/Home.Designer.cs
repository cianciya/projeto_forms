namespace Projeto
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
            this.panel_Cadastro = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.cadastro_timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.ckbTatuador4 = new System.Windows.Forms.CheckBox();
            this.ckbTatuador3 = new System.Windows.Forms.CheckBox();
            this.ckbTatuador2 = new System.Windows.Forms.CheckBox();
            this.ckbTatuador1 = new System.Windows.Forms.CheckBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.txbNotification = new System.Windows.Forms.TextBox();
            this.ltwNotification = new System.Windows.Forms.ListView();
            this.sidebar.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButon)).BeginInit();
            this.panel_Cadastro.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlNotification.SuspendLayout();
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
            this.sidebar.Size = new System.Drawing.Size(219, 517);
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel_Cadastro
            // 
            this.panel_Cadastro.Controls.Add(this.btnCadastro);
            this.panel_Cadastro.Controls.Add(this.btnCadastrar);
            this.panel_Cadastro.Controls.Add(this.button1);
            this.panel_Cadastro.Location = new System.Drawing.Point(3, 151);
            this.panel_Cadastro.MaximumSize = new System.Drawing.Size(216, 110);
            this.panel_Cadastro.MinimumSize = new System.Drawing.Size(216, 36);
            this.panel_Cadastro.Name = "panel_Cadastro";
            this.panel_Cadastro.Size = new System.Drawing.Size(216, 110);
            this.panel_Cadastro.TabIndex = 8;
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::Projeto.Properties.Resources.user_32;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(-2, -1);
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
            this.btnCadastrar.Image = global::Projeto.Properties.Resources.add_user_32;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(-1, 36);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(216, 40);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "             Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Projeto.Properties.Resources.home_5_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, 72);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlNotification, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ltwNotification, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1378, 505);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlNotification
            // 
            this.pnlNotification.Controls.Add(this.btnSend);
            this.pnlNotification.Controls.Add(this.ckbTatuador4);
            this.pnlNotification.Controls.Add(this.ckbTatuador3);
            this.pnlNotification.Controls.Add(this.ckbTatuador2);
            this.pnlNotification.Controls.Add(this.ckbTatuador1);
            this.pnlNotification.Controls.Add(this.lblNotification);
            this.pnlNotification.Controls.Add(this.txbNotification);
            this.pnlNotification.Location = new System.Drawing.Point(3, 3);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(683, 242);
            this.pnlNotification.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(294, 185);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 44);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ckbTatuador4
            // 
            this.ckbTatuador4.AutoSize = true;
            this.ckbTatuador4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ckbTatuador4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTatuador4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbTatuador4.Location = new System.Drawing.Point(458, 154);
            this.ckbTatuador4.Name = "ckbTatuador4";
            this.ckbTatuador4.Size = new System.Drawing.Size(61, 25);
            this.ckbTatuador4.TabIndex = 5;
            this.ckbTatuador4.Text = "João";
            this.ckbTatuador4.UseVisualStyleBackColor = false;
            this.ckbTatuador4.CheckedChanged += new System.EventHandler(this.ckbTatuador4_CheckedChanged);
            // 
            // ckbTatuador3
            // 
            this.ckbTatuador3.AutoSize = true;
            this.ckbTatuador3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ckbTatuador3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTatuador3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbTatuador3.Location = new System.Drawing.Point(350, 154);
            this.ckbTatuador3.Name = "ckbTatuador3";
            this.ckbTatuador3.Size = new System.Drawing.Size(64, 25);
            this.ckbTatuador3.TabIndex = 4;
            this.ckbTatuador3.Text = "Aline";
            this.ckbTatuador3.UseVisualStyleBackColor = false;
            this.ckbTatuador3.CheckedChanged += new System.EventHandler(this.ckbTatuador3_CheckedChanged);
            // 
            // ckbTatuador2
            // 
            this.ckbTatuador2.AutoSize = true;
            this.ckbTatuador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ckbTatuador2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTatuador2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbTatuador2.Location = new System.Drawing.Point(242, 154);
            this.ckbTatuador2.Name = "ckbTatuador2";
            this.ckbTatuador2.Size = new System.Drawing.Size(71, 25);
            this.ckbTatuador2.TabIndex = 3;
            this.ckbTatuador2.Text = "Andre";
            this.ckbTatuador2.UseVisualStyleBackColor = false;
            this.ckbTatuador2.CheckedChanged += new System.EventHandler(this.ckbTatuador2_CheckedChanged);
            // 
            // ckbTatuador1
            // 
            this.ckbTatuador1.AutoSize = true;
            this.ckbTatuador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ckbTatuador1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTatuador1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbTatuador1.Location = new System.Drawing.Point(134, 152);
            this.ckbTatuador1.Name = "ckbTatuador1";
            this.ckbTatuador1.Size = new System.Drawing.Size(63, 25);
            this.ckbTatuador1.TabIndex = 2;
            this.ckbTatuador1.Text = "Yago";
            this.ckbTatuador1.UseVisualStyleBackColor = false;
            this.ckbTatuador1.CheckedChanged += new System.EventHandler(this.ckbTatuador1_CheckedChanged);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotification.Location = new System.Drawing.Point(297, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(72, 30);
            this.lblNotification.TabIndex = 1;
            this.lblNotification.Text = "Avisos";
            this.lblNotification.Click += new System.EventHandler(this.lblNotification_Click);
            // 
            // txbNotification
            // 
            this.txbNotification.Location = new System.Drawing.Point(134, 39);
            this.txbNotification.Multiline = true;
            this.txbNotification.Name = "txbNotification";
            this.txbNotification.Size = new System.Drawing.Size(417, 107);
            this.txbNotification.TabIndex = 0;
            this.txbNotification.TextChanged += new System.EventHandler(this.txbNotification_TextChanged);
            // 
            // ltwNotification
            // 
            this.ltwNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ltwNotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltwNotification.HideSelection = false;
            this.ltwNotification.Location = new System.Drawing.Point(3, 251);
            this.ltwNotification.Name = "ltwNotification";
            this.ltwNotification.Size = new System.Drawing.Size(683, 242);
            this.ltwNotification.TabIndex = 5;
            this.ltwNotification.UseCompatibleStateImageBehavior = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1615, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.sidebar);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButon)).EndInit();
            this.panel_Cadastro.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox menuButon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Timer cadastro_timer;
        private System.Windows.Forms.Panel panel_Cadastro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.TextBox txbNotification;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox ckbTatuador4;
        private System.Windows.Forms.CheckBox ckbTatuador3;
        private System.Windows.Forms.CheckBox ckbTatuador2;
        private System.Windows.Forms.CheckBox ckbTatuador1;
        private System.Windows.Forms.ListView ltwNotification;
    }
}

