using Lab1;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NumberOfItems.KeyPress += NumberOfItems_KeyPress;
            volume.KeyPress += volume_KeyPress;
            random.KeyPress += random_KeyPress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(NumberOfItems.Text);
            int random_gen = int.Parse(random.Text);
            int capacity = int.Parse(volume.Text);

            Backpack pack = new Backpack(number, random_gen);
            InstanceTextBox.Text = pack.ToString();
            ResultsTextBox.Text = pack.Solve(capacity).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void InstanceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstanceTextBox.ReadOnly = true;
            ResultsTextBox.ReadOnly = true;
        }

        private void NumberOfItems_TextChanged(object sender, EventArgs e)
        {
        }

        private void NumberOfItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void random_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
    }
}
