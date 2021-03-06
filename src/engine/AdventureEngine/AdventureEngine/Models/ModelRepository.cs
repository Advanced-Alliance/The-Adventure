﻿using AdventureEngine.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public class ModelRepository: IMoldelRepository
    {
        private List<OModel> _models =
              new List<OModel>();

        public ModelRepository()
        {
            _models.Add(new OModel
            {
                Id = 0,
                Name = $"OModel: {0}",
                X = 16,
                Y = 16,
                Z = 0,
                Type = "Type"
            });
            for (int i = 1; i < 3; i++)
            {
                _models.Add(new OModel
                {
                    Id = i,
                    Name = $"OModel: {i}",
                    X = 10,
                    Y = 10,
                    Z = 0,
                    Type = "Type"
                });
            }
        }
        public IEnumerable<OModel> GetAll()
        {
            return _models;
        }

        public void Update(OModel item)
        {
            var index = GetIndex(item.Id);
            _models[index] = item;
        }

        public int GetIndex(int id)
        {
            return _models.IndexOf(_models.Find(x => x.Id == id));
        }
    }
}
