using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice.Model
{
    class BankAccount
    {
        private int _Balance { get; set; }
        public void Deposit()
        {
            Console.WriteLine("enter amount:");
            int Amount = int.Parse(Console.ReadLine());
            SetBalanceDeposit(Amount);
            Console.WriteLine($"new balance: {GetBalance()}");
        }
        public void Withdraw()
        {
            Console.WriteLine("enter amount:");
            int Amount = int.Parse(Console.ReadLine());
            if (GetBalance() - Amount >= 0)
            {
                SetBalanceWithdraw(Amount);
                Console.WriteLine($"new balance: {GetBalance()}");
            }
            else
            {
                Console.WriteLine("!!!withdraw cannot be performed due to insufficient balance!!!");
            }

        }
        public void SetBalanceDeposit(int Amount)
        {
            _Balance += Amount;
        }
        public void SetBalanceWithdraw(int Amount)
        {
            _Balance -= Amount;
        }
        public int GetBalance()
        {
            return _Balance;
        }
    }
}
