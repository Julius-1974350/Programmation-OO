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
            Console.WriteLine("Constructeur de l'horloge avec des heures");
            if (heures >= 0 && 23 <= 23)
            {
             _secondes = heures * 3600;
            }
            
        }
        // Les 2 points : à la fin du constructeur permettent de spécifier un autre constructeur (de la même classe)
        // pour réutiliser du code existant qu'on ne veut pas copié
        // L'appel du constructeur ne se fait pas avec le nom de la classe, mais avec le mot clé "this"
        public Horloge(int heures, int minutes) : 
         this(heures) // appel du constructeur de l'objet courant, avec un seul paramètre
        {
            /*          if (heures >= 0 && heures <= 59)
                        {
                            _secondes = heures * 3600;
                        }
            */
            Console.WriteLine("Constructeur de l'horloge avec des heures et des minutes");
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
        public Horloge(int heures, int minutes, int secondes) :
            this(heures, minutes) // Appel du constructeur avec 2 paramètres
        {
            Console.WriteLine("Constructeur de l'horloge avec des heures et des minutes et des secondes");
/*
            if (heures >= 0 && heures <=59)
            {
                _secondes = heures * 3600;
            }

            if (minutes >= 0 && minutes <= 59)
            {
                _secondes += minutes * 60;
            }
*/
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
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", heures, minutes, secondes);
        }

        /// <summary>
        /// Affiche la valeur de l'horloge dans le format HH:MM::SS
        /// </summary>
        /// Permet de savoir si les deux horloges sont égales, false sinon
        public bool EstEgaleA(Horloge autreHorloge)
        {
            //Le niveau de protection (private) est au niveau de la classe, et non pas de l'objet
            //Il est possible d'accéder aux attributs privés d'un autre objet de la même classe

            //Compare les secondes de l'objet courant avec les secondes de l'autre objet
            return _secondes == autreHorloge._secondes;

            // Cette ligne est équivalent à la précédente
            // "this" est un mot clé désignant une variables qui représente l'objet courrant
            // Si la méthode est appellée par: h2.EstEagleA(...), "this" représente h2
            //return this._secondes == autreHorloge._secondes;

            // autreHorloge est une référence
            // Il faut être prudent de ne pas faire de modifications
            // autreHorologe._secondes = 123;
        }


        private int _secondes = 0;
    }
}
