using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_template
{
    public class President : Approver
    {
        public President() : base()
        {
            this.name = "President";
        }

        public President(Approver successor) : base(successor)
        {
            this.name = "President";
        }

        protected override bool canApprove(Purchase purchase)
        {
            return purchase.totalAmount <= 100000;
        }

        public override Approver processRequest(Purchase purchase)
        {
            return handleRequest(purchase);
        }
    }
}
