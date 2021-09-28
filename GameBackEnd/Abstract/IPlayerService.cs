using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Abstract
{
    interface IPlayerService
    {
        bool Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
