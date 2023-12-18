using System;
using System.Collections.Generic;

namespace ProductAccountingInStockModels.ViewModels
{
    public class ReportShipmentProductsViewModel
    {
        public string ShipmentDirectionName { get; set; }
        public string ShipmentProviderName { get; set; }
        public string ShipmentAddress { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> ShipmentProducts { get; set; }
    }
}
