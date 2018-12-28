using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    class Program
    {
        private static int contador;

        static void Main(string[] args)
        {
            var p = new Produto();
            p.Nome = "Star Wars I";
            //GravarUsandoEntity(p);
            RecuperarTodosElementos();
            //RecuperarPrimeiroProduto();
            ExcluirProdutos();
            RecuperarTodosElementos();

            Console.ReadLine();
            

        }

        private static void ExcluirProdutos()
        {           
            using (var repo = new LojaContext())
            {
                List<Produto> produtos = repo.Produtos.ToList();
                int produtosAntesExclusao = produtos.Count();

                foreach (var produto in produtos) {

                    produtos.Remove(produto);

                }
                repo.SaveChanges();
                Console.WriteLine($"Foram excluidos {produtosAntesExclusao} produtos.");
            }
        }

        private static void AtualizarElemento()
        {
            throw new NotImplementedException();
        }

        private static void RecuperarPrimeiroProduto()
        {
            using(var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Produto p = produtos.First();
                Console.WriteLine(p.Nome);
            }
        }

        private static void RecuperarTodosElementos()
        {
            using(var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                repo.Produtos.ToList();
                Console.WriteLine($"Foram encontrados {produtos.Count()} produtos.\n");
                foreach(var produto in produtos)
                {
                    Console.WriteLine(produto.Nome);
                }
            }
            
        }

        private static void GravarUsandoEntity(Produto p)
        {
            using(var repo = new LojaContext())
            {
                repo.Produtos.Add(p);
                repo.SaveChanges();
            }
            
        }
    }
}
