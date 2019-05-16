using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_newsletter.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Reason { get; set; }
        public string Heard { get; set; }
    }
}
