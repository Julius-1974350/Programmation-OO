using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOO
{
    /// <summary>
    /// Représentation de l'heure du jour
    /// </summary>
    /// <param name="heures">Les heures de l'horloge</param>>
    class Horloge
    {
        public Horloge(int heures)
        {
            if (heures >= 0 && 23 <= 23)
            {
             _secondes = heures * 3600;
            }
            
        }
        public Horloge(int heures, int minutes)
        {
            if (heures >= 0 && heures <= 59)
            {
                _secondes = heures * 3600;
            }

            if (minutes >= 0 && minutes <= 59)
            {
                _secondes += minutes * 60;
            }
        }
            /// <summary>
            ///  Constructeur pour initialiser avec un nombre d'heures, de minutes et de seconde
            /// </summary>
            /// <param name="heures">Les heures de l'horloge</param>
            /// <param name="minutes">Les minutes de l'horloge</param>
            /// <param name="secondes">Les minutes de l'horloge</param>
            public Horloge(int heures, int minutes, int secondes)
        {
            if (heures >= 0 && heures <=59)
            {
                _secondes = heures * 3600;
            }

            if (minutes >= 0 && minutes <= 59)
            {
                _secondes += minutes * 60;
            }

            if (secondes >= 0 && secondes <= 59)
            {
                _secondes += secondes;
            }
        }
        //Propriétés pour récupérer les valeurs distinctes de l'horloge
        public int heures
        {
            get { return _secondes / 3600;  }
            //On ne définit pas le set
        }

        public int minutes
        {
            get { return _secondes % 3600 / 60; }
        }

        public int secondes
        {
            get { return _secondes % 60; }
        }

        /// <summary>
        /// Affiche la valeur de l'horloge dans le format HH:MM:SS
        /// </summary>


        public void Afficher()
        {
            Console.WriteLine("{0:D2}:{1:D2},{2:D2}", heures, minutes, secondes);
        }

        /// <summary>
        /// Affiche la valeur de l'horloge dans le format HH:MM::SS
        /// </summary>

        public bool EstEgaleA(Horloge autreHorloge)
        {
            //Le niveau de protection (private) est au niveau de la classe, et non pas de l'objet
            //Il est possible d'accéder aux attributs privés d'un autre objet de la même classe

            //Compare les secondes de l'objet courant avec les secondes de l'autre objet
            return _secondes == autreHorloge._secondes;
        }


        private int _secondes = 0;
    }
}
