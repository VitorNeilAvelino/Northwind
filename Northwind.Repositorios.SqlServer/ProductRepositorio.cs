using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Northwind.Dominio.Entidades;
using Northwind.Dominio.Interfaces;
using AutoMapper.QueryableExtensions;

namespace Northwind.Repositorios.SqlServer
{
    internal class ProductRepositorio : IProductRepositorio
    {
        private readonly NorthwindDbContext dbContext;

        public ProductRepositorio(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Atualizar(Product product)
        {
            dbContext.Entry(product).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            var product = dbContext.Products.Find(id);

            dbContext.Products.Remove(product);
        }

        public void Inserir(Product product)
        {
            dbContext.Products.Add(product);
        }

        public List<ProductReadModel> Obter()
        {
            return dbContext.Products
                .ProjectTo<ProductReadModel>()
                .OrderBy(p => p.ProductName)
                .ToList();
        }

        public ProductReadModel Obter(int id)
        {
            return dbContext.Products
                .ProjectTo<ProductReadModel>()
                .SingleOrDefault(p => p.ProductID == id);
        }
    }
}