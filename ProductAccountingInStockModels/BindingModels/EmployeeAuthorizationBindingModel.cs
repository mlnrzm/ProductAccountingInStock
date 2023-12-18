using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockModels.BindingModels
{
    public class EmployeeAuthorizationBindingModel
    {
        public int? Id { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
    }
}
