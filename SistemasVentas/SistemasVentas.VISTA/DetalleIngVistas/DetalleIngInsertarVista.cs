using SistemasVentas.Modelos;
using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng d = new DetalleIng();
            d.IdIngreso = IdIngresoSeleccionado;
            d.IdProducto = IdProductoSeleccionado;
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox1.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox2.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox3.Text);
            d.SubTotal = Convert.ToDecimal(textBox4.Text);

            bss.InsertarDetalleIngBss(d);
            MessageBox.Show("Se guardo correctamente el detalle  ingreso");
        }

        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssidingreso = new IngresoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssidingreso.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                textBox6.Text = Convert.ToString(ingreso.IdIngreso);
            }
        }

        public static int IdProductoSeleccionado = 0;
        ProductoBss bssidproducto = new ProductoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssidproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox5.Text = producto.Nombre;
            }
        }
    }
}
