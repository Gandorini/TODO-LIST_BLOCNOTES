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
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.btnListaLeitura = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnCalendário = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDataAtual.ForeColor = System.Drawing.Color.Black;
            this.lblDataAtual.Location = new System.Drawing.Point(1148, 9);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(100, 24);
            this.lblDataAtual.TabIndex = 14;
            this.lblDataAtual.Text = "21/03/2024";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDataAtual);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 43);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(145, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "BLOC | BEST NOTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.flowLayoutPanelMenu.Controls.Add(this.panel2);
            this.flowLayoutPanelMenu.Controls.Add(this.panel3);
            this.flowLayoutPanelMenu.Controls.Add(this.panel4);
            this.flowLayoutPanelMenu.Controls.Add(this.panel5);
            this.flowLayoutPanelMenu.Controls.Add(this.panel6);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(177, 596);
            this.flowLayoutPanelMenu.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnAnotacoes);
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 52);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnListaLeitura);
            this.panel3.Location = new System.Drawing.Point(3, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 52);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnDocumentos);
            this.panel4.Location = new System.Drawing.Point(3, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 52);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnCalendário);
            this.panel5.Location = new System.Drawing.Point(3, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 52);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnSair);
            this.panel6.Location = new System.Drawing.Point(3, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 52);
            this.panel6.TabIndex = 27;
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnAnotacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnotacoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnotacoes.ForeColor = System.Drawing.Color.Black;
            this.btnAnotacoes.Image = global::Bloc.Properties.Resources.edit;
            this.btnAnotacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnotacoes.Location = new System.Drawing.Point(0, 3);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(171, 46);
            this.btnAnotacoes.TabIndex = 22;
            this.btnAnotacoes.Text = "Anotações";
            this.btnAnotacoes.UseVisualStyleBackColor = false;
            this.btnAnotacoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListaLeitura
            // 
            this.btnListaLeitura.BackColor = System.Drawing.Color.Transparent;
            this.btnListaLeitura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListaLeitura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnListaLeitura.ForeColor = System.Drawing.Color.Black;
            this.btnListaLeitura.Image = global::Bloc.Properties.Resources.book_alt;
            this.btnListaLeitura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaLeitura.Location = new System.Drawing.Point(0, 3);
            this.btnListaLeitura.Name = "btnListaLeitura";
            this.btnListaLeitura.Size = new System.Drawing.Size(171, 46);
            this.btnListaLeitura.TabIndex = 22;
            this.btnListaLeitura.Text = "Lista de Leitura";
            this.btnListaLeitura.UseVisualStyleBackColor = false;
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocumentos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDocumentos.ForeColor = System.Drawing.Color.Black;
            this.btnDocumentos.Image = global::Bloc.Properties.Resources.folder;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 3);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(171, 46);
            this.btnDocumentos.TabIndex = 22;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            // 
            // btnCalendário
            // 
            this.btnCalendário.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendário.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendário.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalendário.ForeColor = System.Drawing.Color.Black;
            this.btnCalendário.Image = global::Bloc.Properties.Resources.calendar_clock;
            this.btnCalendário.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendário.Location = new System.Drawing.Point(0, 3);
            this.btnCalendário.Name = "btnCalendário";
            this.btnCalendário.Size = new System.Drawing.Size(171, 46);
            this.btnCalendário.TabIndex = 22;
            this.btnCalendário.Text = "Calendário";
            this.btnCalendário.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::Bloc.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 46);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bloc.Properties.Resources.menu_burger;
            this.pictureBox2.Location = new System.Drawing.Point(46, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 34);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bloc.Properties.Resources.e1eb2d10bc727f397d3e65d49b1f09cc;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // timerMenu
            // 
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 639);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAtualizacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnotacoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListaLeitura;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCalendário;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timerMenu;
    }
}