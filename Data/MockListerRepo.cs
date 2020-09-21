using System.Collections.Generic;
using ToDoLister.Models;
using System;

namespace ToDoLister.Data
{
    public class MockListerRepo : IListerRepository
    {
        public IEnumerable<Item> GetAllItems()
        {
            return new List<Item>{
                new Item{Id=1, Description="Hacer la tarea", Status=StatusOptions.Pending, 
                    DueDate=DateTime.Parse("2020-08-09"), Owner=new User{Id=1, Handle="dejim"}},
                new Item{Id=2, Description="Hacer la cama", Status=StatusOptions.Pending, 
                    DueDate=DateTime.Parse("2020-10-09"), Owner=new User{Id=1, Handle="dejim"}}
            };
        }
    }
}