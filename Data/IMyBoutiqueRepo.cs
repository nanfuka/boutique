using System.Collections.Generic;
using Myboutique.Models;
namespace Myboutique.Data
{

    public interface Imyboutique
    {
        IEnumerable<Myboutiques> GetBoutiqueItems();
        Myboutiques GetShopItemById(int id);
    }

}