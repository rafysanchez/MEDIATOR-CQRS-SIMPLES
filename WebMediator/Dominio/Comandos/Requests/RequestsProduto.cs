using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Dominio.Comandos.Requests
{
    public class RequestsProduto : IRequest<ResponsesProduto>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
