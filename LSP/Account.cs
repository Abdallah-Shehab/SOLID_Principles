using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{

    public abstract class AccountBase
    {
        public decimal Balance { get; set; }

        public abstract void Withdraw(decimal amount);
        public abstract void Deposit(decimal amount);


    }
    public class Account : AccountBase
    {


        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }


    }

    public class SavingAccount : AccountBase
    {


        public decimal InterestRate { get; set; }

        public override void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(decimal amount)
        {
            // Impose a withdrawal fee

        }
    }
}
