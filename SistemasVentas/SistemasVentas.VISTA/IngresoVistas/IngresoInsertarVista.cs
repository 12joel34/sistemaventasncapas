using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso p = new Ingreso();
            p.IdProveedor = IdProveedorSeleccionada;
            p.FechaIngreso = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox1.Text);

            bss.InsertarIngresoBss(p);
            MessageBox.Show("Se guardó correctamente a Ingreso");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox1.Text = proveedor.Nombre;
            }
        }

        private void IngresoInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
