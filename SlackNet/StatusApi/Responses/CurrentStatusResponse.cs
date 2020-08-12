using System;
using System.Collections.Generic;

namespace SlackNet.StatusApi.Responses
{
    public class CurrentStatusResponse
    {
        public SlackStatus Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
        
        public IList<Incident> ActiveIncidents { get; set; }
    }
}