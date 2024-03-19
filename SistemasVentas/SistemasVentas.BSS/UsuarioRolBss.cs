using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuariosRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol usuarioaRol)
        {
            dal.InsertarUsuarioRolDal(usuarioaRol);
        }
    }
}
