using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} isimli oyun eklendi",game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} isimli oyun silindi",game.GameName);

        }

        public void Uptade(Game game)
        {
            Console.WriteLine("{0} isimli güncellendi",game.GameName);

        }
    }
}
