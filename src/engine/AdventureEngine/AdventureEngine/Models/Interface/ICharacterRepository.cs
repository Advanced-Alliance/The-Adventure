using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models.Interface
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> GetAll();
        void Update(Character item);
    }
}
