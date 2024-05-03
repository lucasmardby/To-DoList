namespace MaU_CSharp6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager = new TaskManager();
        private Task currentTask = new Task();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lstToDo.Items.Clear();
            cmbPriority.DataSource = Enum.GetValues(typeof(PriorityType));
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "yyyy-MM-dd  HH:mm";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentTask.Description = txtToDo.Text;
            currentTask.Priority = (PriorityType)cmbPriority.SelectedItem;
            //currentTask.Date = dtpDateTime.;



        }
    }
}
