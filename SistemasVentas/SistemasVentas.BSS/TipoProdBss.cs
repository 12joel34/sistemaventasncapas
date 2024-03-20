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
    public class TipoProdBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ListarTipoProdBss()
        {
            return dal.ListarTiposProdDal();
        }
        public void InsertarTipoProdBss(TipoProd tipoProd)
        {
            dal.InsertarTipoProdDal(tipoProd);
        }
        public TipoProd ObtenerTipoProdIdBss(int id)
        {
            return dal.ObtenerTipoProdIdDal(id);
        }
        public void EditarTipoProdBss(TipoProd p)
        {
            dal.EditarTipoProdDal(p);
        }
        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }
    }
}
