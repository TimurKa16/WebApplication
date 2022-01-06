using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpClientWinForms
{
    public class PostMessage
    {
        public int Id { get; set; }
        public string FromWhom { get; set; }
        public string ToWhom { get; set; }
        public string Message { get; set; }
    }

    public class ResponseMessage
    {
        public int id { get; set; }
        public string fromWhom { get; set; }
        public string toWhom { get; set; }
        public string message { get; set; }
    }

}
