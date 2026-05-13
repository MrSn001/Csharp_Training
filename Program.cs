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
            int atmServiceOption;
            int atmWelcomeDisplay;
            int accountDataViewerOption;
            int atmPinValidation;
            int atmReceiptPrinterOption;
            int accountManagementOption;
            int transactionCalculatorOption;
            int accountTypeInformation;

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
                            //Reseting the Options to re-enter
                            atmServiceOption = 1;
                            accountManagementOption = 1;

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
                                       //Reseting the option value to re-enter the option 
                                        atmWelcomeDisplay = 1;
                                        accountDataViewerOption = 1;
                                        atmPinValidation = 1;
                                        atmReceiptPrinterOption = 1;

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
                                                        case 1:
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Here your Account Number: " + accountNumber);
                                                            Console.WriteLine("");
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("");
                                                            Console.WriteLine("This is the holder name: " + holderName);
                                                            Console.WriteLine("");
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Your balance is: " + balance);
                                                            Console.WriteLine("");
                                                            break;

                                                        case 4:
                                                            Console.WriteLine("");
                                                            Console.WriteLine("your account is: " + isActiveStatus);
                                                            Console.WriteLine("");
                                                            break;

                                                        case 5:
                                                            Console.WriteLine("");
                                                            Console.WriteLine("your Account type is: " + accountType);
                                                            Console.WriteLine("");
                                                            break;

                                                        case 0:
                                                            Console.WriteLine("Back to main menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Invalid selection!! please enter your choice again");
                                                            break;
                                                    }// END switch Account Data Viewer
                                                }//End While Loop Account Datat Viewer
                                                break;

                                            //Task 4 - ATM Pin Validation

                                             /*Here I'm going to create a Pin Validation for the bank system
                                             it will check the Entered pin by the user and it will compare it 
                                             with the CORRECT_PIN if it was equal it will show a granted access
                                             Message and print the name, else if the user entered more than or less 
                                             than 4 digits it will give a message 'Invalid PIN format' and if the 
                                             password was anything else it will give a message says 'Incorrect PIN.'
                                             and it will decrease the number of attempts.

                                             if number of attempts equals to 0 then the program will stop and takes
                                             you back to the previous menu.
                                             */
                                            case 3:
                                                const int CORRECT_PIN = 4821;
                                                //Atm pin validation while loop
                                                while (atmPinValidation != 0)
                                                {
                                                    Console.WriteLine("""
                                                        === AUTHENTICATION ===
                                                        1) Enter PIN
                                                        2) Forgot PIN
                                                        0) Back

                                                        """);
                                                    Console.WriteLine("Select: ");
                                                    atmPinValidation = int.Parse(Console.ReadLine());
                                                    //Atm Pin Validation Switch
                                                    switch (atmPinValidation)
                                                    {
                                                        //Enter PIN
                                                        case 1:
                                                            int numberOfAttempts = 3;
                                                            while (numberOfAttempts != 0)
                                                            {
                                                                Console.WriteLine("Enter Pin: ");
                                                                int enteredPin = int.Parse(Console.ReadLine());
                                                                if (enteredPin == CORRECT_PIN)
                                                                {
                                                                    Console.WriteLine("Access granted. Welcome, " + holderName);
                                                                    break;
                                                                }
                                                                else if (enteredPin.ToString().Length != 4)
                                                                {
                                                                    Console.WriteLine("Invalid PIN format.");
                                                                   
                                                                }
                                                                else
                                                                {
                                                                    numberOfAttempts -= 1;
                                                                    Console.WriteLine("Incorrect PIN.");
                                                                }
                                                            }
                                                            break;
                                                    
                                                        //Forget PIN
                                                        case 2:
                                                            Console.WriteLine("Please visit the nearest branch with your National ID");
                                                            break;
                                                        //Go ack to main menu
                                                        case 0:
                                                            Console.WriteLine("Back to main menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Invalid selection!! please enter your choice again");
                                                            break;
                                                    }// END Atm Pin Validation
                                                }// END While Loop Atm pin validation
                                                break;
                                            // Task 5 - ATM Receipt Printer
                                            case 4:
                                                //Atm Receipt Printer While Loop
                                                while(atmReceiptPrinterOption != 0)
                                                {
                                                    Console.WriteLine("""

                                                        === PRINT RECEIPT ===
                                                        1) Short Receipt
                                                        2) Detailed Receipt
                                                        3) Balance Only
                                                        0) Back

                                                        """);
                                                    Console.Write("Select Format: ");
                                                    atmReceiptPrinterOption = int.Parse(Console.ReadLine());
                                                    //Atm Receipt Printer Switch
                                                    switch (atmReceiptPrinterOption)
                                                    {
                                                        case 1:
                                                            string accountStr = accountNumber.ToString();
                                                            string masked = accountStr.Substring(accountStr.Length - 4).PadLeft(accountStr.Length, '*');
                                                            Console.WriteLine("Account Number: " + masked);
                                                            Console.WriteLine("Holder Name: " + holderName);
                                                            Console.WriteLine($"Balance: {balance:N3}");
                                                            break;

                                                        case 2:
                                                            accountStr = accountNumber.ToString();
                                                            masked = accountStr.Substring(accountStr.Length - 4).PadLeft(accountStr.Length, '*');
                                                            Console.WriteLine("Account Number: " + masked);
                                                            Console.WriteLine("Holder Name: " + holderName);
                                                            Console.WriteLine($"Balance: {balance:N3} " + " OMR");
                                                            Console.WriteLine("Account Active?: " + isActiveStatus);
                                                            Console.WriteLine("Account Type: " + accountType);
                                                            
                                                            Console.WriteLine("Employed?: " + isEmployed);
                                                            Console.WriteLine($"Monthly Salary: {salary:N3} " + " OMR");
                                                            Console.WriteLine("Credit Score" + creditScore);
                                                            Console.WriteLine("Age" + age);
                                 
                                                            Console.WriteLine($"Last Deposit Amount: {deposit:N3}"  + " OMR");
                                                            Console.WriteLine($"Last Withdrawal: {withdrawal:N3}" + " OMR");
                                                            Console.WriteLine("Annual Interest Rate: " + annualRate);
                                                            Console.WriteLine($"Avg Monthly Balance: {avgBalance:N3}" + " OMR");

                                                            break;

                                                        case 3:
                                                            Console.WriteLine($"Balance: {balance:N3}");
                                                            break;
                                                        case 0:
                                                            Console.WriteLine("Back to main menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Invalid selection!! please enter your choice again");
                                                            break;
                                                    } // END Switch Atm Receipt Printer

                                                }// END Atm Receipt Printer While Loop

                                                break;
                                            default:
                                                Console.WriteLine("Invalid selection!! please enter your choice again");
                                                break;
                                        }// End Switch ATM Services

                                    }// End While loop ATM Services
                                   
                                    break;

                                //Tasks 6 - 8 Account Management
                                case 2:

                                    //Account Management While Loop
                                    while (accountManagementOption != 0)
                                    {
                                        
                                        transactionCalculatorOption = 1;
                                        accountTypeInformation = 1;
                                        Console.WriteLine("");
                                        Console.WriteLine("""
                                            1)Transaction Calculator
                                            2)Account Type Information
                                            3)Loan Eligibility Checker
                                            0)Back To Main Menu
                                            """);
                                        Console.WriteLine("");
                                        accountManagementOption = int.Parse(Console.ReadLine());
                                        //Account Management Switch
                                        switch (accountManagementOption)
                                        {
                                            //Task 6 - Transaction Calculator
                                            case 1:
                                                // While Loop Transaction Calculator
                                                while (transactionCalculatorOption != 0)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("""
                                                         === TRANSACTION CALCULATOR ===

                                                          Using: balance=12,500.000 deposit=1,500.000 rate=3.5%

                                                         1) Balance After Deposit
                                                         2) Balance After Withdrawal
                                                         3) Annual Interest Earned
                                                         4) Net Balance Change
                                                         0) Back
                                                         
                                                         """);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Select Calculation: ");
                                                    transactionCalculatorOption = int.Parse(Console.ReadLine());
                                                    //Switch Transaction Calculator
                                                    switch (transactionCalculatorOption)
                                                    {
                                                        //Balance After Deposit
                                                        case 1:
                                                            Console.WriteLine($"Your new balance after deposit = {(balance + deposit):N3}" + " OMR" );
                                                            break;
                                                        //Balance After Withdrawal
                                                        case 2:
                                                            Console.WriteLine($"Your new balance after withdrawal = {(balance - withdrawal):N3}" + " OMR");
                                                            break;
                                                        //Annual Interest Earned
                                                        case 3:
                                                            double interest = balance * annualRate;
                                                            Console.WriteLine("The rate applied: " + annualRate);
                                                            Console.WriteLine($"Your annual interest = {interest:N3}" + " OMR");
                                                            break;
                                                        //Net Balance Change
                                                        case 4:
                                                            double net = deposit - withdrawal;
                                                            if (net >= 0)
                                                            {
                                                                Console.WriteLine("");
                                                                Console.WriteLine("Surplus");
                                                                Console.WriteLine("");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("");
                                                                Console.WriteLine("Deficit");
                                                                Console.WriteLine("");
                                                            }
                                                            break;
                                                        //Back To the Previous Menu
                                                        case 0:
                                                            Console.WriteLine("Back to the Previous Menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Calculation not available.");
                                                            break;

                                                    }// END Switch Transaction Calculator
                                                }// END While Loop Transaction Calculator
                                                break;
                                            //Task 7 - Account Type Information
                                            case 2:
                                                // Account Type Information While loop
                                                while (accountTypeInformation != 0) 
                                                {
                                                    Console.WriteLine("""
                                                        === ACCOUNT TYPES ===
                                                        Your account type: S (Savings)
                                                        1) Savings Account
                                                        2) Current Account
                                                        3) Fixed Deposit
                                                        4) Junior Account
                                                        0) Back
                                                        
                                                        """);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Select type:");
                                                    accountTypeInformation = int.Parse(Console.ReadLine());
                                                    string accountTypeStr;
                                                    // Switch Account Type Inforamtion
                                                    switch (accountTypeInformation)
                                                    {
                                                        // Saving Account 
                                                        case 1:
                                                            accountTypeStr = "Savings Account";
                                                            double savingMinBalance = 100.000;
                                                            double monthlyFee = 1.000;
                                                            
                                                            Console.Write(accountTypeStr + " | " + "Min: " + savingMinBalance + " OMR" + " | " + "Fee: " + monthlyFee + " OMR/Month");
                                                  
                                                            if (accountType == 'S')
                                                            {
                                                                Console.WriteLine("*** This is your account type ***");
                                                            }
                                                            if (savingMinBalance > 500)
                                                            {
                                                                Console.WriteLine("Requires manager approval");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Can be opened at any branch.");
                                                            }
                                                            break;
                                                        // Current Account
                                                        case 2:
                                                            accountTypeStr = "Current Account";
                                                            double currentMinBalance = 100.000;
                                                            double monthlyCurrentFee = 1.000;

                                                            Console.Write(accountTypeStr + " | " + "Min: " + currentMinBalance + " OMR" + " | " + "Fee: " + monthlyCurrentFee + " OMR/Month");

                                                            if (accountType == 'C')
                                                            {
                                                                Console.WriteLine("*** This is your account type ***");
                                                            }
                                                            if (currentMinBalance > 500)
                                                            {
                                                                Console.WriteLine("Requires manager approval");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Can be opened at any branch.");
                                                            }
                                                            break;
                                                        // Fixed Deposit
                                                        case 3:
                                                            accountTypeStr = "Fixed Account";
                                                            double fixedMinBalance = 100.000;
                                                            double monthlyFixedFee = 1.000;

                                                            Console.Write(accountTypeStr + " | " + "Min: " + fixedMinBalance + " OMR" + " | " + "Fee: " + monthlyFixedFee + " OMR/Month");

                                                            if (accountType == 'F')
                                                            {
                                                                Console.WriteLine("*** This is your account type ***");
                                                            }
                                                            if (fixedMinBalance > 500)
                                                            {
                                                                Console.WriteLine("Requires manager approval");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Can be opened at any branch.");
                                                            }
                                                            break;
                                                        // Junior Account
                                                        case 4:
                                                            accountTypeStr = "Junior Account";
                                                            double juniorMinBalance = 100.000;
                                                            double monthlyJuniorFee = 1.000;

                                                            Console.Write(accountTypeStr + " | " + "Min: " + juniorMinBalance + " OMR" + " | " + "Fee: " + monthlyJuniorFee + " OMR/Month");

                                                            if (accountType == 'J')
                                                            {
                                                                Console.WriteLine("*** This is your account type ***");
                                                            }
                                                            if (juniorMinBalance > 500)
                                                            {
                                                                Console.WriteLine("Requires manager approval");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Can be opened at any branch.");
                                                            }
                                                            break;
                                                        // Back to Previous Menu
                                                        case 0:
                                                            Console.WriteLine("Back to the Previous Menu.");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Account type not offered.");
                                                            break;
                                                    }//End Switch Account Type Information
                                                }// END While Loop Account Type Information 
                                                break;
                                            //Loan Eligibility Checker
                                            case 3:
                                                break;

                                            case 0:
                                                Console.WriteLine("Back to main menu.");
                                                break;
                                            default:
                                                Console.WriteLine("Invalid selection!! please enter your choice again");
                                                break;
                                        }//END Switch Account Management
                                    }//END While Loop Account Management

                                    break;//END Of Tasks 6 - 8 
                                          
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
