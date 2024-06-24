namespace Bloc
{
    partial class FormListaLeitura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcategoriasLivros = new System.Windows.Forms.ComboBox();
            this.TxtNomeObra = new System.Windows.Forms.TextBox();
            this.BtnVisualizarobra = new ReaLTaiizor.Controls.LostButton();
            this.btnLimparObra = new ReaLTaiizor.Controls.LostButton();
            this.btnSalvarObra = new ReaLTaiizor.Controls.LostButton();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(534, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Obra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(590, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria:";
            // 
            // cbcategoriasLivros
            // 
            this.cbcategoriasLivros.FormattingEnabled = true;
            this.cbcategoriasLivros.Location = new System.Drawing.Point(738, 345);
            this.cbcategoriasLivros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbcategoriasLivros.Name = "cbcategoriasLivros";
            this.cbcategoriasLivros.Size = new System.Drawing.Size(216, 28);
            this.cbcategoriasLivros.TabIndex = 2;
            this.cbcategoriasLivros.SelectedIndexChanged += new System.EventHandler(this.cbcategoriasLivros_SelectedIndexChanged);
            // 
            // TxtNomeObra
            // 
            this.TxtNomeObra.Location = new System.Drawing.Point(738, 200);
            this.TxtNomeObra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNomeObra.Name = "TxtNomeObra";
            this.TxtNomeObra.Size = new System.Drawing.Size(955, 26);
            this.TxtNomeObra.TabIndex = 3;
            // 
            // BtnVisualizarobra
            // 
            this.BtnVisualizarobra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnVisualizarobra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVisualizarobra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnVisualizarobra.ForeColor = System.Drawing.Color.White;
            this.BtnVisualizarobra.HoverColor = System.Drawing.Color.DodgerBlue;
            this.BtnVisualizarobra.Image = null;
            this.BtnVisualizarobra.Location = new System.Drawing.Point(1107, 555);
            this.BtnVisualizarobra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVisualizarobra.Name = "BtnVisualizarobra";
            this.BtnVisualizarobra.Size = new System.Drawing.Size(224, 62);
            this.BtnVisualizarobra.TabIndex = 4;
            this.BtnVisualizarobra.Text = "Visualizar Obras";
            // 
            // btnLimparObra
            // 
            this.btnLimparObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimparObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparObra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimparObra.ForeColor = System.Drawing.Color.White;
            this.btnLimparObra.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btnLimparObra.Image = null;
            this.btnLimparObra.Location = new System.Drawing.Point(738, 555);
            this.btnLimparObra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimparObra.Name = "btnLimparObra";
            this.btnLimparObra.Size = new System.Drawing.Size(224, 62);
            this.btnLimparObra.TabIndex = 5;
            this.btnLimparObra.Text = "Limpar";
            // 
            // btnSalvarObra
            // 
            this.btnSalvarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalvarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarObra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvarObra.ForeColor = System.Drawing.Color.White;
            this.btnSalvarObra.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvarObra.Image = null;
            this.btnSalvarObra.Location = new System.Drawing.Point(1472, 555);
            this.btnSalvarObra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvarObra.Name = "btnSalvarObra";
            this.btnSalvarObra.Size = new System.Drawing.Size(224, 62);
            this.btnSalvarObra.TabIndex = 6;
            this.btnSalvarObra.Text = "Salvar Obra";
            this.btnSalvarObra.Click += new System.EventHandler(this.btnSalvarObra_Click);
            // 
            // smallLabel1
            // 
            this.smallLabel1.AutoSize = true;
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel1.ForeColor = System.Drawing.Color.White;
            this.smallLabel1.Location = new System.Drawing.Point(737, 231);
            this.smallLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(225, 21);
            this.smallLabel1.TabIndex = 7;
            this.smallLabel1.Text = "(Insira aqui as obras que já leu)";
            // 
            // FormListaLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1900, 1091);
            this.ControlBox = false;
            this.Controls.Add(this.smallLabel1);
            this.Controls.Add(this.btnSalvarObra);
            this.Controls.Add(this.btnLimparObra);
            this.Controls.Add(this.BtnVisualizarobra);
            this.Controls.Add(this.TxtNomeObra);
            this.Controls.Add(this.cbcategoriasLivros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(2880, 1588);
            this.Name = "FormListaLeitura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaLeitura";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FormListaLeitura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcategoriasLivros;
        private System.Windows.Forms.TextBox TxtNomeObra;
        private ReaLTaiizor.Controls.LostButton BtnVisualizarobra;
        private ReaLTaiizor.Controls.LostButton btnLimparObra;
        private ReaLTaiizor.Controls.LostButton btnSalvarObra;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
    }
}