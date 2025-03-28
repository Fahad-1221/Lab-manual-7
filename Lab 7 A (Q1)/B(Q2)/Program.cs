using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace B_Q2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total Accounts : {Account.get()}");

            Account A1 = new Account("NBP", 1500);
            Account A2 = new Account("BOP", 1000);
            Account A3 = new Account("HBL", 5500);
            Account A4 = new Account("UBL", 3200);
            A1.disp();
            A2.disp();
            A3.disp();
            A4.disp();
            A1.withdraw(100);
            A1.disp();
            A1.deposit(1000);

            Console.WriteLine($"\nThe total accounts are : {Account.get()}");
        }
    }
}
