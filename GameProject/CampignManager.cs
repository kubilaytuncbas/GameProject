using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampignManager : ICampignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(" {0}kampanya olarak eklendi",campaign.Ad);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(" {0}kampanya olarak silindi",campaign.Ad);
        }

        public void Uptade(Campaign campaign)
        {
            Console.WriteLine("{0} bilgileri güncellendi",campaign.Ad);
        }
    }
}
