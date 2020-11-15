using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyForm
{
    public partial class Form1 : Form
    {
        private string qOneChoice;
        private string qTwoChoices;
        private decimal qThreeValue;
        private string qFourDate;
        private int count1;
        private int count2;
        private int count3;
        private int count4;
        private int count5;
        private int count6;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

            if(this.radioButton1.Checked)
            {
                qOneChoice = "very often";
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                qOneChoice = "moderately often";
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                qOneChoice = "not at all often";
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Format("You watch movies {0}, your favorite kind of movies are{1}, you've seen {2} movies this year, and your birthdate is {3}", qOneChoice, qTwoChoices, qThreeValue, qFourDate);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (count1 == 0)
            {
                qTwoChoices += " drama";
                count1++;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (count2 == 0)
            {
                qTwoChoices += " romance";
                count2++;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (count3 == 0)
            {
                qTwoChoices += " science-fiction";
                count3++;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (count4 == 0)
            {
                qTwoChoices += " action/adventure";
                count4++;
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (count5 == 0)
            {
                qTwoChoices += " horror";
                count5++;
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (count6 == 0)
            {
                qTwoChoices += " comedy";
                count6++;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            qThreeValue = numericUpDown1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            qFourDate = monthCalendar1.SelectionRange.Start.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qOneChoice = string.Empty;
            qTwoChoices = string.Empty;
            qThreeValue = 0;
            qFourDate = string.Empty;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            txtOutput.Text = string.Empty;
        }
    }
}
