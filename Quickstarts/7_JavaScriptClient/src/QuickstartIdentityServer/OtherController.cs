using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace QuickstartIdentityServer
{
    [Route("/other")]
    public class OtherController:Controller
    {
        [HttpGet("")]
        public IActionResult Get(){
            return this.Ok(new {
                claims=this.User.Claims.Select(c=>$"{c.Type}:{c.Value}")
            });
        }
    }
}