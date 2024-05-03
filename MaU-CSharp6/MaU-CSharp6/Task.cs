namespace MaU_CSharp6
{
    internal class Task
    {
        private string description;
        private PriorityType priority;
        private DateTime date;

        public Task()
        { }

        public Task(string description, PriorityType priority, DateTime dateTime)
        {
            Description = description;
            Priority = priority;
            TaskDate = dateTime;
        }

        public string Description 
        {
            get { return description; }
            set 
            {
                if (value.IsNotNullOrEmpty())
                {
                    description = value;
                }
                else 
                {
                    description = "No Description";
                }
            }
        }
        public PriorityType Priority 
        { 
            get { return priority; } 
            set {  priority = value; } 
        }
        public DateTime TaskDate
        { 
            get { return date; }
            set { date = value; }
        }
    }
}
