using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;
        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu Sisteme Kaydoldu...");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız...");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi.");
        }
    }
}
