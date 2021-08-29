using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concerte
{
    
    public class GameManager : IGameService
    {
        
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi :" +game.GameName +" Ücret ->"+ game.GamePrice+ "₺");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.GameName);
        }

        public static implicit operator GameManager(GamerManager v)
        {
            throw new NotImplementedException();
        }
    }
}
