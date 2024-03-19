using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuariosRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuarioRol values(" + usuarioRol.IdUsuario + "," +
                                                          "" + usuarioRol.IdRol + "," +
                                                          "'" + usuarioRol.FechaAsigna + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
