using IntelPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelPos
{
    public class SampleData
    {
        public static void Initialize(CardContext context)
        {
            if (!context.Cards.Any())
            {
                context.Cards.AddRange(
                    new Card
                    {
                        Term = "термин 1",
                        Definition = "определение 1"
                    },
                    new Card
                    {
                        Term = "термин 2",
                        Definition = "определение 2"
                    });

                context.SaveChanges();
            }
        }
    }
}
