using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            // Create a list to store the residents of the Utilities Manager

            List<Resident> residents = new List<Resident>();
            UtilitiesManager manager = new UtilitiesManager();

            Console.Write("How many resident do you want to register? ");
            int residentcount = int.Parse(Console.ReadLine());


            // Loop to register residents

            for (int i = 0; i < residentcount; i++)
            {

                Console.WriteLine($"\n--- Resident {i + 1} ---");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Account Number: ");
                string accountnumber = Console.ReadLine();

                Console.Write("Monthly Utility Usage: ");
                double usage = double.Parse(Console.ReadLine());

                residents.Add(new Resident(name, address, accountnumber, usage));

            }

            Console.Write("\nHow many service request do you want to log? ");
            int requestcount = int.Parse(Console.ReadLine());

            for(int i = 0;i < requestcount;i++)
            {
                Console.WriteLine($"\n--- Service Request {i + 1} ---");

                Console.Write($"Select resident (1 to {residentcount}): ");
                int index = int.Parse(Console.ReadLine()) -1;

                Console.Write("Request Type: ");
                string type = Console.ReadLine();

                Console.Write("Priority Level (1-5): ");
                int priority = int.Parse(Console.ReadLine());

                Console.Write("Severity Level (1-10): ");
                int severity = int.Parse(Console.ReadLine());

                Console.Write("Estimated Resolution Hours: ");
                int hours = int.Parse(Console.ReadLine());

                ServiceRequest request = new ServiceRequest(residents[index], type, priority, severity, hours);
                manager.RequestAdd(request);

            }

            manager.QueueDisplay();

            manager.ProcessRequests();

            manager.showsummary();

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");

        }
    }
}
