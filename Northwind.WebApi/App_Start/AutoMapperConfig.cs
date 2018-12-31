using AutoMapper;
using Northwind.Aplicacao.ViewModels;

namespace Northwind.WebApi.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
        }
    }
}