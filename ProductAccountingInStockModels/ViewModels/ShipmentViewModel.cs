using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProductAccountingInStockModels.ViewModels
{
    public class ShipmentViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [DisplayName("Ответственный")]
        public string EmployeeName { get; set; }
        public int ProviderId { get; set; }
        [DisplayName("Адрес")]
        public string ProviderAddress { get; set; }
        public int DirectionShipmentId { get; set; }
        [DisplayName("Тип поставки")]
        public string DirectionShipmentName { get; set; }
        [DisplayName("Статус")]
        public ShipmentStatus ShipmentStatus { get; set; }
        [DisplayName("Стоимость")]
        public decimal Sum { get; set; }
        [DisplayName("Дата формирования поставки")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата отправления/получения поставки")]
        public DateTime? DateImplement { get; set; }
        public Dictionary<int, (string, int)> ShipmentProducts { get; set; }
    }
}
