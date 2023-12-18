using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IProductLogic
    {
        List<ProductViewModel> Read(ProductBindingModel model);
        void CreateOrUpdate(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}