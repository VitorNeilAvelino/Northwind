using AutoMapper;
using Northwind.Aplicacao;
using Northwind.Aplicacao.ViewModels;
using Northwind.Dominio.Entidades;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Northwind.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ProductAplicacao aplicacao = new ProductAplicacao();

        public IEnumerable<ProductViewModel> Get()
        {
            var products = Mapper.Map<List<ProductReadModel>, List<ProductViewModel>>(aplicacao.Obter());

            return products;
        }

        public IHttpActionResult Get(int id)
        {
            var product = aplicacao.Obter(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        public IHttpActionResult Post(ProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = Mapper.Map<ProductViewModel, Product>(viewModel);

            aplicacao.Inserir(product);

            viewModel.ProductID = product.ProductID;

            return CreatedAtRoute("DefaultApi", new { id = viewModel.ProductID }, viewModel);
        }

        public IHttpActionResult Put(int id, ProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != viewModel.ProductID)
            {
                return BadRequest("Id do Produto ausente na rota ou diferente do Produto que está sendo editado.");
            }

            var product = Mapper.Map<ProductViewModel, Product>(viewModel);

            aplicacao.Atualizar(product);

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult Delete(int id)
        {
            var product = aplicacao.Obter(id);

            if (product == null)
            {
                return NotFound();
            }

            aplicacao.Excluir(id);

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            aplicacao.Dispose();

            base.Dispose(disposing);
        }
    }
}