﻿using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class DetalleIngBss
    {
        DetalleIngDal dal = new DetalleIngDal();
        public DataTable ListarDetalleIngBss()
        {
            return dal.ListarDetallesIngDal();
        }
        public void InsertarDetalleIngBss(DetalleIng detalleIng)
        {
            dal.InsertarDetalleIngDal(detalleIng);
        }
    }
}
