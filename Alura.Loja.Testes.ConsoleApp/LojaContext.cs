using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    //tem que por o sufixo Context, em seguida herdar a classe DbContext
    internal class LojaContext : DbContext
    {
        //classe que serão persistida pelo Entity, o DbSet se resposabiliza por isso, em seguida sera o nome da 
        //tabela no banco no caso será Produtos (pois criei anteriormente)
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        


        //a linha a baixo permite que possamos adicionar chave compostas nas tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromocaoProduto>().HasKey(pp => new { pp.ProdutoId, pp.PromocaoId });

            //criando um campo na tabela, sendo escondido da class Endereco, ou seja não estou persistindo ela no DB
            modelBuilder.Entity<Endereco>().ToTable("Enderecos");
            
            modelBuilder.Entity<Endereco>().Property<int>("ClienteId");

            modelBuilder.Entity<Endereco>().HasKey("ClienteId");

            //base.OnModelCreating(modelBuilder);
        }

        //a linha abaixo, sera definido o banco e onde ele fica, é feito no evento de configuracao
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            
        }
    }
}