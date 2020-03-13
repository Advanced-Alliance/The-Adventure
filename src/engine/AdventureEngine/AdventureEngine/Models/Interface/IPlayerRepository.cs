using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models.Interface
{
   public interface IPlayerRepository
    {
        IEnumerable<Player> GetAll();
        void Update(Player item);
    }
}
