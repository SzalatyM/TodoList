using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private static IList<TodoModel> todoList = new List<TodoModel>()
        {
            new TodoModel(){TaskId = 1, Name = "Make a excercise ", Destriptions = "For interview", ReleaseDate = DateTime.Today}
        };
        // GET: TodoController
        public ActionResult Index()
        {
            return View(todoList);
        }

        // GET: TodoController/Details/5
        public ActionResult Details(int id)
        {
            return View(todoList.FirstOrDefault(t => t.TaskId == id));
        }

        // GET: TodoController/Create
        public ActionResult Create()
        {

            return View(new TodoModel());
        }

        // POST: TodoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoModel todoModel)
        {
            todoModel.TaskId = todoList.Count + 1;
            todoList.Add(todoModel);
                return RedirectToAction(nameof(Index));          
        }

        // GET: TodoController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(todoList.FirstOrDefault(t => t.TaskId == id));
        }

        // POST: TodoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,TodoModel todoModel)
        {
            TodoModel todo = todoList.FirstOrDefault(t => t.TaskId == id);
            todo.Name = todoModel.Name;
            todo.Destriptions = todoModel.Destriptions;
            todo.ReleaseDate = todoModel.ReleaseDate;

                return RedirectToAction(nameof(Index));
           
        }

        // GET: TodoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(todoList.FirstOrDefault(t => t.TaskId == id));
        }

        // POST: TodoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TodoModel todoModel)
        {
            TodoModel todo = todoList.FirstOrDefault(t => t.TaskId == id);
            todoList.Remove(todo);
                return RedirectToAction(nameof(Index));
            
        }
    }
}
