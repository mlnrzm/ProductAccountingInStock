using System;
using System.Collections.Generic;

namespace ProductAccountingInStockModels.BindingModels
{
    public class ReportBindingModel
    {
        public string FileName { get; set; }
        public List<ShipmentBindingModel> shipments { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
