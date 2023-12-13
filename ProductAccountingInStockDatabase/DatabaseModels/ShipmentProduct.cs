using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    public class ShipmentProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ShipmentId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Shipment Shipment { get; set; }
        public virtual Product Product { get; set; }
    }
}
