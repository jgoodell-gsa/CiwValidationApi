using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CiwValidationApi.Models
{
    public abstract class Poc
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneWork { get; set; }
        public string EmailAddress { get; set; }
    }
}