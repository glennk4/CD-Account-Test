using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    class SavingsAccount
    {
        public SavingsAccount()
        {
            string AccountNumber = ""; 
            decimal InterestRate = 0;
            decimal Balance = 0; 
        }

        public string AccountNumber { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Balance { get; set; }
    }
}
