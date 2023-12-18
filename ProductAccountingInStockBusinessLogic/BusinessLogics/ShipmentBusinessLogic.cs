using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class ShipmentBusinessLogic : IShipmentLogic
    {
        private readonly IShipmentStorage _shipmentStorage;
        public ShipmentBusinessLogic(IShipmentStorage shipmentStorage)
        {
            _shipmentStorage = shipmentStorage;
        }
        public List<ShipmentViewModel> Read(ShipmentBindingModel model)
        {
            if (model == null)
            {
                return _shipmentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ShipmentViewModel> { _shipmentStorage.GetElement(model) };
            }
            return _shipmentStorage.GetFilteredList(model);
        }
        public void CreateShipment(CreateShipmentBindingModel model)
        {
            _shipmentStorage.Insert(new ShipmentBindingModel
            {
                ProviderId = model.ProviderId,
                EmployeeId = model.EmployeeId,
                DirectionShipmentId = model.DirectionShipmentId,
                DateCreate = DateTime.Now,
                Sum = model.Sum,
                ShipmentProducts = model.ShipmentProducts
            });
        }
        public void DeliveryShipment(ChangeShipmentStatusBindingModel model)
        {
            var element = _shipmentStorage.GetElement(new ShipmentBindingModel
            {
                Id = model.ShipmentId
            });

            if (element == null)
            {
                throw new Exception("Поставка не найдена");
            }

            if (element.ShipmentStatus == ShipmentStatus.Доставляется) { element.ShipmentStatus = ShipmentStatus.Прибыла; }
            else throw new Exception("Поставка не доставляется или уже прибыла");

            _shipmentStorage.Update(new ShipmentBindingModel
            {
                Id = element.Id,
                ProviderId = element.ProviderId,
                EmployeeId = element.EmployeeId,
                DirectionShipmentId = element.DirectionShipmentId,
                DateCreate = element.DateCreate,
                DateImplement = DateTime.Now,
                Sum = element.Sum,
                ShipmentStatus = element.ShipmentStatus
            });

        }
        public void FinishShipment(ChangeShipmentStatusBindingModel model)
        {
            var element = _shipmentStorage.GetElement(new ShipmentBindingModel
            {
                Id = model.ShipmentId
            });

            if (element == null)
            {
                throw new Exception("Заказ не найден");
            }

            if (element.ShipmentStatus == ShipmentStatus.Отправлена) { element.ShipmentStatus = ShipmentStatus.Доставляется; }
            else throw new Exception("Заказ не может быть готов");

            _shipmentStorage.Update(new ShipmentBindingModel
            {
                Id = element.Id,
                ProviderId = element.ProviderId,
                EmployeeId = element.EmployeeId,
                DirectionShipmentId = element.DirectionShipmentId,
                DateCreate = element.DateCreate,
                DateImplement = element.DateImplement,
                Sum = element.Sum,
                ShipmentStatus = element.ShipmentStatus
            });
        }
        public void TakeShipmentInWork(ChangeShipmentStatusBindingModel model)
        {
            var element = _shipmentStorage.GetElement(new ShipmentBindingModel
            {
                Id = model.ShipmentId
            });

            if (element == null)
            {
                throw new Exception("Поставка не найдена");
            }

            if (element.ShipmentStatus == ShipmentStatus.Оформлена) { element.ShipmentStatus = ShipmentStatus.Отправлена; }
            else throw new Exception("Невозможно отправить поставку");

            _shipmentStorage.Update(new ShipmentBindingModel
            {
                Id = element.Id,
                ProviderId = element.ProviderId,
                EmployeeId = element.EmployeeId,
                DirectionShipmentId = element.DirectionShipmentId,
                DateCreate = element.DateCreate,
                DateImplement = element.DateImplement,
                Sum = element.Sum,
                ShipmentStatus = element.ShipmentStatus
            });
        }
    }
}
