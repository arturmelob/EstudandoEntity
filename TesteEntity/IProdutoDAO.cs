using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    interface IProdutoDAO : IDisposable
    {
        void Adicionar(Produto p);
        void Remover(Produto p);
        void Atualizar(Produto p);
        IList<Produto> Produtos();
    }
}
