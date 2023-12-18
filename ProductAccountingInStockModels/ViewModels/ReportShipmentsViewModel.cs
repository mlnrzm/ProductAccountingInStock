using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockModels.ViewModels
{
    public class ReportShipmentsViewModel
    {
        public DateTime DateCreate { get; set; }
        public string ShipmentDirectionName { get; set; }
        public decimal Sum { get; set; }
        public string Status { get; set; }
    }
}
