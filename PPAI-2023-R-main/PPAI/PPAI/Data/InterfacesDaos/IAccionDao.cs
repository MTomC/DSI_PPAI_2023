﻿using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Data.InterfacesDaos {
    interface IAccionDao {

        AccionEntity GetAccionById(int id);

        List<AccionEntity> GetAll();
    }
}
