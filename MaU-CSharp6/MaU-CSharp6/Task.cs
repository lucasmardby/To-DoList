namespace MaU_CSharp6
{
    internal class Task
    {
        private string description;
        private PriorityType priority;
        private DateTime date;

        public Task()
        { 
            
        }


        public string Description 
        {
            get { return description; }
            set { description = value; }
        }
        public PriorityType Priority 
        { 
            get { return priority; } 
            set {  priority = value; } 
        }
        public DateTime Date
        { 
            get { return date; }
            set { date = value; }
        }
    }
}
