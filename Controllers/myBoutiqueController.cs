using System.Collections.Generic;
using Myboutique.Models;
using Microsoft.AspNetCore.Mvc;
using Myboutique.Data;
namespace Myboutique.Cotrollers
{

    [Route("api/items")]
    [ApiController]
    public class MyboutiqueController : ControllerBase
    {
        private readonly Imyboutique _repositorys;
        public MyboutiqueController(Imyboutique repository)
        {
            _repositorys = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Myboutiques>> GetBoutiqueItems()
        {
            var boutiqItems = _repositorys.GetBoutiqueItems();
            return Ok(boutiqItems);

        }

        [HttpGet("{id}")]
        public ActionResult<Myboutiques> GetShopItemById(int id)
        {
            var boutiqueItem = _repositorys.GetShopItemById(id);
            return Ok(boutiqueItem);

        }

    }

}