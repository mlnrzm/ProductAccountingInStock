using System.Collections.Generic;

namespace ProductAccountingInStockModels.BindingModels
{
    public class CreateShipmentBindingModel
    {
        public int EmployeeId { get; set; }
        public int ProviderId { get; set; }
        public int DirectionShipmentId { get; set; }
        public decimal Sum { get; set; }
        public Dictionary<int, (string, int)> ShipmentProducts { get; set; }
    }
}