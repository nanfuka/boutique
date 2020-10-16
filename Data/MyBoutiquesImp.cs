using Myboutique.Data;
using Myboutique.Models;
using System.Collections.Generic;


namespace Myboutique.Data
{
    public class MyboutiqueImp : Imyboutique
    {
        public IEnumerable<Myboutiques> GetBoutiqueItems()
        {
            var boutiqueItems = new List<Myboutiques>
            {
            new Myboutiques{id = 0, type = "legging", description = "blue cotton", cost = 2100},
            new Myboutiques{id = 1, type = "top", description = "red shiffon", cost = 25000},
            new Myboutiques{id = 2, type = "two piece", description = "stretcher", cost = 40000},
            new Myboutiques{id = 3, type = "jumpsuit", description = "body hug", cost = 40000},
            };
            return boutiqueItems;

        }
        public Myboutiques GetShopItemById(int id)
        {
            return new Myboutiques { id = 0, type = "legging", description = "blue cotton", cost = 2100 };
        }

    }
}