using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockDatabase.StoragesContracts
{
    public interface IProviderStorage
    {
        List<ProviderViewModel> GetFullList();
        ProviderViewModel GetElement(ProviderBindingModel model);
        void Insert(ProviderBindingModel model);
        void Update(ProviderBindingModel model);
        void Delete(ProviderBindingModel model);
    }
}
