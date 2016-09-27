using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financas.Models
{
    public class UsuarioModel
    {
        [Required]
        public string Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Compare("Senha")]
        public string ConfirmacaoSenha { get; set; }

    }
}