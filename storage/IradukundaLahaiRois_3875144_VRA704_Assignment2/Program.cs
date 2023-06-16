/*Author: Lahai Rois Iradukunda, 3875144
 Lahai Bank system*/
using System;

namespace Iradukunda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  LAHAI Bank !");
            Banking Lahai = new Banking(); // new instance banking class
            Lahai. logIn();// user instance to call new options 
            Console.WriteLine();
        }
    }
    //Banking class
    class Banking
    {
        public void logIn()
        {
            int attempt = 1;
            string securityAnswer = "Kigali";
           
            while (attempt <= 3)
            {
                Console.Write("Username:");
                string username = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine();

                if (username == "Iradukunda" && password == "Lahairois")
                {
                    string a = ("Login successful!!!!");
                    Console.WriteLine(a);
                    Options();
                    break;
                }
                else if (attempt == 2 || attempt == 3)
                {
                    Console.Write("Security question: In which City were you born in?");
                    string answer = Console.ReadLine();
                    if (answer == securityAnswer)
                    {
                        Console.WriteLine("Security answer correct.");
                    }
                    else
                    {
                        Console.WriteLine("security answer incorrect.");
                        attempt++;
                        continue;
                    }
                }
                Console.WriteLine("Login failed. Please try again.");
                attempt++;

            }

            if (attempt > 3)
            {
                Console.WriteLine("Access blocked.");
               
            }
            Console.ReadLine();
        }


        public Banking() // banking constructor
        {

        }
        //Method to display the Banking options
        public void Options()
        {
            Console.WriteLine("Select from the options below.");
            Console.WriteLine("1- Change name and pin\n2- Available balance\n3- Withdraw money\n4- Transfer money\n5- Account details\n6- Log out");
            Console.WriteLine();
            string input = Console.ReadLine();

            if (CheckNum(input))
            {
                int selection = Convert.ToInt32(input);
                switch (selection)
                {
                    case 1:
                        RunChangeNameAndPin();
                        Options();
                        Console.WriteLine();
                        break;

                    case 2:
                        AvailableBalance();
                        Options();
                        Console.WriteLine();
                        break;
                    case 3:
                        WithdrawMoney();
                        Options();
                        Console.WriteLine();
                        break;

                    case 4:
                        RunTransferMoney();
                        Options();
                        Console.WriteLine();
                        break;
                    case 5:
                        AccountDetails();
                        Options();
                        Console.WriteLine();
                        break;
                    case 6:
                        LogOut();
                        Options();
                        Console.WriteLine();
                        break;

                }

            }

        }
        //method to check if input string is an integer
        public bool CheckNum(string inputNum)
        {
            bool isNum = int.TryParse(inputNum, out int n);
            return isNum;
        }
        //method to run the change of name and pin
        public void RunChangeNameAndPin()
        {
            Console.WriteLine("Enter new Username.");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter the new PIN");
            string PinNumber = Console.ReadLine();
            if (CheckNum(PinNumber) == true)
            {
                int PinNumberConverted = Convert.ToInt32(PinNumber);
                ChangeNameAndPin(UserName, PinNumberConverted);
            }
            else
            {
                Console.WriteLine("Please enter valid value.");
                RunChangeNameAndPin();
                Console.WriteLine();

            }
        }
    //method to change name and pin
    static void ChangeNameAndPin(string UserName, int PinNumberConverted)
        {

            Console.WriteLine(" Username and Pin was changed successfully!.  ");

            Console.WriteLine();
        }

        //Method to check the available balance
        static void AvailableBalance()
        {
            double Balance = 120000;

            Console.WriteLine("You have R" + Balance + " available on your account.");

        }
        //method to withdraw money (it will work perfectly when it is the first choice you put in)
        public void WithdrawMoney()
        {
            int AccountMoney = 120000;
            Console.WriteLine("Enter the amount?");
            int Amount = 0;
            Amount = int.Parse(Console.ReadLine());
            if (Amount % 1000 != 0)
            {
                Console.WriteLine("Please Enter amount above R1000.");
            }
            else if (Amount > (AccountMoney - 1000))
            {
                Console.WriteLine("Sorry! Insufficient balance.");
            }
            else
            {
                AccountMoney = AccountMoney - Amount;
                Console.WriteLine("R" + Amount + " Have been drawn from your account.");
                Console.WriteLine("Available balance is " + AccountMoney);
            }

        }
        //Method to run transfer of money to another account
        public void RunTransferMoney()
        {
            Console.WriteLine("Enter the amount?");
            string Amount = Console.ReadLine();
            if (CheckNum(Amount) == true)
            {
                int AmountConverted = Convert.ToInt32(Amount);
                TransferMoney();

                Console.WriteLine("R"+ AmountConverted + " amount have been transferred from your account.");
            }
            else
            {
                Console.WriteLine("Please enter valid value.");
                RunTransferMoney();
                Console.WriteLine();

            }
        }
        //Method to transfer money , it require inserting bank nber to transfer to
       public void TransferMoney()
       {

            Console.WriteLine("enter account number to transfer to.");
            string Account = Console.ReadLine();
            if (CheckNum(Account)==true)
            {
                int AccountConverted = Convert.ToInt32(Account);

            }
            else
            {
                Console.WriteLine("Please enter valid value.");
                TransferMoney();
                Console.WriteLine();
            }

       }
        //Method to show the account details.
       static void AccountDetails()
       {
            Console.WriteLine("Name and Surname: Lahai Rois Iradukunda");
            Console.WriteLine("Account Number: 123456789");
            Console.WriteLine("Date of Birth: 19780101");
            Console.WriteLine("Gender: Male");

       }

        static void LogOut()
        {
            do
                Console.WriteLine("Would you like to continue? (Y = Yes ,N = No):  ");

            while (Console.ReadLine().ToUpper() == "N");
            
        }




 
    }
}

