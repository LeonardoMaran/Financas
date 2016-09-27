using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financas.Entidades
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}