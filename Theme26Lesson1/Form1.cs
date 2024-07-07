namespace Theme26Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) MessageBox.Show("Выбран флажок 1");
            else MessageBox.Show("Флажок 1 не выбран");
            if (checkBox2.Checked) MessageBox.Show("Выбран флажок 2");
            else MessageBox.Show("Флажок 2 не выбран");
            if (checkBox3.Checked) MessageBox.Show("Выбран флажок 3");
            else MessageBox.Show("Флажок 3 не выбран");
        }
    }
}
