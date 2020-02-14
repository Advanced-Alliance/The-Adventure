using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public class OModel : BaseParam
    {
        private string _type;
        public string Type { get => _type; set => _type = value; }
        public OModel() { }
    }
}
