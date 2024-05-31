namespace Bloc
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.timerAtualizacao = new System.Windows.Forms.Timer(this.components);
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAnotacoes = new System.Windows.Forms.Panel();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.pnListaLeitura = new System.Windows.Forms.Panel();
            this.btnListaLeitura = new System.Windows.Forms.Button();
            this.pnDocumento = new System.Windows.Forms.Panel();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.pnCalendario = new System.Windows.Forms.Panel();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.pnSair = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnAnotacoes.SuspendLayout();
            this.pnListaLeitura.SuspendLayout();
            this.pnDocumento.SuspendLayout();
            this.pnCalendario.SuspendLayout();
            this.pnSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDataAtual.ForeColor = System.Drawing.Color.Black;
            this.lblDataAtual.Location = new System.Drawing.Point(1149, 8);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(100, 24);
            this.lblDataAtual.TabIndex = 14;
            this.lblDataAtual.Text = "21/03/2024";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDataAtual);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 39);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(91, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "BLOC | BEST NOTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.pnAnotacoes);
            this.sidebar.Controls.Add(this.pnListaLeitura);
            this.sidebar.Controls.Add(this.pnDocumento);
            this.sidebar.Controls.Add(this.pnCalendario);
            this.sidebar.Controls.Add(this.pnSair);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 36);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 100, 0, 20);
            this.sidebar.Size = new System.Drawing.Size(221, 600);
            this.sidebar.TabIndex = 21;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.menuContainer_Paint);
            // 
            // pnAnotacoes
            // 
            this.pnAnotacoes.BackColor = System.Drawing.Color.Transparent;
            this.pnAnotacoes.Controls.Add(this.btnAnotacoes);
            this.pnAnotacoes.Location = new System.Drawing.Point(3, 103);
            this.pnAnotacoes.Name = "pnAnotacoes";
            this.pnAnotacoes.Size = new System.Drawing.Size(215, 58);
            this.pnAnotacoes.TabIndex = 23;
            this.pnAnotacoes.UseWaitCursor = true;
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnAnotacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnotacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnotacoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnotacoes.ForeColor = System.Drawing.Color.Black;
            this.btnAnotacoes.Image = global::Bloc.Properties.Resources.edit1;
            this.btnAnotacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnotacoes.Location = new System.Drawing.Point(0, 0);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(215, 58);
            this.btnAnotacoes.TabIndex = 22;
            this.btnAnotacoes.Text = "Anotações";
            this.btnAnotacoes.UseVisualStyleBackColor = false;
            this.btnAnotacoes.UseWaitCursor = true;
            this.btnAnotacoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnListaLeitura
            // 
            this.pnListaLeitura.BackColor = System.Drawing.Color.Transparent;
            this.pnListaLeitura.Controls.Add(this.btnListaLeitura);
            this.pnListaLeitura.Location = new System.Drawing.Point(3, 167);
            this.pnListaLeitura.Name = "pnListaLeitura";
            this.pnListaLeitura.Size = new System.Drawing.Size(215, 58);
            this.pnListaLeitura.TabIndex = 28;
            this.pnListaLeitura.UseWaitCursor = true;
            // 
            // btnListaLeitura
            // 
            this.btnListaLeitura.BackColor = System.Drawing.Color.Transparent;
            this.btnListaLeitura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListaLeitura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListaLeitura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnListaLeitura.ForeColor = System.Drawing.Color.Black;
            this.btnListaLeitura.Image = global::Bloc.Properties.Resources.book_alt1;
            this.btnListaLeitura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaLeitura.Location = new System.Drawing.Point(0, 0);
            this.btnListaLeitura.Name = "btnListaLeitura";
            this.btnListaLeitura.Size = new System.Drawing.Size(215, 58);
            this.btnListaLeitura.TabIndex = 22;
            this.btnListaLeitura.Text = "Lista de leitura";
            this.btnListaLeitura.UseVisualStyleBackColor = false;
            this.btnListaLeitura.UseWaitCursor = true;
            this.btnListaLeitura.Click += new System.EventHandler(this.btnListaLeitura_Click);
            // 
            // pnDocumento
            // 
            this.pnDocumento.BackColor = System.Drawing.Color.Transparent;
            this.pnDocumento.Controls.Add(this.btnDocumentos);
            this.pnDocumento.Location = new System.Drawing.Point(3, 231);
            this.pnDocumento.Name = "pnDocumento";
            this.pnDocumento.Size = new System.Drawing.Size(215, 58);
            this.pnDocumento.TabIndex = 29;
            this.pnDocumento.UseWaitCursor = true;
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDocumentos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDocumentos.ForeColor = System.Drawing.Color.Black;
            this.btnDocumentos.Image = global::Bloc.Properties.Resources.folder1;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 0);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(215, 58);
            this.btnDocumentos.TabIndex = 22;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.UseWaitCursor = true;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // pnCalendario
            // 
            this.pnCalendario.BackColor = System.Drawing.Color.Transparent;
            this.pnCalendario.Controls.Add(this.btnCalendario);
            this.pnCalendario.Location = new System.Drawing.Point(3, 295);
            this.pnCalendario.Name = "pnCalendario";
            this.pnCalendario.Size = new System.Drawing.Size(215, 58);
            this.pnCalendario.TabIndex = 30;
            this.pnCalendario.UseWaitCursor = true;
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalendario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalendario.ForeColor = System.Drawing.Color.Black;
            this.btnCalendario.Image = global::Bloc.Properties.Resources.calendar;
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(0, 0);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(215, 58);
            this.btnCalendario.TabIndex = 22;
            this.btnCalendario.Text = "Caléndario";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.UseWaitCursor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // pnSair
            // 
            this.pnSair.BackColor = System.Drawing.Color.Transparent;
            this.pnSair.Controls.Add(this.btnSair);
            this.pnSair.Location = new System.Drawing.Point(3, 359);
            this.pnSair.Name = "pnSair";
            this.pnSair.Size = new System.Drawing.Size(215, 57);
            this.pnSair.TabIndex = 31;
            this.pnSair.UseWaitCursor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::Bloc.Properties.Resources.exit1;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(215, 57);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.UseWaitCursor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(11, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(45, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 23;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 636);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.pnAnotacoes.ResumeLayout(false);
            this.pnListaLeitura.ResumeLayout(false);
            this.pnDocumento.ResumeLayout(false);
            this.pnCalendario.ResumeLayout(false);
            this.pnSair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAtualizacao;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnAnotacoes;
        private System.Windows.Forms.Button btnAnotacoes;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnListaLeitura;
        private System.Windows.Forms.Button btnListaLeitura;
        private System.Windows.Forms.Panel pnDocumento;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Panel pnCalendario;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Panel pnSair;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnHam;
    }
}