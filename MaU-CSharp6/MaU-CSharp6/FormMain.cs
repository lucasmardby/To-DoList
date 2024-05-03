namespace MaU_CSharp6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager = new TaskManager();
        private Task currentTask;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lstToDo.Items.Clear();
            txtToDo.Text = string.Empty;
            cmbPriority.DataSource = Enum.GetValues(typeof(PriorityType));
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "yyyy-MM-dd  HH:mm";

            UpdateButtonVisibility();
        }

        private void UpdateGUI()
        {
            txtToDo.Text = string.Empty;
            cmbPriority.SelectedIndex = 0;

            UpdateTaskList();

            UpdateButtonVisibility();
        }

        private void UpdateTaskList()
        {
            lstToDo.Items.Clear();

            for (var i = 0; i < taskManager.Tasks.Count(); i++)
            {
                string listboxString = string.Format("{0,-5} {1,40} {2,30} {3,20}",
                    taskManager.GetTaskDate(i), taskManager.GetTaskTime(i),
                    taskManager.GetTaskPriority(i), taskManager.GetTaskDescription(i));

                lstToDo.Items.Add(listboxString);
            }

        }

        private void UpdateButtonVisibility()
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtToDo.Text.Trim();
            PriorityType priority = (PriorityType)cmbPriority.SelectedItem;
            DateTime taskDate = dtpDateTime.Value;

            currentTask = new Task(description, priority, taskDate);

            taskManager.AddTask(currentTask);

            UpdateGUI();

            currentTask = new Task();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstToDo.SelectedIndex;

            if (index >= 0)
            {
                currentTask = taskManager.GetTask(index);

                if (currentTask != null)
                {
                    taskManager.ChangeTask(currentTask, index);
                }
            }

            UpdateGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstToDo.SelectedIndex >= 0)
            {
                taskManager.RemoveTask(lstToDo.SelectedIndex);
                lstToDo.Items.Remove(lstToDo.SelectedItem);
            }

            UpdateButtonVisibility();
        }

        private void lstToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
        }
    }
}
