using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace simple_newsletter.Models
{
    public class Subscriber
    {
        public int Id { get; set; }

        [Display(Name = "Enter your email")]
        public string Email { get; set; }

        [Display(Name = "How do you heard about us ?")]
        public string Heard { get; set; }

        [Display(Name = "Reason for signing up (optional)")]
        public string Reason { get; set; }
    }
}
