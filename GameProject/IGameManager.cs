using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Uptade(Game game);
    }
}
