﻿using ComprasWeb.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasWeb.Servico.Servico.Interface
{
    public interface IUsuarioServico
    {
        void Adicionar(UsuarioDTO usuarioDTO);
    }
}
