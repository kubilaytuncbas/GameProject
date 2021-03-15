using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public class PlayerManager :  IPlayersManager
    {
        private IMernisServiceAdapter _mernisServiceAdapter;
        public PlayerManager(IMernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }
        
        public void Add(Players players)
        {
            Console.WriteLine("{0} isimli oyuncu eklenmiştir", players.Ad);


        }
        public void Delete(Players players)
        {
            Console.WriteLine("{0} isimli oyuncu silinmiştir", players.Ad);

        }
        public void Uptade(Players players)
        {
            Console.WriteLine("{0} isimli oyuncunun bilgileri güncellenmiştir", players.Ad);

        }



    }
}

