﻿using DW.Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Infraestructura.Base
{
    public interface IUsuarioDao : ICrudDao<Usuario>
    {
        Usuario Login(string nombre, string contraseña);
        Usuario GetByNombre(string nombre);
    }
}
