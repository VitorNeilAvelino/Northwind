using Northwind.Dominio.Entidades;
using System.Collections.Generic;

namespace Northwind.Dominio.Interfaces
{
    public interface IProductRepositorio
    {
        List<Product> Obter();
        void Inserir(Product product);
        void Excluir(int id);
        void Atualizar(Product product);
    }
}