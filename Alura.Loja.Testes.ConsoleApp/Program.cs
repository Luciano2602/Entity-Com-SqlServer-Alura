using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
                
                
        }
        
        
    }
}


/*
 


    var cliente = contexto.
                              Clientes.
                              Include(c => c.EnderecoEntrega).
                              FirstOrDefault();

                Console.WriteLine("Endereço de entrega " + cliente.EnderecoEntrega.Logradouro);

                var produto = contexto.Produtos.Include(p => p.Compras).Where(p => p.Id == 2002).FirstOrDefault();

                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item);
                }


    class produto -> public IList<Compra> Compras { get; set; }







    using(var contexto2 = new LojaContext())
            {

                var promocao = contexto2.Promocoes.Include(p => p.Produtos).ThenInclude(pp => pp.Produto).FirstOrDefault();

                Console.WriteLine("\nMostrando os produtos da promoção....");
                foreach (var item in promocao.Produtos)
                {

                    Console.WriteLine(item.Produto);
                }

            }







    using(var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTerminio = new DateTime(2017, 1, 31);


                //int testeandoParametroPorId = 2;
                //var prodTeste = contexto.Produtos.Where(p => p.Id == testeandoParametroPorId).ToList();
                

                var produtos = contexto.Produtos.Where(p => p.Categoria == "Bebidas").ToList();               

                foreach (var item in produtos)
                {
                    promocao.IncluirProduto(item);
                }

                contexto.Promocoes.Add(promocao);

                contexto.SaveChanges();
            }













    var fulano = new Cliente();
            fulano.Nome = "Fulano";
            fulano.EnderecoEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro ="Rua do Sucesso",
                Complemento = "Prosperidade",
                Bairro = "Jd Progresso",
                Cidade = "Vai dar tudo certo"
                
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }




 


    var p1 = new Produto() { Nome ="Suco de Laranja", Categoria ="Bebidas", PrecoUnitario = 8.79, Unidade ="Litros"};
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };



            var promocaPasta = new Promocao();
            promocaPasta.Descricao = "Páscoa Feliz";
            promocaPasta.DataInicio = DateTime.Now;
            promocaPasta.DataTerminio = DateTime.Now.AddMonths(3);


            promocaPasta.IncluirProduto(p1);
            promocaPasta.IncluirProduto(p2);
            promocaPasta.IncluirProduto(p3);

           

            using(var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaPasta);
                contexto.SaveChanges();
            }






    
             //compra de 6 pães franceses
            var paoFrances = new Produto();

            paoFrances.Nome = "pão Francês";
            paoFrances.PrecoUnitario = 0.40;
            paoFrances.Unidade = "Unidade";
            paoFrances.Categoria = "Padaria";

            var compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = paoFrances;
            compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;
            
    
            using(var contexto = new LojaContext())
            {
                //nesse caso ele vai inserir os dois registros, tanto o pão como a compra
                //devido o Entity perceber que tem um produto associado 
                contexto.Compras.Add(compra);
                contexto.SaveChanges();
            }




 
            GravarUsandoAdoNet();
            GravarUsandoEntity();
            RecuperarProdutos();
            ExcluirProduto();
            AlterarProduto();
 
     private static void AlterarProduto()
        {
            //incluir um produto
            for (int i = 0; i < 10; i++)
            {
                GravarUsandoEntity();
            }

            //listar produto
            RecuperarProdutos();


            //atualizar produto

            using (var repo = new ProdutoDAOEntity())
            {
                //pegando o primeiro produto da tabela
                Produto primeroProduto = repo.Produtos().First();
                primeroProduto.Nome = "Cassino Royale - Editado";
                repo.Atualizar(primeroProduto);
            }

            //listar produto
            RecuperarProdutos();
        }

        private static void ExcluirProduto()
        {
            using(var repo = new ProdutoDAOEntity())
            {
                //pegando todos produtos
                IList<Produto> produtos = repo.Produtos();
                foreach (var item in produtos)
                {
                    //removendo todos produtos
                    repo.Remover(item);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using(var contexto = new ProdutoDAOEntity())
            {
                //devolve a lista de produtos do banco de dados
                IList<Produto> produtos = contexto.Produtos();
                Console.WriteLine("Quantidade de produtos -> " + produtos.Count);

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome + " " + item.Id);
                    Console.WriteLine();
                }
            }
            
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new ProdutoDAOEntity())
            {
                //salvando o produto no entity
                contexto.Adicionar(p);
            }
        }
 
     
*/
