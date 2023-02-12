using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.DAL
{
    public class TodoListContext : DbContext
    {
        public TodoListContext() : base("ConnectionString")
        {

        }
        public DbSet<TodoModel> TodoModel { get; set; }
    }
}
