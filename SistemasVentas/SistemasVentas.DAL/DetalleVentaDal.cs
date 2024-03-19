using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetallesVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                          "" + detalleVenta.IdProducto + "," +
                                                          "" + detalleVenta.Cantidad + "," +
                                                          "" + detalleVenta.PrecioVenta + "," +
                                                          "" + detalleVenta.SubTotal + "," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
