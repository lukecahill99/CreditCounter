using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creditCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int oneCount;
        int twoCount;
        int fiveCount;
        int tenCount;
        int twentyCount;
        int fiftyCount;
        int oneHundredCount;
        int twoHundredCount;

        private void btn_OnePence_Click(object sender, EventArgs e)
        {
            oneCount = oneCount + 1;
            OnePenceCount.Text = Convert.ToString(oneCount);
        }

        private void btn_TwoPence_Click(object sender, EventArgs e)
        {
            twoCount = twoCount + 1;
            TwoPenceCount.Text = Convert.ToString(twoCount);
        }

        private void btn_FivePence_Click(object sender, EventArgs e)
        {
            fiveCount = fiveCount + 1;
            FivePenceCount.Text = Convert.ToString(fiveCount);
        }

        private void btn_TenPence_Click(object sender, EventArgs e)
        {
            tenCount = tenCount + 1;
            TenPenceCount.Text = Convert.ToString(tenCount);
        }

        private void btn_FiftyPence_Click(object sender, EventArgs e)
        {
            fiftyCount = fiftyCount + 1;
            FiftyPenceCount.Text = Convert.ToString(fiftyCount);
        }

        private void btn_OneHundredPence_Click(object sender, EventArgs e)
        {
            oneHundredCount = oneHundredCount + 1;
            OneHundredPenceCount.Text = Convert.ToString(oneHundredCount);
        }

        private void btn_TwoHundredPence_Click(object sender, EventArgs e)
        {
            twoHundredCount = twoHundredCount + 1;
            TwoHundredPenceCount.Text = Convert.ToString(twoHundredCount);
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
          
        }
        private void btn_TwentyPence_Click(object sender, EventArgs e)
        {
            twentyCount = twentyCount + 1;
            TwentyPenceCount.Text = Convert.ToString(twentyCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostPerCredit.Text = "";
            CurrentCredits.Text = "";
            TotalValuePence.Text = "";
            TotalValuePound.Text = "";
            OnePenceCount.Text = "";
            oneCount = 0;
            TwoPenceCount.Text = "";
            twoCount = 0;
            FivePenceCount.Text = "";
            fiveCount = 0;
            TenPenceCount.Text = "";
            tenCount = 0;
            TwentyPenceCount.Text = "";
            twentyCount = 0;
            FiftyPenceCount.Text = "";
            fiftyCount = 0;
            OneHundredPenceCount.Text = "";
            oneHundredCount = 0;
            TwoHundredPenceCount.Text = "";
            twoHundredCount = 0;
        }
    }
}

