using Microsoft.AspNetCore.Mvc;
using ToDoLister.Data;
using ToDoLister.Models;

namespace ToDoLister.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IListerRepository _repo;

        public ItemsController(IListerRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<Item> GetAllItems()
        {
            return Ok(_repo.GetAllItems());
        }

    }
}