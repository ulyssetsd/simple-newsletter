using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace simple_newsletter.Models
{
    public enum HeardEnum
    {
        Advert,
        [Display(Name = "Word of Mouth")]
        Word,
        Other
    }
}
