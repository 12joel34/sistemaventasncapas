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
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdTipoProd = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox1.Text;
            p.CodigoBarra = textBox2.Text;
            p.Unidad = Convert.ToInt32(textBox3.Text);
            p.Descripcion = textBox4.Text;

            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardó correctamente a Producto");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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
