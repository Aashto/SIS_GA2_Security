﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLDepartamento
    {

        public List<BeDepartamento> ListarDepartamentos(int idDepartamento)
        {
            DACDepartamento objDAO = new DACDepartamento();
            return objDAO.ListarDepartamentos(idDepartamento);
        }
    }
}
