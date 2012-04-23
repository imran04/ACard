using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Offers.Core
{
    class Deal
    {
        [Key]
        public Guid DealId { get; set; }
        public string DealName { get; set; }
        public string ShortDesc { get; set; }
        public string FullDesc { get; set; }
        public virtual Catlog Catlog {get;set;}
    }
}
