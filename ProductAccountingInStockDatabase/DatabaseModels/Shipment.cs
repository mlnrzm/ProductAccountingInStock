using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProductAccountingInStockModels;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    // Поставка продукции
    public class Shipment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        // Id поставщика (сущности не связаны,
        // Id нужен для определения адреса и возможной для отправки продукции) //
        public int ProviderId { get; set; }

        // Направление поставки //
        public int DirectionShipmentId { get; set; }

        // Статус отправления //
        [Required]
        public ShipmentStatus ShipmentStatus {  get; set; }

        // Общая стоимость поставки
        [Required]
        public decimal Sum { get; set; }

        // Дата формирования поставки //
        [Required]
        public DateTime DateCreate { get; set; }

        // Дата отправления/получения поставки //
        public DateTime? DateImplement { get; set; }

        // Поставляемая продукция //
        [ForeignKey("ShipmentId")]
        public virtual List<ShipmentProduct> ShipmentProducts { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual DirectionShipment DirectionShipment { get; set; }
    }
}
