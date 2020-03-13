using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models.Interface
{
    public interface IRepository
    {
        ICharacterRepository characterRepository { get; }
        IMoldelRepository moldelRepository { get; }
        IPlayerRepository playerRepository { get; }
    }
}
