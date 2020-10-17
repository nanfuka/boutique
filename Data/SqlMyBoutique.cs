using System.Collections.Generic;
using Myboutique.Models;
using System.Linq;

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
            return _context.mayBoutique.ToList();
        }

        Myboutiques Imyboutique.GetShopItemById(int id)
        {
            return _context.mayBoutique.FirstOrDefault(p => p.id == id);
        }
    }
}