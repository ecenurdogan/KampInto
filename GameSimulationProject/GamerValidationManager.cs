using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Birthyear==1997 && gamer.FirstName=="ECE NUR" && 
                gamer.LastName=="DOĞAN" && gamer.IdentityNumber==123456 )
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
