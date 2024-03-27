using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeEditarVista : Form
    {
        int idx = 0;
        Provee p = new Provee();
        ProveeBss bss = new ProveeBss();
        public ProveeEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveeEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProveeIdBss(idx);
            textBox1.Text = p.IdProducto.ToString();
            textBox3.Text = p.IdProveedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox2.Text = p.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdProducto = IdProductoSeleccionada;
            p.IdProveedor = IdProveedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox2.Text);

            bss.EditarProveeBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox3.Text = proveedor.Nombre;
            }
        }
    }
}
