using GameBackEnd.Abstract;
using GameBackEnd.Entities;
using GameBackEnd.TcKimlik.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concrete
{
    class PlayerManager : IPlayerService
    {
        ITcKimlikValidateService _tcKimlikValidateService;
        public PlayerManager(ITcKimlikValidateService tcKimlikValidateService)
        {
            _tcKimlikValidateService = tcKimlikValidateService;
        }
        public bool Add(Player player)
        {
            if (_tcKimlikValidateService.Validate(player))
            {
                Console.WriteLine("Invoice eklendi : " + player.Name);
                return true;
            }
            else
            {
                Console.WriteLine("Invoice eklenemedi, Kimlik doğrulaması geçersiz : " + player.Name);
                return false;
            }

        }
        public void Update(Player player)
        {
            Console.WriteLine("Invoice güncellendi : " + player.Name);
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Invoice silindi : " + player.Name);
        }
    }
}
