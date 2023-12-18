using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IDirectionLogic
    {
        public List<DirectionViewModel> Read(DirectionBindingModel model);
        public void Create(DirectionBindingModel model);
        public void Delete(DirectionBindingModel model);
    }
}
