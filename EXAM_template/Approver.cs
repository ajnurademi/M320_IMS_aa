using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_template
{
    public abstract class Approver
    {
        protected Approver successor;
        protected ConsoleLogger logger;
        public string name { get; set; }

        public Approver()
        {
            this.successor = null;
            this.logger = new ConsoleLogger();
        }

        public Approver(Approver successor)
        {
            this.successor = successor;
            this.logger = new ConsoleLogger();
        }

        public abstract Approver processRequest(Purchase purchase);
        protected abstract bool canApprove(Purchase purchase);

        protected Approver handleRequest(Purchase purchase)
        {
            if (canApprove(purchase))
            {
                logger.log($"{purchase.purpose} von {name} bearbeitet");
                return this;
            }
            else if (successor != null)
            {
                return successor.processRequest(purchase);
            }
            else
            {
                logger.log($"{purchase.purpose} kann nicht bearbeitet werden");
                return null;
            }
        }
        
    }
}
