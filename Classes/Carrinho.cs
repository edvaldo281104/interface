using System;
using System.Collections.Generic;

namespace Interfaces.Classes
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();
        
        
        public void Alterar(int _codigo, Produto produto)
        {
            //Lampda
            // -- produto
            //123
            //playstation 5
            // R$ 10.000
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
          carrinho.Remove(produto);
        }

        public void Listar()
        {
          foreach(Produto itemCarrinho in carrinho){
              Console.WriteLine($"produto : {itemCarrinho.Nome} \n Preco: R${itemCarrinho.Preco} \n Codigo: {itemCarrinho.Codigo}");
          }
        }
    }
}