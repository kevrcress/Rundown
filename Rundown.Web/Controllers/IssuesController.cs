using Rundown.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Rundown.Web.Controllers
{
    public class IssuesController : Controller
    {
        // GET: Issues
        public ActionResult Index()
        {
            var model = new List<Rundown.Models.Issue>();
            var issueService = new Core.Services.IssueService();
            model = issueService.GetIssues();
            return View(model);
        }

        // GET: Issues/Details/5
        public ActionResult Details(int id)
        {
            var model = new Rundown.Models.Issue();
            return View(model);
        }

        // GET: Issues/Create
        public ActionResult Create()
        {
            var model = new Rundown.Models.IssueEdit();
            var issueService = new Rundown.Core.Services.IssueService();
            model.AllStatuses = issueService.GetStatuses();
            return View(model);
        }

        // POST: Issues/Create
        [HttpPost]
        public ActionResult Create(Issue newIssue)
        {
            try
            {
                var issueService = new Rundown.Core.Services.IssueService();
                issueService.AddIssue(newIssue);

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
            return View();
        }

        // POST: Issues/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Issues/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Issues/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}