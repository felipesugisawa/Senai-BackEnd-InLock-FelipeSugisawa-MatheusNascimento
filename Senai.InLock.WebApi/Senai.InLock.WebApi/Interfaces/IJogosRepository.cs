﻿using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interface
{
    interface IJogosRepository
    {
        List<JogosDomain> Listar();

        void Cadastrar(JogosDomain novoJogo);

        void Deletar(int id);
    }
}
