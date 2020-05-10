namespace TotoStatistics.Services.Toto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TotoStatistics.Models;

    public interface ISixOutOfForty_nineServices
    {
        Task<List<SixOutOfForty_nine>> GetListAsync();
    }
}
