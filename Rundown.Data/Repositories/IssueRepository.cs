using AutoMapper;
using Rundown.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rundown.Data.Repositories
{
    public class IssueRepository : Models.Interfaces.IIssueRepository
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

        public void DeleteIssue(int id)
        {
            using (var db = new RundownEntities())
            {
                var issueToDelete = db.Issues.SingleOrDefault(x => x.IssueId == id);
                issueToDelete.IsDeleted = true;
                db.SaveChanges();
            }
        }

        public Issue GetIssue(int id)
        {
            using (var db = new RundownEntities())
            {
                var result = (from i in db.Issues
                              where i.IssueId == id
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
                              .SingleOrDefault();

                return result;
            }
        }

        /// <summary>
        /// Returns all active issues.
        /// </summary>
        /// <returns></returns>
        public List<Issue> GetIssues()
        {
            using (var db = new RundownEntities())
            {
                var results = (from i in db.Issues
                               where !i.IsDeleted
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

        public void UpdateIssue(Issue issue)
        {
            try
            {
                using (var db = new RundownEntities())
                {
                    var dbIssue = db.Issues.SingleOrDefault(x => x.IssueId == issue.IssueId);

                    dbIssue.ActualResolutionDate = issue.ActualResolutionDate;
                    dbIssue.Description = issue.Description;
                    dbIssue.ExpectedResolutionDate = issue.ExpectedResolutionDate;
                    dbIssue.IsDeleted = issue.IsDeleted;
                    dbIssue.StatusId = int.Parse(issue.Status);
                    dbIssue.Title = issue.Title;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}