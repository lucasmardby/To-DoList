namespace MaU_CSharp6
{
    internal class FileManager
    {
        private TaskManager taskManager = new TaskManager();

        private void Test()
        {
            string path = @"c:\temp\Test.txt";

            if (File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Test");
                }
            }
            
        }
    }
}
