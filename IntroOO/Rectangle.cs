using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOO
{
    /// <summary>
    /// Représentation d'une forme géométrique de type rectangle  
    /// </summary>
    class Rectangle
    {
        // Par défaut le contenu d'une classe est privé, c'est-à-dire qu'il est impossible d'y accéder de l'éxtérieur de la classe
        // Le mots clé "public" sert à indiquer que ce qui suit peut être accédé de l'extérieur de la classe

        // Toutes les définitions publiques seront mises en premier dans la classe, car elles intéressent utilisateurs
        // Tout ce qui est privé est mis à la fin, car ça n'interesse que le concepteur de la classe

        // Un constructeur est une méthode spéciale qui est appellée automatiquement lors de la création d'un objet
        // Un constructeur n'a pas de type de retour 
        // Un constructeur porte exactement le même nom que la classe
        public Rectangle(int hauteur, int largeur)
        {
            //_hauteur = hauteur;
            //_largeur = largeur;

            // Afin de profiter des validations existantes
            SetHauteur(hauteur);
            Largeur = largeur;
            Console.WriteLine("Constructeur avec hauteur de " + hauteur + " et largeur de " + largeur);
        }

        // Pour respecter le principe d'encapsulation des données, aucun attribut ne sera public, il faut donc fournir des méthodes
        // une méthode pour aller chercher la valeur d'un attribut se nomme un "accesseur" (getter)
        public int Hauteur()
        {
            return _hauteur;
        }

        // Une méthode qui permet de modifier un attribut se nomme un "mutateur" (setter)
        public void SetHauteur(int value)
        {
            //un mutateur va permettre de valider les valeurs données avant de les assigner aux attributs
            // la hauteur ne peut pas être négative, ni nulle 
            if (value > 0)
            {
                _hauteur = value;
            } 
        }

        // Une propriété est à mi-chemin entre un attribut et une méthode 
        // S'utilise comme un attribut, se comporte comme une méthode
        // Pas de () pour une propriété
        public int Largeur
        {
            // Dans le bloc d'une propriété, il est possible de définir 2 simili-méthodes

            // Acceseur
            get { return _largeur; }
            // Mutateur
            set //(int value)
            {
                // dans la partie set d'une propriété, une variable nommé "value" existe implicitement pour contenir la valeur assignée
                if (value > 0)
                {
                    _largeur = value;
                }
            }
        }
        // Propriété automatique
        // une valeur interne est utilisée implicitement, sans qu'on doive définir un attribut_nom
        // Le get retourne simplement cette valeur, le set l'assigne sans validation
        //Il est possible d'assigner une valeur par défaut à la propriété
        // !!! À utiliser avec modération!, n'est qu'une très lègère couche au dessus d'un attribut afin que celui-ci reste privé
        public string Nom { get; set; } = "Rectangle";

        // Une méthode qui retourne l'aire du rectangle 
        public int Aire() { return _largeur * _hauteur; }

        // Propriété pour récupérer l'aire du rectangle
        // Propriété en lecture seule
        public int Surface
        {
            get { return _largeur * _hauteur; }
            // On ne définit pas la méthode set
        }

        // Propriété automatique, en lecture seule de l'extérieur, mais modifiable dans la classe
        public int Couleur { get; private set; } = 15;

        /// <summary>
        /// Dessine le rectangle à l'écran avec le symbole donné
        /// </summary>
        /// <param name="symbole"></param>
        public void Afficher(char symbole)
        {
            // comme la méthode fait parti de la classe, elle a accès à tout ce qui est privé: _hauteur, _largeur 
            for (int ligne = 0; ligne < _hauteur; ligne++)
            {
                for (int colonne = 0; colonne < _largeur; colonne++)
                {
                    Console.Write(symbole);
                }
                Console.WriteLine();
            }
        }
        // Il est possible d'avoir plusieurs méthodes qui portent le même nom, tant que le compilateur est capable
        // de faire la différence en se basant sur les paramètres (type et nombre)
        /// <summary>
        /// Dessine le rectangle avec des *
        /// </summary>
        public void Afficher()
        {
            // Appelle la version qui prend un paramètre de type char††▓
            Afficher('▓');
        }
    
        // Une variable définie dans une classe se nome un attribut
        // Il n'y aura JAMAIS d'attribut public dans une classe
        // Même si par défaut l'accès est privé, nous allons explicitement le mentionner pour éviter la confusion
        // Le mot clé "private" indique explicitement ce qui suit est privé à la classe
        private int _hauteur = 0;
        private int _largeur = 0;

    }
}
