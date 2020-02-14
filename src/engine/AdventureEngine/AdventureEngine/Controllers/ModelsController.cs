using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureEngine.Models;
using AdventureEngine.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureEngine.Controllers
{
    [Route("models")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        public IMoldelRepository Items { get; set; }

        public ModelsController(IMoldelRepository items)
        {
            Items = items;
        }

        [Route("getbyid")]
        public IActionResult GetById(int id)
        {
            var item = Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [Route("getall")]
        public IEnumerable<OModel> GetAll()
        {
            return Items.GetAll();
        }

        [Route("add")]
        public IActionResult Add(OModel player)
        {
            Items.Add(player);
            return new ObjectResult($"Create new Model: {player.Name}");
        }

        [Route("remove")]
        public IActionResult Remove(int id)
        {
            var nameRemovePlayer = Items.Find(id).Name;

            Items.Remove(id);
            return new ObjectResult($"Remove Model: {nameRemovePlayer}");
        }

        [Route("update")]
        public IActionResult Update(OModel player)
        {
            Items.Update(player);
            return new ObjectResult($"Status Model: {player.Name} Update");
        }
    }
}
