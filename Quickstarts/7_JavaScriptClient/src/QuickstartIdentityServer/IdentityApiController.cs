using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace QuickstartIdentityServer
{
    [Route("/api/identity")]
    [EnableCors("api")]
    [Authorize(Policy = "api_identity")]
    public class IdentityApiController:Controller
    {
        [HttpGet("")]
        public IActionResult Get(){
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}