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
    [Route("players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        public IPlayerRepository Items { get; set; }

        public PlayersController(IPlayerRepository items)
        {
            Items = items;
        }

        //Player Remove(int key);
        //void Update(Player item);

        [Route("getbyid")]
        public IActionResult GetById(int id) {
            var item = Items.Find(id);
            if (item == null) {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [Route("getall")]
        public IEnumerable<Player> GetAll()
        {
            return Items.GetAll();
        }

        [Route("add")]
        public IActionResult Add(Player player) {
            Items.Add(player);
            return new ObjectResult($"Create new Player: {player.Name}");
        }
        [Route("remove")]
        public IActionResult Remove(int id) {
            var nameRemovePlayer = Items.Find(id).Name;

            Items.Remove(id);
            return new ObjectResult($"Remove Player: {nameRemovePlayer}");
        }
        [Route("update")]
        public IActionResult Update(Player player) {
            Items.Update(player);
            return new ObjectResult($"Status Player: {player.Name} Update");
        }
    }
}
