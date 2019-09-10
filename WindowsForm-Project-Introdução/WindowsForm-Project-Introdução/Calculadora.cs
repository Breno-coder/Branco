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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            int primeironumero, segundonumero;
            primeironumero = Convert.ToInt32( txt_numero1);
            segundonumero = Convert.ToInt32(txt_numero2);

            lbl_resultado.Text = Convert.ToString(primeironumero + segundonumero);
        }
    }
}
