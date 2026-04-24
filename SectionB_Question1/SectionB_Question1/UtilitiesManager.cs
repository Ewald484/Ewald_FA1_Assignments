using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    public class UtilitiesManager
    {
        // We must create a list to store all the service request from the Residents that are made
        public List<ServiceRequest> Requests = new List<ServiceRequest>();

        // Add request 
        public void RequestAdd(ServiceRequest request)
        {
            request.UrgencyScore = CalculateUrgencyScore(request);
            Requests.Add(request);
        }

        //All the calculation Methods that will be used are listed below
        public int CalculateUrgencyScore(ServiceRequest request)
        {
            return request.Priority * request.SeverityLevel;
        }
        // Calculate the time
        public int CalculateTime(ServiceRequest request) 
        { 
            return request.EstimatedHours + (request.SeverityLevel / 2);
        }
        // Calculate the Impact
        public double CalculateImpact(ServiceRequest request)
        {
            return request.Resident.MounthlyUsage * request.Priority;

        }

        // This method will be used to display the service request in the order of their urgency score, from highest to lowest
        public void QueueDisplay()
        {

            Console.WriteLine("\n=== Pending Request ===");
            
            foreach (var request in Requests.OrderByDescending(r => r.UrgencyScore))
            {

                Console.WriteLine($"{request.Resident.Name} | {request.RequestType} | Urgency: {request.UrgencyScore}");

            }

        }
        // This method will be used to process the service request
        public void ProcessRequests()
        {
            foreach (var request in Requests.OrderByDescending(r => r.UrgencyScore))
            {
                // The display of the Service Report
                Console.WriteLine("\n=== Service ===");
                Console.WriteLine($"Resident: {request.Resident.Name}");
                Console.WriteLine($"Service Type: {request.RequestType}");
                Console.WriteLine($"Urgency Score: {request.UrgencyScore}");
                Console.WriteLine($"Adjusted Resolution: {CalculateTime(request)} hours");
                Console.WriteLine($"Household Impact Score: {CalculateImpact(request):F2}");

            }
        }

        public void showsummary()
        {
            // Find the request with the highest urgency
            var highest = Requests.OrderByDescending(r => r.UrgencyScore).First();

            // Display the Final Minucipal Summary

            Console.WriteLine("\n==== Final Municipal Summary ====");
            Console.WriteLine($"Highest Priority Issue:");
            Console.WriteLine($"Resident: {highest.Resident.Name}");
            Console.WriteLine($"Service Type: {highest.RequestType}");
            Console.WriteLine($"Urgency Score: {highest.UrgencyScore}");
            Console.WriteLine($"Adjusted Resolution: {CalculateTime(highest)} hours");
            Console.WriteLine($"Household Impact Score: {CalculateImpact(highest):F2}");


        }

    }
}
