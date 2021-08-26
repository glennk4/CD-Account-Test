using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CDAccount account = new CDAccount();

            GetCDData(account);

            AccountOutput.Text = account.AccountNumber;
            InterestOutput.Text = account.InterestRate.ToString("n2");
            BalanceOutput.Text = account.Balance.ToString("c");
            MaturityOutput.Text = account.MaturityDate; 
        }

        private void GetCDData(CDAccount account)
        {
            decimal interestRate;
            decimal balance;

            account.AccountNumber = AccountInput.Text;
            account.MaturityDate = MaturityInput.Text;

            if (decimal.TryParse(InterestInput.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(BalanceInput.Text, out balance))
                {
                    account.Balance = balance; 
                }
                else
                {
                    MessageBox.Show("Invalid Balance"); 
                }
            }
            else
            {
                MessageBox.Show("Invalid Interest Rate"); 
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}   