﻿using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services.Interfaces {
    internal interface ICategoriaLlamadaService {

        List<CategoriaLlamadaEntity> GetAll();

        CategoriaLlamadaEntity GetCategoriaLlamadaById(int id);
    }
}
