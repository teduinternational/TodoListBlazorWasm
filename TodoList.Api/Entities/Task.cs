using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Api.Enums;

namespace TodoList.Api.Entities
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid? Assignee { get; set; }

        public DateTime CreatedDate { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }

    }
}
