using System.ComponentModel.DataAnnotations;

namespace Northwind.Aplicacao.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal? UnitPrice { get; set; }

        [Required]
        public short? UnitsInStock { get; set; }
    }
}
