using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String ContractTypeName { get; set; }
        public Int32 RoleId { get; set; }
        public String RoleName { get; set; }
        public String RoleDescription { get; set; }
        public Decimal hourlySalary { get; set; }
        public Decimal monthlySalary { get; set; }
    }
}
