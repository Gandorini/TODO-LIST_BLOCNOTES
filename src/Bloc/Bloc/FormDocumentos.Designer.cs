namespace Bloc
{
    partial class FormDocumentos
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.TxtDocumento = new ReaLTaiizor.Controls.BigTextBox();
            this.btnLimpar = new ReaLTaiizor.Controls.LostButton();
            this.BtnverDocumentos = new ReaLTaiizor.Controls.LostButton();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(295, 154);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(350, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Nome do documento:";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BackColor = System.Drawing.Color.Transparent;
            this.TxtDocumento.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtDocumento.ForeColor = System.Drawing.Color.Black;
            this.TxtDocumento.Image = null;
            this.TxtDocumento.Location = new System.Drawing.Point(651, 159);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.Multiline = true;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.ReadOnly = false;
            this.TxtDocumento.Size = new System.Drawing.Size(526, 41);
            this.TxtDocumento.TabIndex = 1;
            this.TxtDocumento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.Image = null;
            this.btnLimpar.Location = new System.Drawing.Point(935, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(242, 58);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            // 
            // BtnverDocumentos
            // 
            this.BtnverDocumentos.AllowDrop = true;
            this.BtnverDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnverDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnverDocumentos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnverDocumentos.ForeColor = System.Drawing.Color.White;
            this.BtnverDocumentos.HoverColor = System.Drawing.Color.DodgerBlue;
            this.BtnverDocumentos.Image = null;
            this.BtnverDocumentos.Location = new System.Drawing.Point(651, 360);
            this.BtnverDocumentos.Name = "BtnverDocumentos";
            this.BtnverDocumentos.Size = new System.Drawing.Size(242, 58);
            this.BtnverDocumentos.TabIndex = 11;
            this.BtnverDocumentos.Text = "Ver Documentos";
            // 
            // FormDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1267, 709);
            this.ControlBox = false;
            this.Controls.Add(this.BtnverDocumentos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDocumentos";
            this.Text = "FormDocumentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox TxtDocumento;
        private ReaLTaiizor.Controls.LostButton btnLimpar;
        private ReaLTaiizor.Controls.LostButton BtnverDocumentos;
    }
}