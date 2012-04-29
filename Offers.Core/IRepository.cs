using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Offers.Core
{
    public interface IRepository
    {
        IQueryable<Catlog> CatLogs { get; }
        IQueryable<Deal> Deals { get; }
    }
}
