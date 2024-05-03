namespace MaU_CSharp6
{
    internal class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        { 
            tasks = new List<Task>();
        }

        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void ChangeTask(Task task, int index)
        {
            Tasks[index] = task;
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }

        public void RemoveTask(int index)
        {
            Tasks.Remove(GetTask(index));
        }

        public Task GetTask(int index)
        {
            return Tasks[index];
        }

        public string GetTaskDescription(int index)
        { 
            return Tasks[index].Description;
        }
        public PriorityType GetTaskPriority(int index)
        {
            return Tasks[index].Priority;
        }
        public string GetTaskDate(int index)
        {
            string year = Tasks[index].TaskDate.Year.ToString();
            string month = Tasks[index].TaskDate.Month.ToString();
            string day = Tasks[index].TaskDate.Day.ToString();

            return $"{day}-{month}-{year}";
        }
        public string GetTaskTime(int index)
        {
            return $"{Tasks[index].TaskDate.Hour}:{Tasks[index].TaskDate.Minute}";
        }
    }
}
