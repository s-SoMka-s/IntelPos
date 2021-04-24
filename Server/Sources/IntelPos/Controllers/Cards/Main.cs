using IntelPos.Controllers.Models.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelPos.Controllers.Cards
{

    [Route("/Cards")]
    public class Main : Controller
    {
        private readonly SqlContext context;

        public Main(SqlContext context)
        {
            this.context = context;
        }   
        

        [HttpGet("")]
        public async Task<BaseCollectionResponse<CardSummary>> GetCards()
        {
            var query = this.Query();

            var cards = await query.ToArrayAsync();

            var summaries = new List<CardSummary>();
            foreach (var card in cards){
                summaries.Add(new CardSummary(card));
            }

            return new BaseCollectionResponse<CardSummary>(summaries);
        }


        private IQueryable<Card> Query()
        {
            return this.context.Cards;
        }
    }
}
