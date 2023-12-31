using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaCafeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            textBoxAmountCorn.Clear();
            textBoxAmountWater.Clear();
            textBoxAmountTea.Clear();
            textBoxAmountTicket.Clear();
            textBoxTotal.Clear();
        }

        private void buttonCalculateValue()
        {
            if (textBoxAmountCorn.Text.Length > 0 && textBoxAmountWater.Text.Length > 0 && textBoxAmountTea.Text.Length > 0 && textBoxAmountTicket.Text.Length > 0)
            {
                buttonCalculate.Enabled = true;
            }

            else
            {
                buttonCalculate.Enabled = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int Corn = Convert.ToInt16(textBoxAmountCorn.Text);
            int Water = Convert.ToInt16(textBoxAmountWater.Text);
            int Tea = Convert.ToInt16(textBoxAmountTea.Text);
            int Ticket = Convert.ToInt16(textBoxAmountTicket.Text);

            int totalPrice = (Corn * 80 + Water * 10 + Tea * 20 + Ticket * 100);
            textBoxTotal.Text = totalPrice.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = false;
        }

        private void textBoxAmountCorn_TextChanged(object sender, EventArgs e)
        {
            buttonCalculateValue();
        }

        private void textBoxAmountWater_TextChanged(object sender, EventArgs e)
        {
            buttonCalculateValue();
        }

        private void textBoxAmountTea_TextChanged(object sender, EventArgs e)
        {
            buttonCalculateValue();
        }

        private void textBoxAmountTicket_TextChanged(object sender, EventArgs e)
        {
            buttonCalculateValue();
        }
    }
}
