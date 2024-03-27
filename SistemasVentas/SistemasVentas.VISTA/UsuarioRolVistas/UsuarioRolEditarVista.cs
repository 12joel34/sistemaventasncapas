using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVista : Form
    {
        int idx = 0;
        UsuarioRol p = new UsuarioRol();
        UsuarioRolBss bss = new UsuarioRolBss();
        public UsuarioRolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void UsuarioRolEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerUsuarioRolIdBss(idx);
            textBox2.Text = p.IdUsuario.ToString();
            textBox3.Text = p.IdRol.ToString();
            dateTimePicker1.Value = p.FechaAsigna;
            textBox1.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdUsuario = IdUsuarioSeleccionada;
            p.IdRol = IdRolSeleccionada;
            p.FechaAsigna = dateTimePicker1.Value;
            p.Estado = textBox1.Text;

            bss.EditarUsuarioRolBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdUsuarioSeleccionada = 0;
        UsuarioBss bssuser = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionada);
                textBox2.Text = usuario.NombreUser;
            }
        }
        public static int IdRolSeleccionada = 0;
        RolBss bssrol = new RolBss();
        private void button4_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssrol.ObtenerRolIdBss(IdRolSeleccionada);
                textBox3.Text = rol.Nombre;
            }
        }
    }
}
