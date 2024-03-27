using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        UsuarioBss bssuser = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox2.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario Registrado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
