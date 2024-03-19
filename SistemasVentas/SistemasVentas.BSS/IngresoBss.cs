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
    public class IngresoBss
    {
        IngresoDal dal = new IngresoDal();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresosDal();
        }
        public void InsertarIngresoBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDal(ingreso);
        }
    }
}
