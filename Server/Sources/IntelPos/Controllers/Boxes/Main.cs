using IntelPos.Controllers.Models.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelPos.Controllers.Boxes
{
    public class Main : Controller
    {
        private readonly SqlContext context;

        public Main(SqlContext context)
        {
            this.context = context;
        }


        [HttpGet("")]
        public async Task<BaseCollectionResponse<BoxSummary>> GetBoxes()
        {
            var query = this.Query();

            var boxes = await query.ToArrayAsync();
            var summaries = new List<BoxSummary>();
            foreach(var box in boxes)
            {
                summaries.Add(new BoxSummary(box));
            }

            return new BaseCollectionResponse<BoxSummary>(summaries);
        }

        private IQueryable<Box> Query()
        {
            return this.context
                       .Boxes
                       .Include(b => b.Cards);
        }
    }
}
