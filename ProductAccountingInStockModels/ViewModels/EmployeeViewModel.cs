using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProductAccountingInStockModels.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public int SupervisorId { get; set; }
        public int PostId { get; set; }
        [DisplayName("Должность")]
        public string PostName { get; set; }
        [DisplayName("ФИО")]
        public string EmployeeFIO { get; set; }
        [DisplayName("Логин")]
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
    }
}
