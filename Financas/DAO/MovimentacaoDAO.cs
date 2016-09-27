using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class MovimentacaoDAO
    {
        private FinancasContext context;

        public decimal DataMinima { get; private set; }

        public MovimentacaoDAO(FinancasContext context)
        {
            this.context = context;
        }
        public void Adiciona(Movimentacao movimentacao)
        {
            context.Movimentacoes.Add(movimentacao);
            context.SaveChanges();
        }
        public IList<Movimentacao> Lista()
        {
            return context.Movimentacoes.ToList();
        }

        public IList<Movimentacao> BuscaPorUsuario(int? usuarioId)
        {
            return context.Movimentacoes.Where(m => m.UsuarioId == usuarioId).ToList();
        }

        public IList<Movimentacao> Busca(decimal? ValorMinimo, decimal? ValorMaximo,
            DateTime? DataMinima, DateTime? DataMaxima, Tipo? tipo, int? UsuarioId)
        {
            IQueryable<Movimentacao> busca = context.Movimentacoes;
            if(ValorMinimo.HasValue)
            {
                busca = busca.Where(m => m.Valor >= ValorMinimo);
            }
            if(ValorMaximo.HasValue)
            {
                busca = busca.Where(m => m.Valor <= ValorMaximo);
            }
            if(DataMinima.HasValue)
            {
                busca = busca.Where(m => m.Data <= DataMinima);
            }
            if(DataMaxima.HasValue)
            {
                busca = busca.Where(m =>m.Data <= DataMaxima);
            }
            if(tipo.HasValue)
            {
                busca = busca.Where(m => m.Tipo == tipo);
            }
            if(UsuarioId.HasValue)
            {
                busca = busca.Where(m => m.UsuarioId == UsuarioId);
            }
            return busca.ToList();
        }
    }
}