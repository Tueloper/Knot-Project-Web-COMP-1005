using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnoxLogic.Responses
{
    public class APIResponse
    {
        public string APIResponseMessage { get; set; }
        public bool IsAPIMessageSuccessful { get; set; }
    }
    public class APIResponse<T> : APIResponse
    {
        public T Value { get; set; }
    }
}
