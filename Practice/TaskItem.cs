namespace Practice
{
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; private set; } = false;


        public void Completed()
        {
            IsCompleted = true;
        }
    }


    public class TaskManager
    {
        private List<TaskItem> _tasks = new List<TaskItem>();

        public void AddTask(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title is empty");
            }
            else
            {
                _tasks.Add(new TaskItem
                {
                    Title = title


                });
            }

        }

        public void RemoveTask(string title)
        {
            bool found = false;

            for (int i = 0; i < _tasks.Count; i++)
            {

                if (title == _tasks[i].Title)
                {
                    _tasks.RemoveAt(i);
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Task doesnt exist");
            }

        }

        public void CompleteTask(string title)
        {
            bool found = false;

            foreach (var task in _tasks)
            {
                if (title == task.Title)
                {
                    task.Completed();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Task doesnt exist");
            }
        }

        public void DisplayTasks()
        {
            foreach (var task in _tasks)
            {
                string status = task.IsCompleted ? "Completed" : "Not completed";

                Console.WriteLine($"{task.Title} - {status}");
            }
        }
    }
}
