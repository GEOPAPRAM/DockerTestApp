using System;
using System.Web.Http;
using System.Configuration;

namespace DockerSelfhostWebApi
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/hello")]
        public string HelloWorld()
        {
            
            return string.Format("Hello, cosmos! Said at {0}", DateTime.Now.ToShortTimeString());
        }
    }
}
