using System;

namespace Bloc
{
    partial class FormAnotacoes
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
            this.txtNomeAnota = new System.Windows.Forms.TextBox();
            this.txtAnotacoesTexto = new System.Windows.Forms.TextBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeAnota
            // 
            this.txtNomeAnota.Location = new System.Drawing.Point(338, 83);
            this.txtNomeAnota.Name = "txtNomeAnota";
            this.txtNomeAnota.Size = new System.Drawing.Size(167, 20);
            this.txtNomeAnota.TabIndex = 1;
            // 
            // txtAnotacoesTexto
            // 
            this.txtAnotacoesTexto.Location = new System.Drawing.Point(578, 81);
            this.txtAnotacoesTexto.MaxLength = 999999999;
            this.txtAnotacoesTexto.Name = "txtAnotacoesTexto";
            this.txtAnotacoesTexto.Size = new System.Drawing.Size(658, 20);
            this.txtAnotacoesTexto.TabIndex = 2;
            this.txtAnotacoesTexto.TextChanged += new System.EventHandler(this.txtAnotacoesTexto_TextChanged);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(578, 505);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(216, 41);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar Anotações";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1020, 505);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(216, 41);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(338, 174);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(167, 21);
            this.cbCategorias.TabIndex = 5;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escolha a Categoria :";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(799, 505);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(216, 41);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormAnotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 715);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.txtAnotacoesTexto);
            this.Controls.Add(this.txtNomeAnota);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnotacoes";
            this.Text = "FormAnotacoes";
            this.Load += new System.EventHandler(this.FormAnotacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAnota;
        private System.Windows.Forms.TextBox txtAnotacoesTexto;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
    }
}