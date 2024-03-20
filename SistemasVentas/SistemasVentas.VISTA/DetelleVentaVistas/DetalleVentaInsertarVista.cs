using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetelleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta de = new DetalleVenta();
            de.IdVenta = IdVentaSeleccionada;
            de.IdProducto = IdProductoSeleccionado;
            de.Cantidad = Convert.ToInt32(textBox1.Text);
            de.PrecioVenta = Convert.ToDecimal(textBox2.Text);
            de.SubTotal = Convert.ToDecimal(textBox3.Text);

            bss.InsertarDetalleVentaBss(de);
            MessageBox.Show("Se guardo correctamente el detalle venta");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public static int IdVentaSeleccionada = 0;
        VentaBss bssventa = new VentaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVista fr = new VentaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssventa.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox4.Text = Convert.ToString(venta.IdVenta);
            }
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox5.Text = producto.Nombre;
            }
        }
    }
}
