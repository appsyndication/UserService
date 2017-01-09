using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace AppSyndication.UserService.Web.Controllers
{
    [Route("user/claims")]
    public class UserClaimsController : Controller
    {
        // GET user/claims
        [HttpGet]
        public IActionResult Get()
        {
            return this.Json(this.User.Claims.Select(c => new { c.Type, c.ValueType }));
        }

        // GET api/values/sub
        [HttpGet("{claim}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
