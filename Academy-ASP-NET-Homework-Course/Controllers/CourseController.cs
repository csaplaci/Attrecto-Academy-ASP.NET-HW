using Academy_ASP_NET_Homework_Course.Data;
using Microsoft.AspNetCore.Mvc;

namespace Academy_ASP_NET_Homework_Course.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public static List<Course>? Courses { get; set; }

        //Create
        [HttpPost]
        public ActionResult Post([FromBody] Course data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            Courses.Add(data);
            return NoContent();
        }

        //Read
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id)
                    return Ok(course);
            }
            return NotFound();
        }
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return Courses;
        }

        //Update
        [HttpPut("{id}")]
        public ActionResult<Course> Put(int id, [FromBody] Course data)
        {
            foreach(var course in Courses)
            {
                if (course.Id == id)
                {
                    course.Name = data.Name;
                    course.Description = data.Description;
                    return NoContent();
                }
            }
            return NotFound();
        }

        //Delete
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id)
                {
                    Courses.Remove(course);
                    return NoContent();
                }
            }
            return NotFound();
        }
    }
}
