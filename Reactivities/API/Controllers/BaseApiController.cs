using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class BaseApiController : ControllerBase
    {
    }
}
