using System;
using System.Collections.Generic;

namespace ProductAccountingInStockModels.BindingModels
{
    public class ShipmentBindingModel
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProviderId { get; set; }
        public int DirectionShipmentId { get; set; }
        public decimal Sum { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Dictionary<int, (string, int)> ShipmentProducts { get; set; }
    }
}
