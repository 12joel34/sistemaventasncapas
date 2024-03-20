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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolListarVista : Form
    {
        public RolListarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolInsertarVista fr = new RolInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }
    }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
