namespace MaU_CSharp6
{
    internal class FileManager
    {
        private TaskManager taskManager = new TaskManager();

        private const string fileVersionToken = "ToDoRe_24";
        private const double fileVersionNumber = 1.0;

        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        { 
            bool ok = true;
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNumber);
                writer.WriteLine(taskList.Count);

                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].TaskDate.Year);
                    writer.WriteLine(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            }
            catch (Exception ex)
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return ok;
        }

        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;

            try
            {
                if (taskList != null)
                    taskList.Clear();
                else
                    taskList = new List<Task>();

                reader = new StreamReader(fileName);

                string versionTest = reader.ReadLine();
                double version = double.Parse(reader.ReadLine());

                if ((versionTest == fileVersionToken) && (version == fileVersionNumber))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.TaskDate = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(task);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch
            {
                ok = false;
            }
            finally
            { 
                if (reader != null)
                    reader.Close();
            }
            return ok;
        }
    }
}
