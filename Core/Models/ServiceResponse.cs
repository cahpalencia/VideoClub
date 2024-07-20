using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ServiceResponse
    {
        public string Method { get; set; }
        public int responseCode { get; set; }
        public object? responseObject { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
