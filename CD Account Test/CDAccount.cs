using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    class CDAccount: SavingsAccount
    {

        public CDAccount()
        {
            string MaturityDate = ""; 
        }

        public string MaturityDate { get; set; }

    }
}
