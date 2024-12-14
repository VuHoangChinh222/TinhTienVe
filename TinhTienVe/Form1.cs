using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienVe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            int selectedIndex = classTicket.SelectedIndex;
            DateTime birth = birthday.Value;
            int ages = CalculateAge(birth);
            if (name.Text.Length == 0 || adress.TextLength == 0 || idCard.TextLength == 0 || selectedIndex == -1)
            {
                return;
            }
            else
            {
                if (selectedIndex == 0)
                {
                    if (ages < 7)
                        changCost.Text = "1.500.000";
                    else
                        changCost.Text = "4.000.000";
                }
                else
                {
                    if (ages < 7)
                        changCost.Text = "700.000";
                    else
                        changCost.Text = "3.000.000";
                }
            }   
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        private void changeCost(object sender, EventArgs e)
        {
            
        }
    }
}
