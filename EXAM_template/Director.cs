using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_template
{
    public class Director : Approver
    {
        public Director() : base()
        {
            this.name = "Director";
        }

        public Director(Approver successor) : base(successor)
        {
            this.name = "Director";
        }

        protected override bool canApprove(Purchase purchase)
        {
            return purchase.totalAmount <= 10000;
        }

        public override Approver processRequest(Purchase purchase)
        {
            return handleRequest(purchase);
        }
    }
}
