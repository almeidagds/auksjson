﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDao
    {
        AppDbContext _context;

        public LeilaoDao()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Categoria> BuscarCategorias()
        {
            return BuscarCategorias();
        }

        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes.Include(leilao => leilao.Categoria).ToList();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(leilao => leilao.Id == id);
        }

        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
