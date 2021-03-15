using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampignManager
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Uptade(Campaign campaign);
    }
}
