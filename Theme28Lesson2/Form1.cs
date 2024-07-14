using System.Collections.Specialized;

namespace Theme28Lesson2
{
    public partial class Form1 : Form
    {
        private Record[] mas;
        private int count = 0;
        private int index;
        public Form1()
        {
            InitializeComponent();
            mas = new Record[count];
        }
        private void AddRecord()
        {
            PasswordGenerator pasGen = new PasswordGenerator();
            if (textBoxLogonInput.Text.Length != 0)
            {
                if (mas.Any(r => r.getLogin() == textBoxLogonInput.Text))
                {
                    MessageBox.Show("Запись с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Record rec = new Record(textBoxLogonInput.Text, pasGen.ComplexPassGen());
                count++;
                Array.Resize<Record>(ref mas, count);
                mas[count - 1] = rec;
                listBoxLogin.Items.Add(rec.getLogin());
                listBoxPassword.Items.Add(rec.getPass());
                textBoxLogonInput.Clear();
            }
        }
        private void RemoveRecord()
        {
            if (listBoxLogin.SelectedIndex != -1)
            {
                index = listBoxLogin.SelectedIndex;
                listBoxLogin.Items.RemoveAt(index);
                listBoxPassword.Items.RemoveAt(index);
                Record[] temp = new Record[--count];
                int j = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i != index) temp[j++] = mas[i];
                }
                Array.Resize<Record>(ref mas, count);
                Array.Copy(temp, mas, count);
            }
        }

        private void buttonPassGen_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            RemoveRecord();
        }

        private void listBoxPassword_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPassword.SelectedIndex != -1) listBoxPassword.SelectedIndex = -1;
        }
    }
}
