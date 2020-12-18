namespace Interfaces.Classes
{
    public interface ICarrinho
    {
         //Criamos uma especie de "contrato" para deixar obrigatoria a 
         //Implementaçao de todos os metodos e estruturas que herdarem dessa interface

         void Listar();

         void cadastrar(Produto produto);

         void Alterar(int _codigo, Produto produto);

         void Deletar(Produto produto);
         

    }
}