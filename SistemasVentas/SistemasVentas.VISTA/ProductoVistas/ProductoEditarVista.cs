using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoEditarVista : Form
    {
        int idx = 0;
        Producto p = new Producto();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProductoIdBss(idx);
            textBox5.Text = p.IdTipoProducto.ToString();
            textBox6.Text = p.IdMarca.ToString();
            textBox1.Text = p.Nombre;
            textBox2.Text = p.CodigoBarra;
            textBox3.Text = p.Unidad.ToString();
            textBox4.Text = p.Descripcion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdTipoProducto = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox1.Text;
            p.CodigoBarra = textBox2.Text;
            p.Unidad = Convert.ToInt32(textBox3.Text);
            p.Descripcion = textBox4.Text;

            bss.EditarProductoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdTipoProdSeleccionada = 0;
        TipoProdBss bsstip = new TipoProdBss();
        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdListarVista fr = new TipoProdListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = bsstip.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox5.Text = tipoprod.Nombre;
            }
        }
        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssmar = new MarcaBss();
        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVista fr = new MarcaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssmar.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox6.Text = marca.Nombre;
            }
        }
    }
}
