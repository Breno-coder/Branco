namespace WindowsForm_Project_Introdução
{
    partial class Principal
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btn_mudarmensagem = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(44, 126);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 48);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Visible = false;
            this.lblMensagem.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btn_mudarmensagem
            // 
            this.btn_mudarmensagem.Enabled = false;
            this.btn_mudarmensagem.Location = new System.Drawing.Point(12, 243);
            this.btn_mudarmensagem.Name = "btn_mudarmensagem";
            this.btn_mudarmensagem.Size = new System.Drawing.Size(77, 48);
            this.btn_mudarmensagem.TabIndex = 1;
            this.btn_mudarmensagem.Text = "Atualizar";
            this.btn_mudarmensagem.UseVisualStyleBackColor = true;
            this.btn_mudarmensagem.Click += new System.EventHandler(this.btn_mudarmensagem_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(23, 74);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(312, 20);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            this.txtnome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnome_KeyDown);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("SWGreks", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(21, 7);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(117, 47);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "nome";
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.Location = new System.Drawing.Point(220, 250);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(114, 49);
            this.btn_calculadora.TabIndex = 5;
            this.btn_calculadora.Text = "Calculadora";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(347, 359);
            this.Controls.Add(this.btn_calculadora);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btn_mudarmensagem);
            this.Controls.Add(this.lblMensagem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btn_mudarmensagem;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_calculadora;
    }
}

