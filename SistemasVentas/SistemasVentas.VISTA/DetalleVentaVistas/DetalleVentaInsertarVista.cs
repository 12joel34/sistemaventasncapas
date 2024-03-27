using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.VentaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }

        private void DetalleVentaInsertarVista_Load(object sender, EventArgs e)
        {

        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta p = new DetalleVenta();
            p.IdVenta = IdVentaSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.Cantidad = Convert.ToInt32(textBox1.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox2.Text);
            p.SubTotal = Convert.ToDecimal(textBox3.Text);
            bss.InsertarDetalleVentaBss(p);
            MessageBox.Show("Se guardó correctamente a Detalle Venta");
        }
        public static int IdVentaSeleccionada = 0;
        VentaBss bssven = new VentaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVista fr = new VentaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssven.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox4.Text = venta.IdVenta.ToString();
            }
        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox5.Text = producto.Nombre;
            }
        }
    }
}
