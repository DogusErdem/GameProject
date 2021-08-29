using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Absrtact;
using GameProject.Entities;

namespace GameProject.Concerte
{
    public class GamerManager : IGamerService
    {
        IGamerCheck _gamerCheck;
        public GamerManager(IGamerCheck gamerCheck)
        {
            _gamerCheck = gamerCheck;
        }   
        public void Add(Gamer gamer)
        {
            if (_gamerCheck.Check(gamer) == true)
            {
                Console.WriteLine("Oyuncu sisteme eklendi :" + gamer.FirstName + " " + gamer.LastName);
            }
            else
                Console.WriteLine("Başarısız Kayıt");
            
        } 

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistemden silindi :" + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi :" + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
