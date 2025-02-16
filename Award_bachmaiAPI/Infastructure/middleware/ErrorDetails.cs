using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.middleware
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ErrorCode { get; set; }
    }
}
