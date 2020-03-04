using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 12, 34, 56, 78, 90 };

            //Un bloc d'exécution qui débute par le mot clé "try" va permettre de gérer les erreurs possibles dans l'exécution de ce bloc
            try
            {
                Console.WriteLine("Entrez un index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Index {0}: ", index);
                Console.WriteLine("Index {0} du tableau: {1}", index, tableau[index]);
                Console.WriteLine("Division: " + tableau[index] / index);

                Console.WriteLine("Fin du bloc try");
            }
            //Un bloc try devra être suivi d'un bloc catch qui sera exécuté si une exeption se produit durant l'exécution du bloc try
            // Le bloc catch ne sera pas exécuté s'il n'y a pas d'erreur 

            //Il faut mettre les exceptions les plus spécialisées en premier, et les plus générales en dernier
            //Si le type d'un bloc catch suivant ne seront jamais exécuté
            //      catch (exception e)
            //      {
            //      }

            //dans les parenthèses qui suivent l'instruction catch, on spécifie le type de l'exception à gérer et une variable de sera attrapée
            //C'est très similaire à un paramètre de méthode
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception de type IndexOutOfRange: " + e.Message);
            }
            //Exception est la classe de base de toutes les exceptions qui peuvent être attrapper
            //Si une exception spécifique n'est pas présente dans une classe  catch, Exception va tout attraper
            catch (Exception exception) //Exception est un type (une classe), exception est une variable
            {
                Console.WriteLine("Exception: " + exception.Message); //Message est une propriété de la classe Execption qui donne de l'information sur l'erreur
            }
            catch //Équivalent <a: catch (exception e), mais sans information sur l'erreur
            {
                Console.WriteLine("Une exception s'est produite !");
            }



            try
            {
                Console.WriteLine("Entrez un index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Index {0}: ", index);
                Console.WriteLine("Index {0} du tableau: {1}", index, tableau[index]);
                Console.WriteLine("Division: " + tableau[index] / index);

                Console.WriteLine("Fin du bloc try");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception de type IndexOutOfRange: " + e.Message);
            }
            //Uniquement les exceptions de type IndexOutOfRange sont attrapées, les autres vont faire planter le programme


            try
            {
                Deamandervaleur();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception de base: " + e.message);
            }

            Console.WriteLine("Suite du programme");


            Console.WriteLine("Appuyer sur une touche pour continuer");
             Console.ReadKey(true);
        }

        static void Deamandervaleur()
        {
            try
            {
                Console.WriteLine("Entrez une valeur entre 1 et 10: ");
                int valeur = Convert.ToInt32(Console.ReadLine());
                Validervaleur(valeur);
                Console.WriteLine("La valeur est la même");
            }
            catch
            {
                Console.WriteLine("Exception de type MonException: " + e.message);
            }

        }
        static void Validervaleur(int valeur)
        {
            try
            {
                if (valeur < 1 || valeur > 10)
                {
                    //throw est le mot clé pour lancer une exception
                    //Faire un throw arrête l'exécution normal du programme jusqu'au prochain bloc catch qui attapera l'exception
                    throw new MonException("Valeur invalide, doit être entre 1 et 10");
                }
                Console.WriteLine("Validation terminé");

            }
            //Un try doit être suivi d'un catch et/ou d'un finally
            finally
            {
                //Les instructions du bloc finally vont être exécutée peu importe s'il y a eu une exception lancée ou non dans le bloc try
                Console.WriteLine("Clause finale");
            }
        }

        //Demande une date à l'utilisateur
        // Valide et affiche la date
        // Redemande à l'utilisateur tant que la date n'est pas valide
        static void TestDate()
        {
            bool estvalide = false;
            while (!estvalide)
            {
            try
            {
                Console.WriteLine("Indiquer une date (A/M/J): ");
                string ligne = Console.ReadLine();
                string[] valeur = ligne.Split('/'); //Tableau de trois string (divise les /)

                //foreach (string s in valeur)
                //{
                // Console.WriteLine("valeur: " + s);
                //}

                DateTime date = new DateTime(valeurs);
                date.Afficher(); //Année/Mois/Jour
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            }
        }
    }


    //Si nous avons besoin d'un type d'exception particulier, nous pouvons simplement définir notre propre classe pour nos besoins
    // Pour pouvoir être utilisée avec les instructions throw et catch, la classe doit absolument hériter de la classe system.Exception

    class MonException : Exception
    {
        public MonException(string message) :
            base(message)
        {
        }
    }


    class Date
    {
        //Valeurs est un tableau de strings: .valeur[0] = annee, valeur[1] = mois, valeurs[2] = jours
        public Date(string[] valeurs)
        {
            // Valider les valeurs
            // Année > 0   if (Année < 0)
            //Mois entre 1 et 12 if (Mois < 1 || Mois > 12)
            //Jour entre 1 et DateTime.DayInMonth(annee,mois)  ->  Calcule et donne le nombre de jour d'un mois
            _annee = Convert.ToInt32(valeurs[0]);
            if (_annee <= 0)
            {
                //Dans un cons5tructeur, la seule et unioque façon d'indiquer une erreur est en lançant une exception
                throw new MonException("L'année doit être plus grande que 0");
            }

            _mois = Convert.ToInt32(valeurs[1]);
            if (_mois < 1 || _mois > 12)
            {
                throw new MonException("Le mois doit être entre 1 et 12");
            }

            _jour = Convert.ToInt32(valeurs[1]);
            if (_jour < 1 || _jour > DateTime.DaysInMonth(_annee, _mois))
            {
                throw new MonException("Le jour doit être entre 1 et " + DateTime.DaysInMonth(_annee, _mois));
            }

            //Pas de try/catch car il n'y a rien à faire ici en cas d'erreur
        }

        public void Afficher()
        {
            Console.WriteLine("{0}/{1}/{2}", _annee, _mois, _jour);
        }

        private int _annee;
        private int _mois;
        private int _jours;
    }



}
/*
  
   1: ☺
   2: ☻
   3: ♥
   4: ♦
   5: ♣
   6: ♠
   7: •
   8: ◘
   9: ○
   10: ◙
   11: ♂
   12: ♀
   13: ♪
   14: ♫
   15: ☼
   17: ◄
   16: ►
   18: ↕
   19: ‼
   20: ¶
   21: §
   22: ▬
   23: ↨
   24: ↑
   25: ↓
   26: →
   27: ←
   28: ∟
   29: ↔
   30: ▲
   31: ▼
   32:         
   33: !
   34: "
   35: #
   36: $
   37: %
   38: &
   39: '
   40: (
   41: )
   42: *
   43: +
   44: ,
   45: -
   46: .
   47: /
   48: 0
   49: 1
   50: 2
   51: 3
   52: 4
   53: 5
   54: 6
   55: 7
   56: 8
   57: 9
   58: :
   59: ;
   60: <
   61: =
   62: >
   63: ?
   64: @
   65: A
   66: B
   67: C
   68: D 
   69: E
   70: F
   71: G
   72: H
   73: I
   74: J
   75: K
   76: L
   77: M
   78: N
   79: O
   80: P
   81: Q
   82: R
   83: S
   84: T
   85: U
   86: V
   87: W
   88: X
   89: Y
   90: Z
   91: [
   92: \
   93: ]
   94: ^
   95: _
   96: `
   97: a
   98: b
   99: c
   100: d
   101: e
   102: f
   103: g
   104: h
   105: i
   106: j
   107: k
   108: l
   109: m 
   110: n
   111: o
   112: p
   113: q
   114: r
   115: s
   116: t
   117: u
   118: v
   119: w
   120: x
   121: y
   122: z
   123: {
   124: |
   125: }
   126: ~
   127: ⌂
   128: Ç
   129: ü
   130: é
   131: â
   132: ä
   133: à
   134: å
   135: ç
   136: ê
   137: ë
   138: è
   139: ï
   140: î
   141: ì
   142: Ä
   143: Å
   144: É
   145: æ
   146: Æ
   147: ô
   148: ÿ
   149: ò
   150: û
   151: ù
   152: ÿ
   153: Ö
   154: Ü
   155: ø
   156: £
   157: Ø
   158: ×
   159: ƒ
   160: á
   161: í
   162: ó
   163: ú
   164: ñ
   165: Ñ
   167: º
   168: ¿
   169: ®
   170: ¬
   171: ½
   172: ¼
   173: ¡
   174: «
   175: »
   176: ░
   177: ▒
   178: ▓
   179: │
   180: ┤
   181: Á
   182: Â
   183: À
   184: ©
   185: ╣
   186: ║
   187: ╗
   188: ╝
   189: ¢
   190: ¥
   191: ┐
   192: └
   193: ┴
   194: ┬
   195: ├
   196: ─
   197: ┼
   198: ã
   199: Ã
   200: ╚
   201: ╔
   202: ╩
   203: ╦
   204: ╠
   205: ═
   206: ╬
   207: ¤
   208: ð
   209: Ð
   210: Ê
   211: Ë
   212: È 
   213: ı
   214: Í
   215: Î
   216: Ï
   217: ┘
   218: ┌
   219: █
   220: ▄
   221: ¦
   222: Ì
   223: ▀
   224: Ó
   225: ß
   226: Ô
   227: Ò
   228: õ
   229: Õ
   230: µ
   231: þ
   232: Þ
   233: Ú
   234: Û
   235: Ù
   236: ý
   237: Ý
   238: ¯
   239: ´
   240: ­­­*******
   241: ±
   242: ‗
   243: ¾
   244: ¶
   245: §
   246: ÷
   247: ¸
   248: °
   249: ¨
   250: ·

   

╬════╬
╬════╬
╬════╬
╬════╬
╬════╬
╬════╬
╬════╬
╬════╬

╔════╗
║════╣
║════╣
║════╣
║════╣
║════╣
║════╣
╚════╝

    ╔╦╦╦╦╦╦╦╦╦╦╦╦╦╦╗
    ╠╬╬╬╬╬╬╬╬╬╬╬╬╬╬╣
    ╚╩╩╩╩╩╩╩╩╩╩╩╩╩╩╝
    */
