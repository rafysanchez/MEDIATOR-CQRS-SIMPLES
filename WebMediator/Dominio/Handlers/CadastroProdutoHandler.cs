using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Dominio.Handlers
{
    public class CadastroProdutoHandler : IRequestHandler<RequestsProduto, ResponsesProduto>
    {
        public Task<ResponsesProduto> Handle(RequestsProduto request, CancellationToken cancellationToken)
        {
            var resultado = new ResponsesProduto
            {
                Id = Guid.NewGuid(),
                Nome = "Iphone XR",
                Valor = 4000,
                Date = DateTime.Now
            };
            return Task.FromResult(resultado);
        }
    }
}
