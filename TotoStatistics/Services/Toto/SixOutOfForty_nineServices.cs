namespace TotoStatistics.Services.Toto
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TotoStatistics.Data;
    using TotoStatistics.Models;

    public class SixOutOfForty_nineServices : ISixOutOfForty_nineServices
    {
        private ApplicationDbContext dbContext;

        public SixOutOfForty_nineServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<SixOutOfForty_nine>> GetListAsync()
        {
            var result = await dbContext.SixOutOfFortyNine.ToListAsync();
            return result;
        }
    }
}
