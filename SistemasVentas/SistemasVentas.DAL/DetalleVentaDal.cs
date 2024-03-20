﻿using System;
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
        public DetalleVenta ObtenerVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta deve = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                deve.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["idDetalleVenta"]);
                deve.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                deve.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                deve.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                deve.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"].ToString());
                deve.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subTotal"].ToString());
            }
            return deve;
        }
    }
}
