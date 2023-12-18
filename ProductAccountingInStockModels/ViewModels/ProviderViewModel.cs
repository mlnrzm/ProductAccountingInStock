using System.Collections.Generic;
using System.ComponentModel;

namespace ProductAccountingInStockModels.ViewModels
{
    public class ProviderViewModel
    {
        public int Id { get; set; }

        [DisplayName("Поставщик")]
        public string ProviderName { get; set; }
        [DisplayName("Адрес")]
        public string ProviderAddress { get; set; }
        [DisplayName("Телефон")]
        public string ProviderPhone { get; set; }
    }
}
