using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Dominio.Handlers
{
    public interface ICadastroProdutoHandler
    {
        ResponsesProduto Handle(RequestsProduto request);
    }
}
