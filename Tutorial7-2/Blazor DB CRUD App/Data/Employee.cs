using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_DB_CRUD_App.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public String EmployeeName { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
        public String Designation { get; set; }
    }
}
