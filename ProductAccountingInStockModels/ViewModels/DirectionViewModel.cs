using System.ComponentModel;

namespace ProductAccountingInStockModels.ViewModels
{
    public class DirectionViewModel
    {
        public int Id { get; set; }
        [DisplayName("Направление поставки")]
        public string DirectionName { get; set; }
    }
}
