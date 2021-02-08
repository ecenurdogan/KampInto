using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject
{
    interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
