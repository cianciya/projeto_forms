namespace Projeto
{
    partial class Form1
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
            this.btnAvulso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButon)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sidebar.Controls.Add(this.pMenu);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Controls.Add(this.btnAvulso);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.button2);
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
            // btnAvulso
            // 
            this.btnAvulso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvulso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvulso.ForeColor = System.Drawing.Color.White;
            this.btnAvulso.Image = global::Projeto.Properties.Resources.home_5_32;
            this.btnAvulso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvulso.Location = new System.Drawing.Point(3, 151);
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
            this.button1.Location = new System.Drawing.Point(3, 193);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(216, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "             Teste";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Projeto.Properties.Resources.home_5_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 235);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(216, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "             Teste";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox menuButon;
        private System.Windows.Forms.Button btnAvulso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}

