using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + "," +
                                                          "" + producto.IdMarca + "," +
                                                          "'" + producto.Nombre + "'," +
                                                          "'" + producto.CodigoBarra + "'," +
                                                          "" + producto.Unidad + "," +
                                                          "'" + producto.Descripcion + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Producto pe = new Producto();
        public Producto ObtenerProductoIdDal(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                pe.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                pe.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                pe.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                pe.Nombre = tabla.Rows[0]["nombre"].ToString();
                pe.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                pe.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                pe.Descripcion = tabla.Rows[0]["descripcion"].ToString();
            }
            return pe;
        }
    }
}
