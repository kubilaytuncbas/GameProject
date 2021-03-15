using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Players players1 = new Players { Ad = "kubilay", SoyAd = "tuncbas", Tcno = "29740812454", DoğumYılı = new DateTime(1998, 2, 19) };
            Game game1 = new Game { GameName = "League Of Legends", GamePrice = 50 };
            Campaign campaign1 = new Campaign { Ad = "Yılbaşı indirimi", IndirimOrani = 0.15 };
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(players1);
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            CampignManager campignManager = new CampignManager();
            campignManager.Add(campaign1);
            SaleManager saleManager = new SaleManager();
            saleManager.Satis(players1, campaign1, game1);




        }
    }
}
