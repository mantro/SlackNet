using System;
using System.Collections.Generic;

namespace SlackNet
{
    public class Incident
    {
        public string Id { get; set; }
        
        public DateTime DateCreated { get; set; }
        
        public DateTime DateUpdated { get; set; }
        
        public string Title { get; set; }
        
        public IncidentType Type { get; set; }
        
        public SlackStatus Status { get; set; }
        
        public Uri Url { get; set; }
        
        public IList<string> Services { get; set; }
    }
}