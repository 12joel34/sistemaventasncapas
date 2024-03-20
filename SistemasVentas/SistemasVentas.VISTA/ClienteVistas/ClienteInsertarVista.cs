using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdPersona = IdPersonaSeleccionada;
            c.TipoCliente = textBox1.Text;
            c.CodigoCliente = textBox2.Text;

            bss.InsertarClienteBss(c);
            MessageBox.Show("Se guardo correctamente su cliente");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersel = new PersonaBss();

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if(fr.ShowDialog()==DialogResult.OK)
            {
                Persona persona = bsspersel.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox3.Text = persona.Nombre + " " + persona.Apellido;   
            }
        }
    }
}
