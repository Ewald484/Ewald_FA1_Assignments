using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
        public class ServiceRequest
        {
            public Resident Resident { get; set; }
            public string RequestType { get; set; }
            public int EstimatedHours { get; set; }
            public int Priority { get; set; }
            public int SeverityLevel { get; set; }
            public int UrgencyScore { get; set; }

            public ServiceRequest(Resident resident, string requestType, int estimatedHours, int priority, int severityLevel, int urgencyScore)
            {
                Resident = resident;
                RequestType = requestType;
                EstimatedHours = estimatedHours;
                Priority = priority;
                SeverityLevel = severityLevel;
                UrgencyScore = urgencyScore;
        }

    }
}
