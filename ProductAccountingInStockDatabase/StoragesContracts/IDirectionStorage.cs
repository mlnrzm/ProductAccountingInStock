using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockDatabase.StoragesContracts
{
    public interface IDirectionStorage
    {
        List<DirectionViewModel> GetFullList();
        DirectionViewModel GetElement(DirectionBindingModel model);
        void Insert(DirectionBindingModel model);
        void Delete(DirectionBindingModel model);
    }
}
