﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities.Estados
{
    class Descartada : EstadoA
    {
        public override EstadoA CrearProximoEstado(LlamadaEntity llamada)
        {
            throw new NotImplementedException();
        }
    }
}