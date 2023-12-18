using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    // Сотрудник склада //
    public class Employee
    {
        public int Id { get; set; }

        // Id должности сотрудника //
        public int PostId { get; set; }

        // Id руководителя, который добавил сотрудника //
        public int? SupervisorId { get; set; }

        // ФИО сотрудника //
        [Required]
        public string EmployeeFIO { get; set; }

        // Логин сотрудника //
        [Required]
        public string EmployeeLogin { get; set; }

        // Пароль сотрудника //
        [Required]
        public string EmployeePassword { get; set; }
        public virtual Post EmployeePost { get; set; }

        // Поставки, за которые несет ответственность сотрудник //

        [ForeignKey("EmployeeId")]
        public virtual List<Shipment> Shipments { get; set; }
    }
}
