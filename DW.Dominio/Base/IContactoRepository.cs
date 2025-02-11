﻿using DW.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Dominio.Base
{
    public interface IContactoRepository : ICrudRepository<ContactoBo>
    {
        ContactoBo GetById(long id);
    }
}
