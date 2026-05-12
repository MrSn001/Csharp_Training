using System.Runtime.InteropServices;
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
            string isActiveStatus = "False";
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

            //Switch Options
            int option = 1;
            int moduleOption = 1;
            int atmServiceOption = 1;
            int atmWelcomeDisplay = 1;
            int accountDataViewerOption;


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
                            isActiveStatus = "Active";
                            Console.WriteLine("Your account is active");
                        }
                        else if (isActiveNum == 0)
                        {
                            isActive = false;
                            isActiveStatus = "inactive";
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
                        ////////////////////////////////////////////////////////////////////////////////
                        //Bonus While loop
                        while (moduleOption != 0)
                        {
                            //Bonus:
                            Console.WriteLine("");
                            Console.WriteLine("=== NATIONAL BANK OF OMAN ===");
                            Console.WriteLine("    Unified Banking System v1.0");
                            Console.WriteLine("  --- System Setup complete ---  ");
                            Console.WriteLine("  Customer :  " + holderName);
                            Console.WriteLine("  Balance:  " + balance);
                            Console.WriteLine(" 1) ATM Services");
                            Console.WriteLine(" 2) Account Management");
                            Console.WriteLine(" 3) Loan Services");
                            Console.WriteLine(" 4) Currency Exchange");
                            Console.WriteLine(" 5) Credit Card Portal");
                            Console.WriteLine(" 6) Branch Services");
                            Console.WriteLine(" 7) Reports & Admin");
                            Console.WriteLine(" 0) Exit");
                            Console.WriteLine("");
                            atmServiceOption = 1;
                           
                            Console.Write("Select module: ");
                            moduleOption = int.Parse(Console.ReadLine());
                            //Bonus Switch
                            switch (moduleOption)
                            {
                                //Task 2 - 5 ATM Services
                                case 1:
                                    
                                    //ATM Services While Loop
                                    while (atmServiceOption != 0)
                                    {
                                        accountDataViewerOption = 1;
                                        atmWelcomeDisplay = 1;
                                        Console.WriteLine("");
                                        Console.WriteLine("""
                                            === ATM SERVICES ===
                                            1) ATM Welcome & Display
                                            2) VIEW ACCOUNT DATA
                                            3) AUTHENTICATION
                                            4) PRINT RECEIPT
                                            0) Exit
                                            """);
                                        Console.Write("Select Your Service Number: ");
                                        atmServiceOption = int.Parse(Console.ReadLine());

                                        // Switch ATM Services
                                        switch (atmServiceOption)
                                        {
                                            // ATM Welcom & Display
                                            case 1:
                                                Console.WriteLine("");
                                                Console.WriteLine("""
                                                    === ATM Welcome & Display ===
                                                    1) Bank Info
                                                    2) Branch Info
                                                    3) Opening Hours
                                                    0) Back to Main Menu
                                                    """);
                                                //ATM Welcome & Display While loop
                                                while (atmWelcomeDisplay != 0)
                                                {
                                                    Console.WriteLine("");
                                                    Console.Write("Select Which Service You Need: ");
                                                    Console.WriteLine("");
                                                    atmWelcomeDisplay = int.Parse(Console.ReadLine());

                                                    //Task 2 ATM Welcome & Display
                                                    switch (atmWelcomeDisplay)
                                                    {
                                                        // Printing the Bank Info
                                                        case 1:
                                                            Console.WriteLine("""
                                                                 Bank Name: National Bank of Oman,
                                                                 Tagline:Unlocking Opportunities, As One.
                                                                 Founding Year: 1973
                                                                 """);
                                                            break;
                                                        // Printing the Branch Info
                                                        case 2:
                                                            Console.WriteLine("""
                                                                Main Branch
                                                                City:Muscat
                                                                Address:Sultan Qaboos Rd, Azaiba, Muscat 112, Sultanate of Oman
                                                                """);
                                                            break;
                                                        //Pringting the Opening Hours
                                                        case 3:
                                                            Console.WriteLine("""
                                                                sunday - tursday : 8:00 - 17:00
                                                                friday and saturday: Closed
                                                                """);
                                                            break;
                                                        // Go Back to the main menu
                                                        case 0:
                                                            Console.WriteLine("Back to main menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Invalid selection!! please enter your choice again");
                                                            break;
                                                    }
                                                }// End while loop ATM Welcome & Display 


                                                break;
                                            //Task 3 - View Account Data
                                            case 2:
                                                //While loop account Data Viewer 
                                                while (accountDataViewerOption != 0)
                                                {
                                                    Console.WriteLine("=== VIEW ACCOUNT DATA ===");
                                                    Console.WriteLine("  Data loaded from system setup");
                                                    Console.WriteLine("1) Account Number --->  " + accountNumber);
                                                    Console.WriteLine("2) Holder Name    --->  " + holderName);
                                                    Console.WriteLine("3) Balance        ---> " + balance);
                                                    Console.WriteLine("4) Account Status ---> " + isActiveStatus);
                                                    Console.WriteLine("5) Account Type   ---> " + accountType);
                                                    Console.WriteLine("0) Back");

                                                    Console.WriteLine("Select Field (0 To Exit): ");
                                                    accountDataViewerOption = int.Parse(Console.ReadLine());
                                                    //Account Data Viewer Switch
                                                    switch (accountDataViewerOption)
                                                    {
                                                        case 0:
                                                            Console.WriteLine("Back to main menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Invalid selection!! please enter your choice again");
                                                            break;
                                                    }// END switch Account Data Viewer
                                                }//End While Loop Account Datat Viewer
                                                break;
                                            //ATM Pin Validation
                                            case 3:
                                                break;
                                            // Authentication
                                            case 4:
                                                break;
                                            default:
                                                Console.WriteLine("Invalid selection!! please enter your choice again");
                                                break;
                                        }// End Switch ATM Services

                                    }// End While loop ATM Services
                                   
                                    break;
                                

                                default:
                                    Console.WriteLine("Invalid selection!! please enter your choice again");
                                    break;
                                case 0:
                                    Console.WriteLine("Thank you for using our system");
                                    break;
                            }//End Bonus Switch
                        }//End Bonus while loop

                        break;
                    default:
                        Console.WriteLine("Invalid selection!! please enter your choice again");
                        break;


                }//System Setup Switch
            }//System Setup While loop


        }
    }
}
