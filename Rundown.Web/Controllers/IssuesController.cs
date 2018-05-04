using Rundown.Core.Services;
using Rundown.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Rundown.Web.Controllers
{
    public class IssuesController : Controller
    {
        private IssueService _issueService = new IssueService();

        // GET: Issues
        public ActionResult Index()
        {
            var model = new List<Issue>();
            model = _issueService.GetIssues();
            return View(model);
        }

        // GET: Issues/Details/5
        public ActionResult Details(int id)
        {
            var model = new Issue();
            return View(model);
        }

        // GET: Issues/Create
        public ActionResult Create()
        {
            var model = new Rundown.Models.IssueEdit();
            model.AllStatuses = _issueService.GetStatuses();
            return View(model);
        }

        // POST: Issues/Create
        [HttpPost]
        public ActionResult Create(Issue newIssue)
        {
            try
            {
                _issueService.AddIssue(newIssue);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Issues/Edit/5
        public ActionResult Edit(int id)
        {
            var issue = _issueService.GetIssue(id);
            var issueEdit = new IssueEdit(issue);
            issueEdit.AllStatuses = _issueService.GetStatuses();
            return View(issueEdit);
        }

        // POST: Issues/Edit/5
        [HttpPost]
        public ActionResult Edit(IssueEdit modifiedIssue)
        {
            try
            {
                var issue = new Issue(modifiedIssue);
                _issueService.UpdateIssue(issue);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Issues/Delete/5
        [HttpPost]
        public ActionResult Delete(int issueId)
        {
            try
            {
                _issueService.DeleteIssue(issueId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}