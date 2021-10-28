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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       
        ConeccionDB conexion = new ConeccionDB();
        Usuario user = new Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                errorProvider1.SetError(textBox1, "INGRESE USUARIO");
                textBox1.Focus();
               return;
            }
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "INGRESE CLAVE");
                textBox2.Focus();
                return;
            }

            user.CodigoUsuario = textBox1.Text;
            user.Clave = textBox2.Text;

            bool valido = conexion.ValidarUsuario(user);
            if(valido)
            { 
            MessageBox.Show("USUARIO CORRECTO");
                ProductosForm formulario = new ProductosForm();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO");
            }
        }
    }
}
