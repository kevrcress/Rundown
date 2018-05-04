using System.Collections.Generic;

namespace Rundown.Models.Interfaces
{
    public interface IIssueRepository
    {
        List<Issue> GetIssues();

        Issue GetIssue(int id);

        void AddIssue(Issue issue);

        void UpdateIssue(Issue issue);

        void DeleteIssue(int id);

        Dictionary<int, string> GetStatuses();
    }
}