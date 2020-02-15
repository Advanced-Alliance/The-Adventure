using AdventureEngine.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public class CharacterRepository : ICharacterRepository
    {
        private List<Character> _characters =
              new List<Character>();

        public Character character { get; }
        public CharacterRepository()
        {
            _characters.Add(new Character
            {
                Id = 0,
                Name = $"Character: {0}",
                X = 16,
                Y = 16,
                Z = 0,
                Style = "Style"
            });
            for (int i = 1; i < 3; i++)
            {
                _characters.Add(new Character
                {
                    Id = i,
                    Name = $"Character: {i}",
                    X = 10,
                    Y = 10,
                    Z = 0,
                    Style = "Style"
                });
            }
        }
        public IEnumerable<Character> GetAll()
        {
            return _characters;
        }

        public void Update(Character item)
        {
            var index = GetIndex(item.Id);
            _characters[index] = item;
        }
        public int GetIndex(int id)
        {
            return _characters.IndexOf(_characters.Find(x => x.Id == id));
        }
    }
}
