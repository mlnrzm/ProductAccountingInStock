using System.ComponentModel;

namespace ProductAccountingInStockModels.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [DisplayName("Должность сотрудника")]
        public string PostName { get; set; }
    }
}
