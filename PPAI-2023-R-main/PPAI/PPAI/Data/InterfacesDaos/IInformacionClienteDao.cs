﻿using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Data.InterfacesDaos {
    interface IInformacionClienteDao {

        List<InformacionClienteEntity> GetInformacionClienteById(int id);
    }
}
