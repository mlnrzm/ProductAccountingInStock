using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class DirectionBusinessLogic : IDirectionLogic
    {
        private readonly IDirectionStorage _directionStorage;

        public DirectionBusinessLogic(IDirectionStorage directionStorage)
        {
            _directionStorage = directionStorage;
        }

        public List<DirectionViewModel> Read(DirectionBindingModel model)
        {
            if (model != null && model.Id.HasValue)
            {
                return new List<DirectionViewModel> { _directionStorage.GetElement(model) };
            }
            return _directionStorage.GetFullList();
        }

        public void Create(DirectionBindingModel model)
        {
            var element = _directionStorage.GetElement(new DirectionBindingModel
            {
                DirectionName = model.DirectionName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такое направление");
            }
            _directionStorage.Insert(model);
        }

        public void Delete(DirectionBindingModel model)
        {
            var element = _directionStorage.GetElement(new DirectionBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Направление не найдено");
            }
            _directionStorage.Delete(model);
        }
    }
}
