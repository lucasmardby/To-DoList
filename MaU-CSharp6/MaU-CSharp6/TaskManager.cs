namespace MaU_CSharp6
{
    internal class TaskManager
    {
        private List<Task> tasks;

        private int numOfTasks = 0;

        public TaskManager()
        { 
            tasks = new List<Task>();
        }

        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
    }
}
