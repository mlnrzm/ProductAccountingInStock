using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IEmployeeLogic
    {
        List<EmployeeViewModel> Read(EmployeeBindingModel model);
        void Create(EmployeeBindingModel model);
        void Delete(EmployeeBindingModel model);
        EmployeeViewModel Enter(EmployeeBindingModel model);
    }
}
