using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMediator.Dominio.Comandos.Responses
{
    public class ResponsesProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Date { get; set; }
    }
}
