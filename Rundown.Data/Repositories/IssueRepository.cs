using AutoMapper;
using Rundown.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rundown.Data.Repositories
{
    public class IssueRepository : Rundown.Models.Interfaces.IIssueRepository
    {
        public void AddIssue(Issue issue)
        {
            using (var db = new RundownEntities())
            {
                var dbIssue = Mapper.Map<Data.Issues>(issue);
                db.Issues.Add(dbIssue);
                db.SaveChanges();
            }
        }

        public List<Issue> GetIssues()
        {
            using (var db = new RundownEntities())
            {
                var results = (from i in db.Issues
                               select new Issue
                               {
                                   Title = i.Title,
                                   Description = i.Description,
                                   ActualResolutionDate = i.ActualResolutionDate,
                                   ExpectedResolutionDate = i.ExpectedResolutionDate,
                                   IsDeleted = i.IsDeleted,
                                   IssueId = i.IssueId,
                                   Status = i.Statuses.Status
                               })
                               .ToList();

                return results;
            }
        }

        public Dictionary<int, string> GetStatuses()
        {
            using (var db = new RundownEntities())
            {
                var results = (from s in db.Statuses
                               where s.IsDisabled == false
                               select new { s.StatusId, s.Status }).ToDictionary(x => x.StatusId, x => x.Status);

                return results;
            }
        }
    }
}