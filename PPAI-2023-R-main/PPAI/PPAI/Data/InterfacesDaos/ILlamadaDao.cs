﻿using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Data.InterfacesDaos {
    interface ILlamadaDao {

        LlamadaEntity GetLlamadaById(int id);

        int RegLlamadaRta(LlamadaEntity oLlamada);
    }
}
