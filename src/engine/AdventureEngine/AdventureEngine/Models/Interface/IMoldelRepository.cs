using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models.Interface
{
    public interface IMoldelRepository
    {
        IEnumerable<OModel> GetAll();
        void Update(OModel item);
    }
}
