using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMediator.Dominio.Entidades
{
    public class Produto
    {

       public Produto( string nome, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
    }
}
