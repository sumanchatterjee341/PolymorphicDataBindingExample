using Microsoft.AspNetCore.Mvc;
using PolymorphicDataBindingExample.Model;

namespace PolymorphicDataBindingExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        [HttpPost]
        public List<Person> Add(List<Person> people)
        {
            return people;
        }
    }
}
