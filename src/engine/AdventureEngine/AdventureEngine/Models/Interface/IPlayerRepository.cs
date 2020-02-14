using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models.Interface
{
   public interface IPlayerRepository
    {
        void Add(Player item);
        IEnumerable<Player> GetAll();
        Player Find(int key);
        void Remove(int key);
        void Update(Player item);
    }
}
