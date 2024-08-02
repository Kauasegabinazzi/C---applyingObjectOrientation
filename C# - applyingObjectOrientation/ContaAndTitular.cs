using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____applyingObjectOrientation
{
    class Holder
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }

        public Holder(string name, string cpf, string adress)
        {
            Name = name;
            Cpf = cpf;
            Adress = adress;
        }
    }

    class Account
    {
        public Holder Holder { get; set; }
        public int Agency { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public double Limit { get; set; }

        public string Info => $"Account nº {this.AccountNumber}, Agency {this.Agency}, Holder: {this.Holder.Name} - Balance: {this.Balance}";

        public Account(Holder holder, int agency, int account, double limit)
        {
            Holder = holder;
            Agency = agency;
            AccountNumber = account;
            Balance = 0;
            Limit = limit;
        }
    }
}
