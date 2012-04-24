using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Offers.Core
{
    public  class Catlog
    {
        [Key]
        public int CatLogId{get;set;}
        public string Name { get; set; }
        public string Desc { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
