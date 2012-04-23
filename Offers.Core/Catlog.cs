using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Offers.Core
{
    class Catlog
    {
        [Key]
        public string Name { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
