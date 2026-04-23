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


        public int CalculateTime(ServiceRequest request) 
        { 
            return request.EstimatedHours + (request.SeverityLevel / 2);
        }

        public double CalaculateImpact(ServiceRequest request)
        {
            return request.Resident.MounthlyUsage * request.Priority;

        }

        // This method will be used to display the service request in the order of their urgency score, from highest to lowest
        public void QueueDisplay()
        {

        }


    }
}
