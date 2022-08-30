using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POSWebAppl.Models.View_Model
{
    public class NewAgents
    {
        public string AgentName { get; set; }
        public string WorkingArea { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Regdate { get; internal set; }
    }
}