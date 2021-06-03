using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TodoList.Models;
using TodoList.Models.Enums;
using TodoListBlazorWasm.Services;

namespace TodoListBlazorWasm.Pages
{
    public partial class TaskList
    {
        [Inject] private ITaskApiClient TaskApiClient { set; get; }

        private List<TaskDto> Tasks;

        private List<AssigneeDto> Assignees;

        private TaskListSearch TaskListSearch = new TaskListSearch();

        protected override async Task OnInitializedAsync()
        {
            Tasks = await TaskApiClient.GetTaskList();
            Assignees = await TaskApiClient.GetAssignees();
        }
    }

    public class TaskListSearch
    {
        public string Name { get; set; }
        public string Assignee { set; get; }

        public Priority Priority { get; set; }
    }
}
