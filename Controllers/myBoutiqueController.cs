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
        private readonly MyboutiqueImp _repository = new MyboutiqueImp();
        [HttpGet]
        public ActionResult<IEnumerable<Myboutiques>> GetBoutiqueItems()
        {
            var boutiqItems = _repository.GetBoutiqueItems();
            return Ok(boutiqItems);

        }

        [HttpGet("{id}")]
        public ActionResult<Myboutiques> GetShopItemById(int id)
        {
            var boutiqueItem = _repository.GetShopItemById(id);
            return Ok(boutiqueItem);

        }

    }

}