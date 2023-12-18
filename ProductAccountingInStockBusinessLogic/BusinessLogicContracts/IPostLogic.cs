using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IPostLogic
    {
        List<PostViewModel> Read(PostBindingModel model);
        void Create(PostBindingModel model);
        void Delete(PostBindingModel model);
    }
}