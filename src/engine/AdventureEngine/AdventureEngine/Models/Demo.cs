using AdventureEngine.Models.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine.Models
{
    public static class Demo
    {
        private static List<IEnumerable> _demoItems;
        //TODO: Добавить синглтон для каждого репозитория, создавать его не здесть сделать инстанс метод,
        private static readonly PlayerRepository playerRepository = new PlayerRepository();
        private static readonly CharacterRepository characterRepository = new CharacterRepository();
        private static readonly ModelRepository modelRepository = new ModelRepository();
        public static List<IEnumerable> DemoItems
        {
            get => _demoItems = new List<IEnumerable>
            {
                playerRepository.GetAll(),
                characterRepository.GetAll(),
                modelRepository.GetAll()
            };
        }
    }
}
