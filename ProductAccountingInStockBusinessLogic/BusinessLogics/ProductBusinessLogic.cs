using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class ProductBusinessLogic : IProductLogic
    {
        private readonly IProductStorage _productStorage;
        public ProductBusinessLogic(IProductStorage productStorage)
        {
            _productStorage = productStorage;
        }
        public List<ProductViewModel> Read(ProductBindingModel model)
        {
            if (model == null)
            {
                return _productStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ProductViewModel> { _productStorage.GetElement(model) };
            }
            return _productStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ProductBindingModel model)
        {
            var element = _productStorage.GetElement(new ProductBindingModel
            {
                ProductName = model.ProductName,
                ProviderId = model.ProviderId
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Продукция с таким наименованием уже есть у данного поставщика");
            }
            if (model.Id.HasValue)
            {
                _productStorage.Update(model);
            }
            else
            {
                _productStorage.Insert(model);
            }
        }
        public void Delete(ProductBindingModel model)
        {
            var element = _productStorage.GetElement(new ProductBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Продукция не найдена");
            }
            _productStorage.Delete(model);
        }
    }
}
