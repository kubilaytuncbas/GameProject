using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager
    {
       public void Satis(Players players,Campaign campaign,Game game)
        {
            double IndirimliFiyat = 0;
            IndirimliFiyat = game.GamePrice-(campaign.IndirimOrani * game.GamePrice);
            Console.WriteLine(" {0} TL ye satış işlemi tamamlanmıştır",IndirimliFiyat);
        }
    }
}
