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

        public Issue()
        {
        }

        public Issue(IssueEdit issueEdit)
        {
            ActualResolutionDate = issueEdit.ActualResolutionDate;
            Description = issueEdit.Description;
            ExpectedResolutionDate = issueEdit.ExpectedResolutionDate;
            IsDeleted = issueEdit.IsDeleted;
            IssueId = issueEdit.IssueId;
            Status = issueEdit.Status;
            Title = issueEdit.Title;
        }
    }
}