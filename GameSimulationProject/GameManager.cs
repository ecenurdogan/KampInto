﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Yeni Oyun Eklendi...");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi...");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Bilgileri Güncellendi...");
        }
    }
}
