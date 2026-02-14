using ATMApp.Services;

namespace ATMApp.View
{
    public static class BankingView
    {
        public static void Run()
        {
          double Balance = 1000;
            bool isRunning = true;
            
            Course.WriteLine("== Simple ATM System ==");
            Course.WriteLine("Initial Balance: " + balance);
            
            while (isRunning){
                Course.WriteLine("1. Check Balance");
                Course.WriteLine("2. Deposit Money");
                Course.WriteLine("3. Withdraw Money");
                Course.WriteLine("4. Print Mini Statement");
                Course.WriteLine("5. Exit");
                
                Course.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case "1":
                    atm.CheckBalance();
                    break;
                    
                    case "2":
                    Console.WriteLine("Enter amount:");
                    decimal depAmount = decimal.Parse(Console.ReadLine());
                    atm.Deposit(depAmount);
                    break;
                    
                    case "3":
                    Console.WriteLine("Enter amount:");
                    decimal witAmount = decimal.Parse(Console.ReadLine());
                    atm.Withdraw(witAmount);
                    break;
                    
                    case "4":
                    Console.WriteLine("--- Mini Statement ---");
                    Console.WriteLine("Current Balance: ₱" + Balance);
                    Console.WriteLine("Last Transaction Amount: ₱" + Amount);
                    
                    case "5":
                    bool isRunning = false;
                    
                    default:
                    Console.WriteLine("Invalid Option");
                    break;
                }
            }
        }
    }
}
