using Northwind.Dominio.Interfaces;
using System;

namespace Northwind.Repositorios.SqlServer
{
    public class NorthwindUnitOfWork : IDisposable, INorthwindUnitOfWork
    {
        private readonly NorthwindDbContext dbContext = new NorthwindDbContext();
        private IProductRepositorio products;

        public IProductRepositorio Products
        {
            get { return products ?? (products = new ProductRepositorio(dbContext)); }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public void Salvar()
        {
            dbContext.SaveChanges();
        }
    }
}