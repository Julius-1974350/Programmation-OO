using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Vehicule
    {

    }
    class VehiculeRoutier : Vehicule
    {

    }
    // Un parent peut avoir plusieurs enfants
    class VehiculeAMoteur : Vehicule
    {

    }
    // Il n'y a pas de limite sur le niveau d'héritage
    // Une classe peut hériter d'une classe, qui hérite d'une classe, qui hérite d'une classe, etc.
    // Une clase ne peut hériter que d'une seule classe de base
    class Voiture : VehiculeRoutier//, VehiculeAMoteur
    {

    }
}
