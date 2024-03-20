using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresosDal()
        {
            string consulta = "select * from ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," +
                                                          "'" + ingreso.FechaIngreso + "'," +
                                                          "" + ingreso.Total + "," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Ingreso pe = new Ingreso();
        public Ingreso ObtenerIngresoId(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count>0)
            {
                pe.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                pe.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                pe.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                pe.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
            }
            return pe;
        }
    }
}
