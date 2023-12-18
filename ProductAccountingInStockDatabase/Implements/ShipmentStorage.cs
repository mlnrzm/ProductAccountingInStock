using Microsoft.EntityFrameworkCore;
using ProductAccountingInStockDatabase.DatabaseModels;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockDatabase.Implements
{
    public class ShipmentStorage : IShipmentStorage
    {
        public List<ShipmentViewModel> GetFullList()
        {
            using var context = new ProductAccountingInStockDatabase();
            return context.Shipments
            .Include(rec => rec.ShipmentProducts)
            .ThenInclude(rec => rec.Product)
            .ToList()
            .Select(CreateModel)
            .ToList();
        }
        public List<ShipmentViewModel> GetFilteredList(ShipmentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            return context.Shipments
            .Include(rec => rec.ShipmentProducts)
            .ThenInclude(rec => rec.Product)
            .Where(rec => rec.EmployeeId == model.EmployeeId ||
               (model.DateFrom.HasValue && model.DateTo.HasValue && 
               rec.DateCreate >= model.DateFrom && 
               rec.DateCreate <= model.DateTo))
            .ToList()
            .Select(CreateModel)
            .ToList();
        }
        public ShipmentViewModel GetElement(ShipmentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var product = context.Shipments
            .Include(rec => rec.ShipmentProducts)
            .ThenInclude(rec => rec.Product)
            .FirstOrDefault(rec => rec.Id == model.Id);
            return product != null ? CreateModel(product) : null;
        }
        public void Insert(ShipmentBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                Shipment shipment_to_add = CreateModel(model, new Shipment(), context);
                context.Shipments.Add(shipment_to_add);
                context.SaveChanges();

                foreach (var pc in model.ShipmentProducts)
                {
                    context.ShipmentProducts.Add(new ShipmentProduct
                    {
                        ShipmentId = shipment_to_add.Id,
                        ProductId = pc.Key,
                        Count = pc.Value.Item2
                    });
                    context.SaveChanges();
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Update(ShipmentBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Shipments.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Поставка не найдена");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(ShipmentBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            Shipment element = context.Shipments.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Shipments.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Поставка не найдена");
            }
        }
        private static Shipment CreateModel(ShipmentBindingModel model, Shipment shipment, ProductAccountingInStockDatabase context)
        {
            shipment.EmployeeId = model.EmployeeId;
            shipment.ProviderId = model.ProviderId;
            shipment.DirectionShipmentId = model.DirectionShipmentId;
            shipment.ShipmentStatus = model.ShipmentStatus;
            shipment.Sum = model.Sum;
            shipment.DateCreate = model.DateCreate;
            shipment.DateImplement = model.DateImplement;

            if (model.Id.HasValue)
            {
                var productComponents = context.ShipmentProducts.Where(rec => rec.ShipmentId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                if (model.ShipmentProducts != null)
                {
                    context.ShipmentProducts.RemoveRange(productComponents.Where(rec =>
                        !model.ShipmentProducts.ContainsKey(rec.ProductId)).ToList());
                    context.SaveChanges();
                    // обновили количество у существующих записей
                    foreach (var updateComponent in productComponents)
                    {
                        updateComponent.Count =
                       model.ShipmentProducts[updateComponent.ProductId].Item2;
                        model.ShipmentProducts.Remove(updateComponent.ProductId);
                    }
                    context.SaveChanges();
                    // добавили новые
                    foreach (var pc in model.ShipmentProducts)
                    {
                        context.ShipmentProducts.Add(new ShipmentProduct
                        {
                            ShipmentId = shipment.Id,
                            ProductId = pc.Key,
                            Count = pc.Value.Item2
                        });
                        context.SaveChanges();
                    }
                }
            }
            return shipment;
        }
        private static ShipmentViewModel CreateModel(Shipment shipment)
        {
            using var context = new ProductAccountingInStockDatabase();
            return new ShipmentViewModel
            {
                Id = shipment.Id,
                EmployeeId = shipment.EmployeeId,
                ProviderId = shipment.ProviderId,
                DirectionShipmentId = shipment.DirectionShipmentId,
                DirectionShipmentName = context.DirectionShipments.FirstOrDefault(rec => rec.Id == shipment.DirectionShipmentId).DirectionName,
                EmployeeName = context.Employees.FirstOrDefault(rec => rec.Id == shipment.EmployeeId).EmployeeFIO,
                ProviderAddress = context.Providers.FirstOrDefault(rec => rec.Id == shipment.ProviderId).ProviderAddress,
                ShipmentStatus = shipment.ShipmentStatus,
                Sum = shipment.Sum,
                DateCreate = shipment.DateCreate,
                DateImplement = shipment.DateImplement,
                ShipmentProducts = shipment.ShipmentProducts
                    .ToDictionary(recPC => recPC.ProductId, recPC => (recPC.Product?.ProductName, recPC.Count))
            };
        }
    }
}
