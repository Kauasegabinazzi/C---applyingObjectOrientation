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
    }

    class Account
    {
        public Holder Holder { get; set; }
        public int Agency { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public double Limit { get; set; }

        public string Informacoes => $"Account nº {this.AccountNumber}, Agency {this.Agency}, Holder: {this.Holder.Name} - Balance: {this.Balance}";
    }
}
