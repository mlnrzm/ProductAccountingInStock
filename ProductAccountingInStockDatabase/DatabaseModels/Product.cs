using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    // Продукция //
    public class Product
    {
        public int Id { get; set; }

        // Id поставщика //
        public int ProviderId { get; set; }

        // Наименование продукции //
        [Required]
        public string ProductName { get; set; }

        // Стоимость единицы продукции //
        [Required]
        public int Cost { get; set; }

        // Поставки данной продукции //
        [ForeignKey("ProductId")]
        public virtual List<ShipmentProduct> ShipmentProducts { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
