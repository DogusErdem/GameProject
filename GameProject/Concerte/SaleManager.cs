﻿using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concerte
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+"  "+ game.GameName+"oyununu aldın!");
        }
    }
}
