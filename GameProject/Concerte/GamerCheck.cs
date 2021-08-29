using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concerte
{
    public class GamerCheck : IGamerCheck
    {
        bool IGamerCheck.Check(Gamer gamer)
        {
            if (gamer.FirstName == "Doğuş" && gamer.LastName == "Erdem" && gamer.NationalityId == "121212" &&
                 gamer.DateOfBirth.Year == 1998)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}