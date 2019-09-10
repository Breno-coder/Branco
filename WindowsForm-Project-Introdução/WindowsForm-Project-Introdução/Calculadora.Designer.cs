namespace WindowsForm_Project_Introdução
{
    partial class Calculadora
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_somar = new System.Windows.Forms.Button();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(530, 260);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(146, 33);
            this.lbl_resultado.TabIndex = 0;
            this.lbl_resultado.Text = "Resultado";
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(98, 260);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(185, 85);
            this.btn_somar.TabIndex = 1;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(93, 56);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(187, 20);
            this.txt_numero1.TabIndex = 2;
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(93, 93);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(188, 20);
            this.txt_numero2.TabIndex = 3;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.lbl_resultado);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
    }
}