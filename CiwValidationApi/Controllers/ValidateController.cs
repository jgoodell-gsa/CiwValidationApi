using CiwValidationApi.Models;
using System.Web.Http;
using System.Linq;

namespace CiwValidationApi.Controllers
{
    [Route("api/validate")]
    public class ValidateController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("success");
        }

        // POST: api/Validate
        [HttpPost]
        public IHttpActionResult Post([FromBody] Person employee)
        {
            //Person employee = Newtonsoft.Json.JsonConvert.DeserializeObject(value) as Person;
            var employeeValidator = new Validator.Validate.EmployeeValidationRules();
            var validationResult = employeeValidator.Validate(employee);
            var filteredResult = validationResult.Errors.Select(p => new {p.AttemptedValue, p.ErrorMessage, p.PropertyName}).ToList();
            return Ok(new {validationResult.IsValid, ErrorCount = validationResult.Errors.Count, ErrorList = filteredResult});

        }
    }
}
