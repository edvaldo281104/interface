using System;
using Interfaces.Classes;

namespace Interfaces 
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho =  new Carrinho();

            Produto p1 = new Produto();

            p1.Codigo  = 325;
            p1.Nome    = "geladeira";
            p1.Preco   = 25000;
            
            Produto p2 = new Produto();
            p2.Codigo  = 326;
            p2.Nome    ="fogao";
            p2.Preco   = 1200;

            Produto p3 = new Produto();
            p3. Codigo = 327;
            p3.Nome    = "televisao 4k";
            p3.Preco   = 3200;

            carrinho.cadastrar(p1);
            carrinho.Listar();
            carrinho.cadastrar(p2);
            carrinho.Listar();
            
            carrinho.Alterar(p1.Codigo ,p3);
            carrinho.Listar();


        }
    }
}
