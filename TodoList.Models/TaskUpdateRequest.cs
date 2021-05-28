using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models.Enums;

namespace TodoList.Models
{
    public class TaskUpdateRequest
    {
        public string Name { get; set; }

        public Priority Priority { get; set; }

    }
}
