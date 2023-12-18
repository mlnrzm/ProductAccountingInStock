using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockDatabase.StoragesContracts
{
    public interface IPostStorage
    {
        List<PostViewModel> GetFullList();
        PostViewModel GetElement(PostBindingModel model);
        void Insert(PostBindingModel model);
        void Delete(PostBindingModel model);
    }
}
