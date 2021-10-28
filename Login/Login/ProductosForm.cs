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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ConeccionDB conexion = new ConeccionDB();
        Producto producto = new Producto();
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            producto.Codigo = txt_codigo.Text;
            producto.Descripcion = txt_descripcion.Text;
            producto.Precio =Convert.ToDecimal( txt_precio.Text);
            producto.Existencia = Convert.ToInt32(txt_existencia.Text);

            bool inserto = conexion.InsertarProducto(producto);

        }

    }
}
