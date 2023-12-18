using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProductAccountingInStockModels.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        [DisplayName("Поставщик")]
        public string ProviderName { get; set; }
        [DisplayName("Наименование")]
        public string ProductName { get; set; }

        [DisplayName("Стоимость")]
        public int Cost { get; set; }
    }
}
