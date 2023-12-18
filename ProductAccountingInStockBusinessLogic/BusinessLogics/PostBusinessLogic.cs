using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class PostBusinessLogic : IPostLogic
    {
        private readonly IPostStorage _postStorage;

        public PostBusinessLogic(IPostStorage postStorage)
        {
            _postStorage = postStorage;
        }

        public List<PostViewModel> Read(PostBindingModel model)
        {
            if (model != null && model.Id.HasValue)
            {
                return new List<PostViewModel> { _postStorage.GetElement(model) };
            }
            return _postStorage.GetFullList();
        }

        public void Create(PostBindingModel model)
        {
            var element = _postStorage.GetElement(new PostBindingModel
            {
                PostName = model.PostName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая должность");
            }
            _postStorage.Insert(model);
        }

        public void Delete(PostBindingModel model)
        {
            var element = _postStorage.GetElement(new PostBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Должность не найдена");
            }
            _postStorage.Delete(model);
        }
    }
}
