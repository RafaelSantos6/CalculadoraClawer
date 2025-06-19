using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Top
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidebarPanel.Visible)
            {
                sidebarPanel.Visible = false;
                btnMenu.Text = "Menu";
            }
            else
            {
                sidebarPanel.Visible = true;
                btnMenu.Text = "Fechar Menu";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Cria uma instância do outro Form
            form1.Show();               // Abre o Form2 como janela separada
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
        }
    }
}
