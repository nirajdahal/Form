using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.FormModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace FormApi.Controllers
{
    [Route("api/forms")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostValues([FromBody] FormPostModel form)
        {
            var testVal = form;
            return Ok("Succesfully posted");
        }
    }

   
}
