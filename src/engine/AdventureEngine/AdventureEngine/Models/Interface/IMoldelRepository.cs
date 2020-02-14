using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models.Interface
{
    public interface IMoldelRepository
    {
        void Add(OModel item);
        IEnumerable<OModel> GetAll();
        OModel Find(int key);
        void Remove(int key);
        void Update(OModel item);
    }
}
