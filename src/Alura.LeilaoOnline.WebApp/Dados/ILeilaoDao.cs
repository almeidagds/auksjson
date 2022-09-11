using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        public IEnumerable<Categoria> BuscarCategorias();

        public IEnumerable<Leilao> BuscarLeiloes();

        public Leilao BuscarPorId(int id);

        public void Incluir(Leilao leilao);

        public void Alterar(Leilao leilao);

        public void Excluir(Leilao leilao);
    }
}
