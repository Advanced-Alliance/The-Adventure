﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public class Character : BaseParam
    {
        private string _style;
        public string Style { get => _style; set => _style = value; }
        public Character() { }
      
    }
}
