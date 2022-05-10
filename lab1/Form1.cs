using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Color[] clrs = {Color.Red, Color.Green, Color.Yellow, Color.White,
            Color.Gray, Color.Blue, Color.Cyan, Color.DarkBlue, Color.DarkCyan,
            Color.DarkGray, Color.DarkBlue, Color.DarkRed};
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.White;
            button2.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = clrs[random.Next() % clrs.Length];
            try
            {
                int x = Int32.Parse(xBox.Text);
                int z = Int32.Parse(zBox.Text);
                if (button1.BackColor == Color.Cyan)
                    label1.Text = (Math.Sqrt(Math.Abs(x * x - 4)) / (2 * z)) + "";
            }
            catch (Exception)
            {
                label1.Text = "Wrong param. Try again";
                label2.Text = "Wrong param. Try again";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = clrs[random.Next() % clrs.Length];
            try
            {
                int x = Int32.Parse(xBox.Text);
                int z = Int32.Parse(zBox.Text);
                if (button2.BackColor == Color.DarkCyan)
                    label2.Text = ((Math.Sqrt(Math.Abs(x - 1)) - Math.Pow(Math.Abs(z), 1.0 / 3.0)) / (1 - x * x / 2 - z / x)) + "";
            }
            catch (Exception)
            {
                label1.Text = "Wrong param. Try again";
                label2.Text = "Wrong param. Try again";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Application will be closed", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
                this.Close();
            if (res == DialogResult.Cancel)
                return;

        }
    }
}
