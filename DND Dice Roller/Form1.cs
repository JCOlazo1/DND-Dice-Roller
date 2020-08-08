using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Dice_Roller
{
    public partial class Form1 : Form
    {
        public int d20, d12, d10, d8, d6, d4;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        // NOTE: The second parameter for 'rand.Next' is exclusive so its whatever the dice value + 1.
        private void d20Button_Click(object sender, EventArgs e)
        {
            d20 = rand.Next(1, 21);
            rollResultValue.Text = d20.ToString();
        }
        private void d12Button_Click(object sender, EventArgs e)
        {
            d12 = rand.Next(1, 13);
            rollResultValue.Text = d12.ToString();
        }
        private void d10Button_Click(object sender, EventArgs e)
        {
            d10 = rand.Next(1, 11);
            rollResultValue.Text = d10.ToString();
        }
        private void d8Button_Click(object sender, EventArgs e)
        {
            d8 = rand.Next(1, 9);
            rollResultValue.Text = d8.ToString();
        }
        private void d6Button_Click(object sender, EventArgs e)
        {
            d6 = rand.Next(1, 7);
            rollResultValue.Text = d6.ToString();
        }
        private void d4Button_Click(object sender, EventArgs e)
        {
            d4 = rand.Next(1, 5);
            rollResultValue.Text = d4.ToString();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            rollResultValue.Text = "";
        }
    }
}
