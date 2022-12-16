using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnoxLogic.Models
{
    public class Knot_Login_API_Result
    {
        public string APIToken { get; set; }
        public DateTime Token_Expiry_Date { get; set; }
    }
}
