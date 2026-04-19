using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
            Console.WriteLine(); // Break line

            Console.Write("HI , WHAT IS YOUR NAME? ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"WELCOME {name.ToUpper()}");

            double balance;
            // We use a while loop to keep giving the user the input until they type in a correct value
            // We asked the user to type in their balance
            while(true)
            {
                Console.Write("Enter account balance: ");
                string userbalance = Console.ReadLine();

                if (double.TryParse(userbalance, out balance))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }

            }


            double withdrawal;

            // We asked the user to enter a withdrawl ammount with the validation to check
            while (true)
            {
                Console.Write("Enter withdrawal ammount: ");
                string userwithdrawal = Console.ReadLine();

                if (double.TryParse(userwithdrawal, out withdrawal))
                {
                    // Check if the ammount of the withdrawal is lower than the users balance

                    if (withdrawal > balance)
                    {
                        Console.WriteLine("Please enter a ammount lower than your balance");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Calculate the new balance after the withdrawal
            double updatebalance = balance - withdrawal;

            string withdrawaltime = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");


            // Display all the details

            Console.WriteLine(); // Break Line
            Console.WriteLine($"Withdrawal successful!");
            Console.WriteLine($"Updated Balance: {updatebalance:0.00}");
            Console.WriteLine($"Transaction Time: {withdrawaltime}");

        }
    }
}
