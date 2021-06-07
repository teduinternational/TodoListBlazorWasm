using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class AssignTaskRequest
    {
        public Guid? UserId { get; set; }
    }
}
