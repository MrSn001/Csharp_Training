using System.Security.Principal;

namespace BankingServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System Shared Variables

           
            //Account Profile Variables
            int accountNumber = 0;
            string holderName = "[not set]";
            double balance = 0.000;
            bool isActive = false;
            char accountType = '-';

            //Customer Profile Variables
            bool isEmployed = false;
            double salary = 0.000;
            int creditScore = 0;
            int age = 0;

            //Transaction Data Variables
            double deposit = 0.000;
            double withdrawal = 0.000;
            double annualRate = 0.000;
            double avgBalance = 0.000;

            int option = 1;


            //System Options
            Console.WriteLine("");
            //task 1: 
            Console.WriteLine("=== SYSTEM SETUP — Enter Account & Customer Data ===");
            Console.WriteLine("--- Account Profile ---");//Account Profile
            Console.WriteLine("1) Account Number            (int)    current: "    + accountNumber);
            Console.WriteLine("2) Holder Name               (string) current: " + holderName);
            Console.WriteLine("3) Balance                   (double) current: " + balance + " OMR");
            Console.WriteLine("4) Account Active?           (bool)   current: " + isActive + " [enter 1=yes / 0=no]");
            Console.WriteLine("5) Account Type              (char)   current: " + accountType + " [enter S / C / F]");
            Console.WriteLine("--- Customer Profile ---");//Customer Profile
            Console.WriteLine("6) Employed?                 (bool)   current: " + isEmployed + " [enter 1=yes / 0=no]");
            Console.WriteLine("7) Monthly Salary            (double) current: " + salary +" OMR");
            Console.WriteLine("8) Credit Score              (int)    current: " + creditScore );
            Console.WriteLine("9) Age                       (int)    current: " + age);
            Console.WriteLine("--- Transaction Data ---");//Transaction Data
            Console.WriteLine("10) Last Deposit Amount      (double) current: " + deposit + " OMR");
            Console.WriteLine("11) Last Withdrawal          (double) current: " + withdrawal + " OMR");
            Console.WriteLine("12) Annual Interest Rate     (double) current: " + annualRate + " [e.g. 0.035 = 3.5%]");
            Console.WriteLine("13) Avg Monthly Balance      (double) current: " + avgBalance + " OMR");

            Console.WriteLine("");
            Console.WriteLine("0) Setup complete — launch Main Menu");
            Console.WriteLine("");
            while (option != 0) 
            {

                Console.Write("Select Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter AccountNumber: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account number set to: " + accountNumber);
                        break;
                    case 2:
                        Console.Write("Enter holder name : ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder name set to: " + holderName);
                        break;
                    case 3:
                        Console.Write("Enter Balance: ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance set to: " + balance + " OMR");
                        break;
                    case 4:
                        int isActiveNum;
                        Console.Write("Enter 1 if your account is active and 0 if your account is not: ");
                        isActiveNum = int.Parse(Console.ReadLine());
                        if (isActiveNum == 1)
                        {
                            isActive = true;
                            Console.WriteLine("Your account is active");
                        }
                        else if (isActiveNum == 0)
                        {
                            isActive = false;
                            Console.WriteLine("Your account is not active");
                        }
                        else
                        {
                            Console.WriteLine("Wrong Choice please Enter Again");
                        }
                        Console.WriteLine("isActive set to: " + isActive);
                        break;
                    case 5:
                        Console.Write("Enter Account type (S / C / F): ");
                        accountType = char.Parse(Console.ReadLine());
                        if (accountType == 'S' || accountType == 'C' || accountType == 'F')
                        {
                            Console.WriteLine("Account Type set to: " + accountType);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Account Type");
                        }
                        break;
                    case 6:
                        int isEmployeeNum;
                        Console.Write("Enter 1 if you are employee and 0 if you are not: ");
                        isEmployeeNum = int.Parse(Console.ReadLine());
                        if (isEmployeeNum == 1)
                        {
                            isEmployed = true;
                        }
                        else if (isEmployeeNum == 0)
                        {
                            isEmployed = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Choice please Enter Again");
                        }
                        Console.WriteLine("isEmployed set to: " + isEmployed);
                        break;
                    case 7:
                        Console.Write("Enter Monthly Salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Monthly Salary set to: " + salary + " OMR");
                        break;
                    case 8:
                        Console.Write("Enter Credit Score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("Credit Score set to: " + creditScore);
                        break;
                    case 9:
                        Console.Write("Enter your age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Age set to: " + age);
                        break;
                    case 10:
                        Console.Write("Enter deposit amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Deposit set to: " + deposit + " OMR");
                        break;
                    case 11:
                        Console.Write("Enter withdrawal: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Withdrawal set to: " + withdrawal + " OMR");
                        break;
                    case 12:
                        Console.Write("Enter  Annual Interest Rate [e.g. 0.035 = 3.5%]: ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Annual Interest Rate set to: " + annualRate);
                        break;
                    case 13:
                        Console.Write("Enter  Avg Monthly Balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Avg Monthly Balance set to: " + avgBalance + " OMR");
                        break;
                    case 0:
                        Console.WriteLine("Setup complete. Launching Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;


                }
            }
            
                
        }
    }
}
