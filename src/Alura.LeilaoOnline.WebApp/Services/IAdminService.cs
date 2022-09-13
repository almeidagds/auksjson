﻿using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> ConsultarCategorias();

        IEnumerable<Leilao> ConsultarLeiloes();

        Leilao ConsultaLeilaoPorId(int id);

        void CadastraLeilao(Leilao leilao);

        void ModificaLeilao(Leilao leilao);

        void RemoveLeilao(Leilao leilao);

        void IniciaPregaoDoLeilaoComId(int id);

        void FinalizaPregaoDoLeilaoComId(int id);
    }
}
