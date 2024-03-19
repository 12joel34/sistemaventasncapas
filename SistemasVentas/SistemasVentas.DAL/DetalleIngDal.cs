using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetallesIngDal()
        {
            string consulta = "select * from detalleing";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into detalleIng values(" + detalleIng.IdDetalleIng + "," +
                                                          "" + detalleIng.IdProducto + "," +
                                                          "'" + detalleIng.FechaVenc + "'," +
                                                          "" + detalleIng.Cantidad + "," +
                                                          "" + detalleIng.PrecioCosto + "," +
                                                          "" + detalleIng.PrecioVenta + "," +
                                                          "" + detalleIng.SubTotal + "," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
