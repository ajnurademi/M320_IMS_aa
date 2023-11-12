using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_template
{
    public class VicePresident : Approver
    {
        public VicePresident() : base()
        {
            this.name = "Vice President";
        }

        public VicePresident(Approver successor) : base(successor)
        {
            this.name = "Vice President";
        }

        protected override bool canApprove(Purchase purchase)
        {
            return purchase.totalAmount <= 25000;
        }

        public override Approver processRequest(Purchase purchase)
        {
            return handleRequest(purchase);
        }
    }
}
