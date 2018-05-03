using System.Collections.Generic;

namespace Rundown.Models.Interfaces
{
    public interface IIssueRepository
    {
        List<Issue> GetIssues();

        void AddIssue(Issue issue);

        Dictionary<int, string> GetStatuses();
    }
}