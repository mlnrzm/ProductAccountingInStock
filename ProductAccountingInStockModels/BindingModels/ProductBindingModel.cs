using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProductAccountingInStockModels.BindingModels
{
    public class ProductBindingModel
    {
        public int? Id { get; set; }
        public int ProviderId { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
    }
}
