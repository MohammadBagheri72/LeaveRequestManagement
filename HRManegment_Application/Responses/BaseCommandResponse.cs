using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Responses
{
    public class BaseCommandResponse
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool Succses { get; set; }
        public List<string> Errors { get; set; }
    }
}
