using System.Collections.Generic;
using System.Web.Mvc;
using HoneyDoList.Domain.Entities;
using HoneyDoList.Models;

namespace HoneyDoList.Controllers
{
  public class TasksController : Controller
  {
    //
    // GET: /Tasks/

    public ActionResult Index()
    {
      var model = new List<Task>();
      return View(model);
    }

    //
    // GET: /Tasks/Details/5

    public ActionResult Details(int id)
    {
        var MyTask = new TaskModel();

        MyTask.TaskName = "This is the awesome name of my task";
        MyTask.TaskDescription = "This is my awesome task description.This is my awesome task description.This is my awesome task description. ";
        MyTask.TaskDate = new System.DateTime();
        MyTask.TaskId = 12;
      return View(MyTask);
    }

    //
    // GET: /Tasks/Create

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /Tasks/Create

    [HttpPost]
    public ActionResult Create(FormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    //
    // GET: /Tasks/Edit/5

    public ActionResult Edit(int id)
    {
      return View();
    }

    //
    // POST: /Tasks/Edit/5

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

    //
    // GET: /Tasks/Delete/5

    public ActionResult Delete(int id)
    {
      return View();
    }

    //
    // POST: /Tasks/Delete/5

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