using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models
{
    public class Email
    {
        public required string Address { get; set; }
        public required string Label { get; set; }
    }
}
