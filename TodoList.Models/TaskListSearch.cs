using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models.Enums;
using TodoList.Models.SeedWork;

namespace TodoList.Models
{
    public class TaskListSearch : PagingParameters
    {
        public string Name { get; set; }

        public Guid? AssigneeId { get; set; }

        public Priority? Priority { get; set; }
    }
}
