using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class UsuarioDAO
    {
        private FinancasContext context;
        public UsuarioDAO(FinancasContext context)
        {
            this.context = context;

        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();

        }
        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();

        }
    }
}