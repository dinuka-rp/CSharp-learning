using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCRUDApp.Shared
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }

        //public string Name { get; set; }
        [Required]
        public String Name { get; set; }
        //Description is optional in the frontend input & DB record
        public String Description { get; set; }
    }
}
