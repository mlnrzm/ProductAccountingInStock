using ProductAccountingInStockDatabase.DatabaseModels;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using ProductAccountingInStockDatabase.StoragesContracts;

namespace ProductAccountingInStockDatabase.Implements
{
    public class ProductStorage : IProductStorage
    {
        public List<ProductViewModel> GetFullList()
        {
            using var context = new ProductAccountingInStockDatabase();
            return context.Products
            .Select(CreateModel)
            .ToList();
        }
        public List<ProductViewModel> GetFilteredList(ProductBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            return context.Products
            .Where(rec => rec.ProviderId == model.ProviderId)
            .Select(CreateModel)
            .ToList();
        }
        public ProductViewModel GetElement(ProductBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var component = context.Products
            .FirstOrDefault(rec => rec.ProductName == model.ProductName || rec.Id == model.Id);
            return component != null ? CreateModel(component) : null;
        }
        public void Insert(ProductBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            context.Products.Add(CreateModel(model, new Product()));
            context.SaveChanges();
        }
        public void Update(ProductBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            var element = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Продукция не найдена");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(ProductBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            Product element = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Products.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Продукция не найдена");
            }
        }
        private static Product CreateModel(ProductBindingModel model, Product component)
        {
            component.ProductName = model.ProductName;
            component.ProviderId = model.ProviderId;
            component.Cost = model.Cost;
            return component;
        }
        private static ProductViewModel CreateModel(Product component)
        {
            return new ProductViewModel
            {
                Id = component.Id,
                ProviderId = component.ProviderId,
                ProductName = component.ProductName,
                Cost = component.Cost
            };
        }
    }
}
