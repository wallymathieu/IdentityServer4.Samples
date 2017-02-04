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
            return this.Ok(new {
                claims=this.User.Claims.Select(c=>$"{c.Type}:{c.Value}")
            });
        }
    }
}