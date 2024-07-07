namespace Theme26Lesson2
{
    public partial class Form1 : Form
    {
        private void ValidKeys(KeyPressEventArgs e,TextBox textBox)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBox.Text.IndexOf(',') != -1 ||
                    textBox.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
                double a, b;
                double.TryParse(textBoxFirstVar.Text, out a);
                double.TryParse(textBoxSecondVar.Text, out b);
                if (checkBoxAdd.Checked)
                {
                    double result = a + b;
                    labelResult.Text = $"Результат: {result:F2}";
                }
                else if (checkBoxSub.Checked)
                {
                    double result = a - b;
                    labelResult.Text = $"Результат: {result:F2}";
                }
                else MessageBox.Show("Выберите действие");
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstVar.Clear();
            textBoxSecondVar.Clear();
            labelResult.Text = "";
        }
        private void textBoxFirstVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidKeys(e, textBoxFirstVar);
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) textBoxSecondVar.Focus();
                return;
            }
        }
        private void textBoxSecondVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidKeys(e, textBoxSecondVar);
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) textBoxFirstVar.Focus();
                return;
            }
        }
    }
}
