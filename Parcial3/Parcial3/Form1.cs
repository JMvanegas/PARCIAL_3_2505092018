using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = textBox2.Text.TrimEnd();
            contraseña = textBox2.Text.TrimEnd();
            if ((usuario == "UTEC") && (contraseña == "progra1"))
            {
                MessageBox.Show("Bienvenido");
                progressBar1.Value = 20;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            MDIParent1 padre = new MDIParent1();
            padre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
