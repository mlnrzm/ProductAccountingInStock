using ProductAccountingInStockDatabase.DatabaseModels;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductAccountingInStockDatabase.Implements
{
    public class DirectionStorage : IDirectionStorage
    {
        public List<DirectionViewModel> GetFullList()
        {
            using var context = new ProductAccountingInStockDatabase();
            return context.DirectionShipments
            .Select(CreateModel)
            .ToList();
        }
        public DirectionViewModel GetElement(DirectionBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var ds = context.DirectionShipments
            .FirstOrDefault(rec => rec.DirectionName.Contains(model.DirectionName) || rec.Id == model.Id);
            return ds != null ? CreateModel(ds) : null;
        }
        public void Insert(DirectionBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            context.DirectionShipments.Add(CreateModel(model, new DirectionShipment()));
            context.SaveChanges();
        }
        public void Delete(DirectionBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            DirectionShipment ds = context.DirectionShipments.FirstOrDefault(rec => rec.Id == model.Id);
            if (ds != null)
            {
                context.DirectionShipments.Remove(ds);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Направление не найдено");
            }
        }
        private static DirectionShipment CreateModel(DirectionBindingModel model, DirectionShipment ds)
        {
            ds.DirectionName = model.DirectionName;
            return ds;
        }
        private static DirectionViewModel CreateModel(DirectionShipment ds)
        {
            return new DirectionViewModel
            {
                Id = ds.Id,
                DirectionName = ds.DirectionName
            };
        }
    }
}
