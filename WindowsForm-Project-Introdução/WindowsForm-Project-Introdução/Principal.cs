using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Project_Introdução
{
    public partial class Principal : Form
    {
       
        string nome = string.Empty;
            public Principal()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                //lblMensagem.Text = "Clique Aqui!";
            }

            private void btn_mudarmensagem_Click(object sender, EventArgs e)
            {
            lbl_nome.Text = nome;
            }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            nome = txtnome.Text;
        }

        private void txtnome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_mudarmensagem.Enabled = true;
            }
            
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            Calculadora formulario = new Calculadora();
            formulario.Show();
            
            
        }
    }
}
