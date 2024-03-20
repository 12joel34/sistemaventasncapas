using SistemasVentas.BSS;
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
    public partial class ProveeListarVista : Form
    {
        public ProveeListarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveeInsertarVista fr = new ProveeInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

