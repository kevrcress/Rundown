using Rundown.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rundown.Core.Services
{
    public class IssueService
    {
        private Models.Interfaces.IIssueRepository _issueRepository = new Rundown.Data.Repositories.IssueRepository();

        public List<Issue> GetIssues()
        {
            return _issueRepository.GetIssues().OrderByDescending(x => x.IssueId).ToList();
        }

        public void AddIssue(Issue issue)
        {
            _issueRepository.AddIssue(issue);
        }

        public Dictionary<int, string> GetStatuses()
        {
            return _issueRepository.GetStatuses();
        }

    }
}