using ProductAccountingInStockDatabase.DatabaseModels;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductAccountingInStockDatabase.Implements
{
    public class ProviderStorage : IProviderStorage
    {
        public List<ProviderViewModel> GetFullList()
        {
            using var context = new ProductAccountingInStockDatabase();
            return context.Providers
            .Select(CreateModel)
            .ToList();
        }
        public ProviderViewModel GetElement(ProviderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var post = context.Providers
            .FirstOrDefault(rec => rec.ProviderName == model.ProviderName || rec.Id == model.Id);
            return post != null ? CreateModel(post) : null;
        }
        public void Insert(ProviderBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            context.Providers.Add(CreateModel(model, new Provider()));
            context.SaveChanges();
        }
        public void Update(ProviderBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            var element = context.Providers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Поставщик не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(ProviderBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            Provider provider = context.Providers.FirstOrDefault(rec => rec.Id == model.Id);
            if (provider != null)
            {
                context.Providers.Remove(provider);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Поставщик не найден");
            }
        }
        private static Provider CreateModel(ProviderBindingModel model, Provider provider)
        {
            provider.ProviderName = model.ProviderName;
            provider.ProviderAddress = model.ProviderAddress;
            provider.ProviderPhone = model.ProviderPhone;
            return provider;
        }
        private static ProviderViewModel CreateModel(Provider provider)
        {
            return new ProviderViewModel
            {
                Id = provider.Id,
                ProviderName = provider.ProviderName, 
                ProviderAddress = provider.ProviderAddress, 
                ProviderPhone = provider.ProviderPhone
            };
        }
    }
}
