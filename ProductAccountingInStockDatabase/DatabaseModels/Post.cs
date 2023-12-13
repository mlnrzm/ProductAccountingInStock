using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockDatabase.DatabaseModels
{
    // Должность на складе //
    public class Post
    {
        public int Id { get; set; }

        // Наименование должности //
        [Required]
        public string PostName { get; set; }

        // Сотрудники должности //
        [ForeignKey("PostId")]
        public virtual List<Employee> Employees { get; set; }
    }
}
