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

        [Required]
        [EmailAddress]
        [UniqueEmail]
        [Display(Name = "Enter your email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "How do you heard about us ?")]
        public HeardEnum Heard { get; set; }

        [Display(Name = "Reason for signing up (optional)")]
        public string Reason { get; set; }
    }

    public class UniqueEmailAttribute : ValidationAttribute
    {
        public UniqueEmailAttribute() : base("{0} is already subscribed !") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _context = (simple_newsletterContext)validationContext
                .GetService(typeof(simple_newsletterContext));

            bool contains = _context.Subscriber
                .Any(_sub => _sub.Email.ToLower().Equals((value as string).ToLower()));

            return contains ? 
                new ValidationResult(string.Format("{0} is already subscribed !", value)) :
                ValidationResult.Success;
        }
    }
}
