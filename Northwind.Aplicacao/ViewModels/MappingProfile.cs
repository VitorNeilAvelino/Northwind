using AutoMapper;
using Northwind.Dominio.Entidades;

namespace Northwind.Aplicacao.ViewModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductReadModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}