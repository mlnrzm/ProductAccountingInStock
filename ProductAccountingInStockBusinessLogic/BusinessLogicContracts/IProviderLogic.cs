using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IProviderLogic
    {
        List<ProviderViewModel> Read(ProviderBindingModel model);
        void CreateOrUpdate(ProviderBindingModel model);
        void Delete(ProviderBindingModel model);
    }
}