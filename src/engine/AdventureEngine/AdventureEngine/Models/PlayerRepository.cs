using AdventureEngine.Models.Interface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<Player> _players =
              new List<Player>();

        public PlayerRepository()
        {
            _players.Add(new Player
            {
                Id = 0,
                Name = $"Name: {0}",
                X = 16,
                Y = 16,
                Z = 0,
                Style = "Style"
            });
            for (int i = 1; i < 10; i++)
            {
                _players.Add(new Player
                {
                    Id = i,
                    Name = $"Name: {i}",
                    X = 10,
                    Y = 10,
                    Z = 0,
                    Style = "Style"
                });
            }
        }

        public void Add(Player item)
        {
            _players.Add(item);
        }

        public Player Find(int id)
        {
            return _players.Find(x => x.Id == id);
        }

        public IEnumerable<Player> GetAll()
        {
            return _players;
        }

        public void Remove(int id)
        {
            var index = GetIndex(id);
            _players.RemoveAt(index);
        }

        public void Update(Player item)
        {
            var index = GetIndex(item.Id);
            _players[index] = item;
        }

        public int GetIndex(int id) {
            return _players.IndexOf(_players.Find(x => x.Id == id));
        }
    }
}
