namespace Northwind.Dominio.Interfaces
{
    public interface INorthwindUnitOfWork
    {
        IProductRepositorio Products { get; }

        void Salvar();
        void Dispose();
    }
}