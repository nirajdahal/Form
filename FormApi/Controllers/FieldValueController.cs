using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.FormModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormApi.Controllers
{
    [Route("api/field")]
    [ApiController]
    public class FieldValueController : ControllerBase
    {
        public IActionResult GetFieldValue()
        {
            GetFieldModel fieldValue = new GetFieldModel();
            fieldValue.Field1 = "Field:1";
            fieldValue.Field2 = "Field:2";
            fieldValue.Field3 = "Field:3";
            fieldValue.Field4 = "Field:4";
            fieldValue.Field5 = "Field:5";
            fieldValue.Field6 = "Field:6";
            fieldValue.Field7 = "Field:7";

            return Ok(fieldValue);
        }
    }
}
