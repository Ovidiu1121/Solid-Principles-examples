using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._5
{
    public class debug
    {
        public debug()
        {
            ITaskRepository taskRepository = new InMemoryTaskRepository();
            TaskManager taskManager = new TaskManager(taskRepository);

            taskManager.AddTask("Complete project proposal");
            taskManager.AddTask("Send email to team members");
            taskManager.AddTask("Prepare presentation slides");

            List<Task> tasks = taskManager.GetAllTasks();
            foreach (Task task in tasks)
            {
                Console.WriteLine($"Task {task.Id}: {task.Description}, Completed: {task.IsCompleted}");
            }
        }
    }
}
