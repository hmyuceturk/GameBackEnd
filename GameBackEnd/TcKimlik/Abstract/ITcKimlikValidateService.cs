using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.TcKimlik.Abstract
{
    interface ITcKimlikValidateService
    {
        bool Validate(Player player);
    }
}
