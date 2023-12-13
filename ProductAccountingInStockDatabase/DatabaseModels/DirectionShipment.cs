using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    // Направление поставки (со склада или на склад) //
    public class DirectionShipment
    {
        public int Id { get; set; }

        // Направление отправления //
        public string DirectionName { get; set; }

        // Отправления по данному направлению //
        [ForeignKey("DirectionShipmentId")]
        public virtual List<Shipment> Shipments { get; set; }
    }
}
