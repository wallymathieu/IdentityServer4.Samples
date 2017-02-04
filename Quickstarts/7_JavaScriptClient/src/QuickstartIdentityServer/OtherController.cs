using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace QuickstartIdentityServer
{
    [Route("/other")]
    public class OtherController:Controller
    {
        [HttpGet("")]
        public IActionResult Get(){
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}