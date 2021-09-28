using GameBackEnd.Entities;
using GameBackEnd.TcKimlik.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.TcKimlik.Concrete
{
    class TcKimlikValidateManager : ITcKimlikValidateService
    {
        public bool Validate(Player player)
        {
            if (player.Name == "Mehmet")
                return true;
            else
                return false;
        }
    }
}
