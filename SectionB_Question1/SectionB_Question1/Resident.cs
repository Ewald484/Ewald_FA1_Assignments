using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    // This class represents a resident with their name, address, account number, and monthly usage.
    // It has a constructor to initialize these properties when creating an instance of the Resident class.
    
    public class Resident
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string AccountNumber { get; set; }
            public double MounthlyUsage { get; set; }
            public Resident(string name, string address, string accountnumber,double Usage)
            {
                Name = name;
                Address = address;
                AccountNumber = accountnumber;
                MounthlyUsage = Usage;
            }
        }
}
