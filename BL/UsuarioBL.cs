﻿using BE;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UsuarioBL
    {
        UsuarioDAL usuarioDAL;
        public UsuarioBL()
        {
            usuarioDAL = new UsuarioDAL();
        }
    }
}
