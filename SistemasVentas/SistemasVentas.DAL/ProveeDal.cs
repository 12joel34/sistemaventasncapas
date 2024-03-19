﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveesDal()
        {
            string consulta = "select * from provee";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + "," +
                                                          "" + provee.IdProveedor + "," +
                                                          "'" + provee.Fecha + "'," +
                                                          "" + provee.Precio +")";
            conexion.Ejecutar(consulta);
        }
    }
}
