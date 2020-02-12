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
    /// <param name="heures">Les heures de l'HorlogeV2</param>>
    class HorlogeV2
    {
        /*
                public HorlogeV2(int heures)
                {
                    Console.WriteLine("Constructeur de l'HorlogeV2 avec des heures");
                    if (heures >= 0 && 23 <= 23)
                    {
                        _secondes = heures * 3600;
                    }
            
                }
        
                public HorlogeV2(int heures, int minutes)
                {
                    if (heures >= 0 && heures <= 59)
                    {
                         _secondes = heures * 3600;
                    }
                    Console.WriteLine("Constructeur de l'HorlogeV2 avec des heures et des minutes");
                    if (minutes >= 0 && minutes <= 59)
                    {
                        _secondes += minutes * 60;
                    }
                }
        */
        /// <summary>
        ///  Constructeur pour initialiser avec un nombre d'heures, de minutes et de seconde
        /// </summary>
        /// <param name="heures">Les heures de l'HorlogeV2</param>
        /// <param name="minutes">Les minutes de l'HorlogeV2</param>
        /// <param name="secondes">Les minutes de l'HorlogeV2</param>

        // Il est possible dans la définition d'une méthode (constructeur autre) de spécifier des valeurs par défaut
        // pour le ou les derniers paramètres
        // Si une valeur est donné lors de l'appel, elle est utilisée. sinon, la valeur par défaut est utilisée.
        // (int heures, int minutes = 0, int secondes ) est invalide car le dernier paramètre n'a pas de valeur par défaut 
        public HorlogeV2(int heures = 0, int minutes = 0, int secondes = 0) 
        {
            Console.WriteLine("Constructeur de l'HorlogeV2 avec des heures et des minutes et des secondes");
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
        //Propriétés pour récupérer les valeurs distinctes de l'HorlogeV2
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
        /// Affiche la valeur de l'HorlogeV2 dans le format HH:MM:SS
        /// </summary>


        public void Afficher()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", heures, minutes, secondes);
        }

        /// <summary>
        /// Affiche la valeur de l'HorlogeV2 dans le format HH:MM::SS
        /// </summary>
        /// Permet de savoir si les deux HorlogeV2s sont égales, false sinon
        public bool EstEgaleA(HorlogeV2 autreHorlogeV2)
        {
            //Le niveau de protection (private) est au niveau de la classe, et non pas de l'objet
            //Il est possible d'accéder aux attributs privés d'un autre objet de la même classe

            //Compare les secondes de l'objet courant avec les secondes de l'autre objet
            return _secondes == autreHorlogeV2._secondes;
            // Cette ligne est équivalent à la précédente
            // "this" est un mot clé désignant une variables qui représente l'objet courrant
            // Si la méthode est appellée par: h2.EstEagleA(...), "this" représente h2
            //return this._secondes == autreHorlogeV2._secondes;
        }


        private int _secondes = 0;
    }
}
