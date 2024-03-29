﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        public int Id { get; set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTerminio { get; internal set; }
        public string Descricao { get; internal set; }
        public IList<PromocaoProduto> Produtos { get; internal set; }
        
        public void IncluirProduto(Produto produto)
        {
            this.Produtos.Add(new PromocaoProduto() { Produto = produto });
        }
    }
}
