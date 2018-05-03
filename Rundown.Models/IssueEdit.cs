using System.Collections.Generic;

namespace Rundown.Models
{
    public class IssueEdit : Issue
    {
        public Dictionary<int, string> AllStatuses { get; set; }
    }
}