namespace testest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alle 3 Käufe");
            Console.WriteLine("---------------------------------------------------------------------------");
            
            // Create Approver instance
            President President = new President();
            VicePresident VicePresident = new VicePresident(President);
            Director Director = new Director(VicePresident);

            // Create Pruchases instances
            Purchase purchase3 = new Purchase("1. Kauf", 1, 99999, 2.4);
            Purchase purchase2 = new Purchase("2. Kauf", 1, 15000, 7.7);
            Purchase purchase1 = new Purchase("3. Kauf", 1, 350, 7.7);

            // Create Pruchases instances
            Approver approver1 = Director.processRequest(purchase1);
            Approver approver2 = VicePresident.processRequest(purchase2);
            Approver approver3 = President.processRequest(purchase3);

            // Print results
            Console.WriteLine("\n\nVerabeitet von ...");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"Kauf 1 verarbeitet von: {(approver1 != null ? approver1.name : "Niemand")}");
            Console.WriteLine($"Kauf 2 verarbeitet von: {(approver2 != null ? approver2.name : "Niemand")}");
            Console.WriteLine($"Kauf 3 verarbeitet von: {(approver3 != null ? approver3.name : "Niemand")}");
        }
    }
}