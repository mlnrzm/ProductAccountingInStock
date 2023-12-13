using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    // Поставщик продукции //
    public class Provider
    {
        public int Id { get; set; }

        // Наименование организации (поставщика) //
        [Required]
        public string ProviderName { get; set; }

        // Адрес поставщика //
        [Required]
        public string ProviderAddress { get; set; }

        // Телефон поставщика //
        [Required]
        public string ProviderPhone { get; set; }

        // Продукция, поставляемая данным поставщиком //
        [ForeignKey("ProviderId")]
        public virtual List<Product> Products { get; set; }
    }
}
