﻿using Northwind.Dominio.Entidades;
using Northwind.Dominio.Interfaces;
using Northwind.Repositorios.SqlServer;
using System;
using System.Collections.Generic;

namespace Northwind.Aplicacao
{
    public class ProductAplicacao : IDisposable
    {
        private readonly INorthwindUnitOfWork db;

        public ProductAplicacao(INorthwindUnitOfWork northwindUnitOfWork)
        {
            db = northwindUnitOfWork;
        }

        public ProductAplicacao()
        {
            db = new NorthwindUnitOfWork();
        }

        public List<ProductReadModel> Obter()
        {
            return db.Products.Obter();
        }

        public ProductReadModel Obter(int id)
        {
            return db.Products.Obter(id);
        }

        public void Inserir(Product product)
        {
            db.Products.Inserir(product);

            db.Salvar();
        }

        public void Atualizar(Product product)
        {
            db.Products.Atualizar(product);

            db.Salvar();
        }

        public void Excluir(int id)
        {
            db.Products.Excluir(id);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}