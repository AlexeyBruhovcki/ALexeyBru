namespace Theme28Lesson1
{
    public partial class Form1 : Form
    {
        private Quote quote = new Quote();
        DialogResult result;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result = MessageBox.Show(quote.RandomQuote(), "", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
