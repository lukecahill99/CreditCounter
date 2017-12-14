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
        int creditCost;
        double poundTotal;
        double penceTotal;
        int currentCredits;

        private void btn_OnePence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 0.01;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 1;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                oneCount = oneCount + 1;
                OnePenceCount.Text = Convert.ToString(oneCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }
 
        private void btn_TwoPence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 0.02;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 2;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                twoCount = twoCount + 1;
                TwoPenceCount.Text = Convert.ToString(twoCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void btn_FivePence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 0.05;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 5;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                fiveCount = fiveCount + 1;
                FivePenceCount.Text = Convert.ToString(fiveCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void btn_TenPence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 0.10;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 10;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                tenCount = tenCount + 1;
                TenPenceCount.Text = Convert.ToString(tenCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void btn_FiftyPence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 0.50;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 50;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                fiftyCount = fiftyCount + 1;
                FiftyPenceCount.Text = Convert.ToString(fiftyCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void btn_OneHundredPence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!"); 
            }
            else
                poundTotal = poundTotal + 1.00;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 100;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                oneHundredCount = oneHundredCount + 1;
                OneHundredPenceCount.Text = Convert.ToString(oneHundredCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void btn_TwoHundredPence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            {
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 2.00;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 200;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                twoHundredCount = twoHundredCount + 1;
                TwoHundredPenceCount.Text = Convert.ToString(twoHundredCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void btn_TwentyPence_Click(object sender, EventArgs e)
        {
            creditCost = Convert.ToInt32(CostPerCredit.Text);
            if (creditCost <= 0)
            { 
                MessageBox.Show("You have not set the cost of the Credit!");
            }
            else
                poundTotal = poundTotal + 0.20;
                String.Format("{0:n2}", (TotalValuePound.Text = Convert.ToString(poundTotal)));
                penceTotal = penceTotal + 20;
                TotalValuePence.Text = Convert.ToString(penceTotal);
                twentyCount = twentyCount + 1;
                TwentyPenceCount.Text = Convert.ToString(twentyCount);
                currentCredits = Convert.ToInt32(penceTotal / creditCost);
                CurrentCredits.Text = Convert.ToString(currentCredits);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostPerCredit.Text = "0";
            creditCost = 0;
            CurrentCredits.Text = "0";
            currentCredits = 0;
            TotalValuePence.Text = "0";
            penceTotal = 0;
            TotalValuePound.Text = "0.00";
            poundTotal = 0; 
            OnePenceCount.Text = "0";
            oneCount = 0;
            TwoPenceCount.Text = "0";
            twoCount = 0;
            FivePenceCount.Text = "0";
            fiveCount = 0;
            TenPenceCount.Text = "0";
            tenCount = 0;
            TwentyPenceCount.Text = "0";
            twentyCount = 0;
            FiftyPenceCount.Text = "0";
            fiftyCount = 0;
            OneHundredPenceCount.Text = "0";
            oneHundredCount = 0;
            TwoHundredPenceCount.Text = "0";
            twoHundredCount = 0;
        }
    }
}
