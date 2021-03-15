using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IPlayersManager
    {
        void Add(Players players);
        void Delete(Players players);
        void Uptade(Players players);
    }
}
