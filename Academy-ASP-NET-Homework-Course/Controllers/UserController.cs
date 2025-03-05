using Academy_ASP_NET_Homework_Course.Data;
using Microsoft.AspNetCore.Mvc;

namespace Academy_ASP_NET_Homework_Course.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User>? Users = new();
        //Create
        [HttpPost]
        public ActionResult Post([FromBody] User data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            Users.Add(data);
            return NoContent();
        }
        //Read
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                    return Ok(user);
            }
            return NotFound();
        }
        //Update
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] User data)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    user.FirstName = data.FirstName;
                    user.LastName = data.LastName;
                    user.Courses = data.Courses;
                    return NoContent();
                }
            }
            return NotFound();
        }
        //Delete
        [HttpDelete]
        public ActionResult<User> Delete(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    Users.Remove(user);
                    return NoContent();
                }
            }
            return NotFound();
        }
    }
}
