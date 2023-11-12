using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_template
{
    public class Purchase
    {
        // Member variables
        public int id;
        public int lastId;
        public double amount;
        public double totalAmount;
        public double taxRate;
        public string purpose;
        public int quantity;
        public double totalAmountNet;
        public double totalAmountGros;


        // Constructor
        public Purchase(string purpose, int quantity, double amount, double taxRate)
        {
            this.purpose = purpose;
            this.quantity = quantity;
            this.amount = amount;
            this.taxRate = taxRate;
            this.totalAmountNet = this.quantity * this.amount;
            this.totalAmountGros = this.totalAmount * (1 + this.taxRate);
        }
    }
}
