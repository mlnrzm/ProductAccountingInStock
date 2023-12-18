using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockModels.BindingModels
{
    public class EmployeeBindingModel
    {
        public int? Id { get; set; }
        public int PostId { get; set; }
        public int? SupervisorId { get; set; }
        public string EmployeeFIO { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
    }
}
