namespace Northwind.Aplicacao.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }
    }
}