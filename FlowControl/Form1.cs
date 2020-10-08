using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowControl
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        String pName = "Fy1re";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rollBttn_Click(object sender, EventArgs e)
        {
            winLbl.Visible = false;

            int pDie1 = random.Next(1,7);//generating dice rolls
            int pDie2 = random.Next(1, 7);
            int cpuDie1 = random.Next(1, 7);
            int cpuDie2 = random.Next(1, 7);

            int pTotal = pDie1 + pDie2;//calculating total
            int cpuTotal = cpuDie1 + cpuDie2;

            cpuRollLbl.Text = cpuTotal.ToString();//updating visual output
            pRollLbl.Text = pTotal.ToString();

            if (pTotal > cpuTotal && pName != "Fy1re"){
                winLbl.Text = "Player Wins!";
                winLbl.Visible = true;
            }
            else if(cpuTotal > pTotal)
            {
                winLbl.Text = "Computer Wins!";
                winLbl.Visible = true;
            }
            else
            {
                winLbl.Text = "Tie";
                winLbl.Visible = true;
            };

            Task.Delay(500).Wait();
            winLbl.Visible = false;
            
            //Console.WriteLine(pTotal);
            //Console.WriteLine(cpuTotal);


        }

        private void winLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
