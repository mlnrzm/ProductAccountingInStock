using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class ProviderBusinessLogic : IProviderLogic
    {
        private readonly IProviderStorage _providerStorage;

        public ProviderBusinessLogic(IProviderStorage providerStorage)
        {
            _providerStorage = providerStorage;
        }

        public List<ProviderViewModel> Read(ProviderBindingModel model)
        {
            if (model != null && model.Id.HasValue)
            {
                return new List<ProviderViewModel> { _providerStorage.GetElement(model) };
            }
            return _providerStorage.GetFullList();
        }

        public void CreateOrUpdate(ProviderBindingModel model)
        {
            var element = _providerStorage.GetElement(new ProviderBindingModel
            {
                ProviderName = model.ProviderName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Поставщик уже существует");
            }
            if (model.Id.HasValue)
            {
                _providerStorage.Update(model);
            }
            else
            {
                _providerStorage.Insert(model);
            }
        }

        public void Delete(ProviderBindingModel model)
        {
            var element = _providerStorage.GetElement(new ProviderBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Поставщик не найден");
            }
            _providerStorage.Delete(model);
        }
    }
}
