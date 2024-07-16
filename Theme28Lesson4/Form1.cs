namespace Theme28Lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void LisboxOperator(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                listBox1.Items.Add(text[i]);
            }
        }
        private string[] StringToArray(string text) => text.Split("\n");

        private void buttonSave_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                FileInfo info = new FileInfo(textBoxPath.Text);
                StreamReader reader = info.OpenText();
                {
                    string text = reader.ReadToEnd();
                    LisboxOperator(StringToArray(text));
                }

                //string text = File.ReadAllText(textBoxPath.Text);
                //LisboxOperator(StringToArray(text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = dialog.FileName;
            }

        }
    }
}
