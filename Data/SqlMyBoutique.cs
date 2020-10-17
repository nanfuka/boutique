using System.Collections.Generic;
using Myboutique.Models;

namespace Myboutique.Data
{

    public class SqlMyBoutique : Imyboutique
    {
        private readonly MyBoutiqueContext _context;

        public SqlMyBoutique(MyBoutiqueContext context)
        {
            _context = context;
        }

        IEnumerable<Myboutiques> Imyboutique.GetBoutiqueItems()
        {
            throw new System.NotImplementedException();
        }

        Myboutiques Imyboutique.GetShopItemById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}