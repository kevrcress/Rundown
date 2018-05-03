using System;

namespace Rundown.Models
{
    public class Issue
    {
        public int IssueId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime? ExpectedResolutionDate { get; set; }

        public DateTime? ActualResolutionDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}