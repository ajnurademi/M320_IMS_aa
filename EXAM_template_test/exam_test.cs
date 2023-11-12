namespace EXAM_template_test
{
    using EXAM_template;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ApproverTests
    {
        Purchase purchase1;
        Purchase purchase2;
        Purchase purchase3;
        President President;
        VicePresident VicePresident;
        Director Director;

        [TestInitialize]
        public void Initialize()
        {
            // Initialize the purchases
            purchase1 = new Purchase("1 Kauf", 3, 350, 7.7);
            purchase2 = new Purchase("2 Kauf", 1, 15000, 7.7);
            purchase3 = new Purchase("3 Kauf", 1, 99999, 2.4);

            // Initialize the approvers
            President = new President();
            VicePresident = new VicePresident(President);
            Director = new Director(VicePresident);
        }

        [TestMethod]
        public void ApproverDirector()
        {
            // Process purchase
            Approver approver = Director.processRequest(purchase1);

            // Assert that purchase was processed by Director
            Assert.AreEqual("Director", approver.name);
        }

        [TestMethod]
        public void ApproverVicePresident()
        {
            // Process purchase
            Approver approver = Director.processRequest(purchase2);

            // Assert that purchase was processed by Vice President
            Assert.AreEqual("Vice President", approver.name);
        }

        [TestMethod]
        public void ApproverPresident()
        {
            // Process purchase
            Approver approver = Director.processRequest(purchase3);

            // Assert that purchase was processed by President
            Assert.AreEqual("President", approver.name);
        }
    }
}