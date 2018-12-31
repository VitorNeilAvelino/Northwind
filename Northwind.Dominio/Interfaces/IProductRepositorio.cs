using Northwind.Dominio.Entidades;
using System.Collections.Generic;

namespace Northwind.Dominio.Interfaces
{
    public interface IProductRepositorio
    {
        List<ProductReadModel> Obter();
        void Inserir(Product product);
        void Excluir(int id);
        void Atualizar(Product product);
        ProductReadModel Obter(int id);
    }
}