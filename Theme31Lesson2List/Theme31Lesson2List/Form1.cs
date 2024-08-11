using System.Threading.Tasks;

namespace Theme31Lesson2List
{
    public partial class Form1 : Form
    {
        private TaskList tasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new TaskList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                string name = listBoxTasks.SelectedItem!.ToString()!;
                tasks.RemoveTask(name);
                UpdateForm();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask();
            UpdateForm();
        }
        private void AddTask()
        {
            if (textBoxName.Text.Length != 0)
            {
                Task task = new Task(textBoxName.Text, dateTimePicker1.Value, textBoxDescription.Text);
                tasks.Addtask(task);
                listBoxTasks.Items.Add(task.GetName());
                listBoxDate.Items.Add(task.GetDate());
            }
        }
        private void UpdateForm()
        {
            listBoxTasks.Items.Clear();
            listBoxDate.Items.Clear();
            textBoxDescription.Clear();
            textBoxName.Clear();
            foreach (Task task in tasks.GetTasks())
            {
                listBoxTasks.Items.Add(task.GetName());
                listBoxDate.Items.Add(task.GetDate());
            }
        }
        private void Search(string text)
        {
            if (text.Length != 0)
            {

                List<Task> list = tasks.GetTasks().Where(p => p.GetName().ToLower().StartsWith(text.ToLower())).ToList();
                if (list.Count == 0)
                {
                    list = tasks.GetTasks().Where(p => p.GetDate().ToString().StartsWith(text)).ToList();
                    if (list.Count == 0)
                    {
                        list = tasks.GetTasks().Where(p => p.GetDescription().ToLower().StartsWith(text.ToLower())).ToList();
                    }
                }
                listBoxTasks.Items.Clear();
                listBoxDate.Items.Clear();
                foreach (Task task in list)
                {
                    listBoxTasks.Items.Add(task.GetName());
                    listBoxDate.Items.Add(task.GetDate());
                }
            }
            else
            {
                UpdateForm();
            }
        }
        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;
            if (index != -1)
            {
                DateTime date = (DateTime)listBoxDate.Items[index];
                string selectedTaskName = listBoxTasks.SelectedItem.ToString()!;
                Task selectedTask = tasks.GetTasks().FirstOrDefault(p => p.GetName() == selectedTaskName&&p.GetDate()==date)!;
                if (selectedTask != null)
                {
                    textBoxDescription.Text = selectedTask.GetDescription();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(textBoxSearch.Text);
        }
    }
}
