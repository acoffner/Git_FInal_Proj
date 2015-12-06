using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//abigail offner
//midterm
//having trouble getting favTeam work to be able to calculate the total

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                label3.Text = "Ticket Price: $250";
                this.BackColor = Color.Green;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                label3.Text = "Ticket Price: $200";
                this.BackColor = Color.Orange;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                label3.Text = "Ticket Price: $150";
                this.BackColor = Color.CornflowerBlue;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                label3.Text = "Ticket Price: $200";
                this.BackColor = Color.Purple;
            }
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "Packers $250, Bears $200, Lions $150, Vikings $200";
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticketsTextBox_TextChanged(object sender, EventArgs e)
        {
           int numOfTickets;
            numOfTickets = int.Parse(ticketsTextBox.Text);

            int total;
            int favTeam;

            if (listBox1.SelectedIndex ==0)
            {
                favTeam = 250;
                total = numOfTickets * favTeam;
                label6.Text = total.ToString("C");
            }
                else if (listBox1.SelectedIndex ==1)
                {
                    favTeam = 200;
                 total = numOfTickets * favTeam;
                    label6.Text = total.ToString("C");
                }
                else if (listBox1.SelectedIndex ==2)
                {
                    favTeam = 150;
                    total = numOfTickets * favTeam;
                    label6.Text = total.ToString("C");
                }
                else if (listBox1.SelectedIndex ==3)
                {
                    favTeam = 200;
                    total = numOfTickets * favTeam;
                    label6.Text = total.ToString("C");
                }
        }
    }
}
