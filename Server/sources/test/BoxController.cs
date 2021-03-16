using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace test
{
    [ApiController]
    [Route("Boxes")]
    public class BoxController : Controller
    {
        public BoxController() { }

        [HttpGet("Cards")]
        public List<Card> GetCards()
        {
            var context = new ApplicationContext();
            var cards = context.Cards.ToList();
            return cards;
        }
        [HttpPost("Cards")]
        public void AddCard()
        {
            var context = new ApplicationContext();
            context.Cards.Add(new Card());
            context.SaveChanges();
        }
        [HttpGet("Boxes")]
        public List<Box> GetBoxes()
        {
            var context = new ApplicationContext();
            var boxes = context.Boxes.ToList();
            return boxes;
        }
        [HttpPost("Boxes")]
        public void AddBoxes()
        {
            var context = new ApplicationContext();
            context.Boxes.Add(new Box());
            context.SaveChanges();
        }
    }
}
