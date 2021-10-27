using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        ConeccionDB conexion = new ConeccionDB();
        Usuario user = new Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            user.CodigoUsuario = textBox1.Text;
            user.Clave = textBox2.Text;

            bool valido = conexion.ValidarUsuario(user);
            if(valido)
            { 
            MessageBox.Show("USUARIO CORRECTO");
            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO");
            }
        }
    }
}
