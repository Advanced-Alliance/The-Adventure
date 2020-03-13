using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public abstract class BaseParam : IPoint
    {
        private double _x;
        private double _y;
        private double _z;
        private int _id;
        private string _name;
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }
        
    }
}
