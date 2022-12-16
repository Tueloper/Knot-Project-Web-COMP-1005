using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnoxLogic.Responses
{
    public class Knot_API_Response_Error
    {
        public string ResponseMessage { get; set; }
        public string ResponseError { get; set; }
        public bool IsResponseSuccessful { get; set; }
    }
}
