using System.Collections.Generic;

namespace Rundown.Models
{
    public class IssueEdit : Issue
    {
        public IssueEdit()
        {
        }

        public IssueEdit(Issue issue)
        {
            ActualResolutionDate = issue.ActualResolutionDate;
            Description = issue.Description;
            ExpectedResolutionDate = issue.ExpectedResolutionDate;
            IsDeleted = issue.IsDeleted;
            IssueId = issue.IssueId;
            Status = issue.Status;
            Title = issue.Title;
        }

        public Dictionary<int, string> AllStatuses { get; set; }
    }
}