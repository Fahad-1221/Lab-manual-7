using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Q2_
{
    class Account
    {
        private string Name { get; set; }
        private int Balance { get; set; }

        static int counter;

        public Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
            counter++;
        }

        public void deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"\nBalance Added Sucessfully \n New Balance : {Balance}");
        }

        public void withdraw(int amount)
        {
            Balance -= amount;
            Console.WriteLine($"\nBalance Debited Sucessfully \n New Balance : {Balance}");
        }

        public static int get()
        {
            return counter;
        }

        public void disp()
        {
            Console.WriteLine($"\nName = {Name} \nBalnce = {Balance} ");
        }
    }
}
