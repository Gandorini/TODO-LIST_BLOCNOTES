namespace Bloc
{
    partial class CriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarConta));
            this.txtPalavraPasseCriar = new System.Windows.Forms.TextBox();
            this.txtNomeCriar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.BtnSairCriarConta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalavraPasseCriar
            // 
            this.txtPalavraPasseCriar.Location = new System.Drawing.Point(219, 334);
            this.txtPalavraPasseCriar.Name = "txtPalavraPasseCriar";
            this.txtPalavraPasseCriar.Size = new System.Drawing.Size(449, 20);
            this.txtPalavraPasseCriar.TabIndex = 8;
            this.txtPalavraPasseCriar.UseSystemPasswordChar = true;
            // 
            // txtNomeCriar
            // 
            this.txtNomeCriar.Location = new System.Drawing.Point(219, 259);
            this.txtNomeCriar.Name = "txtNomeCriar";
            this.txtNomeCriar.Size = new System.Drawing.Size(449, 20);
            this.txtNomeCriar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nova Palavra-Passe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Novo Utilizador:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(690, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(334, 441);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(201, 45);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // BtnSairCriarConta
            // 
            this.BtnSairCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSairCriarConta.Location = new System.Drawing.Point(12, 12);
            this.BtnSairCriarConta.Name = "BtnSairCriarConta";
            this.BtnSairCriarConta.Size = new System.Drawing.Size(58, 45);
            this.BtnSairCriarConta.TabIndex = 11;
            this.BtnSairCriarConta.Text = "X";
            this.BtnSairCriarConta.UseVisualStyleBackColor = true;
            this.BtnSairCriarConta.Click += new System.EventHandler(this.BtnSairCriarConta_Click);
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1272, 640);
            this.Controls.Add(this.BtnSairCriarConta);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPalavraPasseCriar);
            this.Controls.Add(this.txtNomeCriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.Load += new System.EventHandler(this.CriarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavraPasseCriar;
        private System.Windows.Forms.TextBox txtNomeCriar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button BtnSairCriarConta;
    }
}