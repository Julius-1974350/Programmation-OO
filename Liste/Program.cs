using System;
using System.Collections.Generic; // Pour la classe liste 
using System.Text;

namespace Liste
{
    class Personne
    {
        public Personne(string nom)
        {
            Nom = nom;
        }
        public string Nom { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //TestListe();
            //TestAleatoire();
            //TestDate();
            //TestPersonne();
            //TestFile();
            TestPile();
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
        static void TestPile()
        {
            // Une pile est une structure dans lequelle il n'est possible d'ajouter et de retirer des éléments qu'au début
            // Par exemple, une pile l'assiette

            Stack<string> cartes = new Stack<string>();
            // Push ajoute un élément sur le dessus de la pile
            cartes.Push("Deux de ♦");
            cartes.Push("Dix de ♣");
            cartes.Push("As de ♥");
            cartes.Push("Cinq de ♠");
            // Pop enlève la carte sur le dessus de la pile
            string uneCarte = cartes.Pop();
            Console.WriteLine("Carte prise sur le dessus du paquet: " + uneCarte);
            uneCarte = cartes.Pop();
            Console.WriteLine("Carte prise sur le dessus du paquet: " + uneCarte);
            cartes.Push("Dame de ♠");
            uneCarte = cartes.Pop();
            Console.WriteLine("Carte prise sur le dessus du paquet: " + uneCarte);
            // Dernier arriver, premier servi (LIFO = Last In, First Out)
        }
        static void TestFile()
        {
            // Une file est une structure dans laquelle il n'est possible d'ajouter des éléments qu'à la fin, et de les retirer qu'au début
            // Par exemple: une file d'attente
            Queue<string> clients = new Queue<string>();
            // Enqueue (Enfiler) ajouter à la fin de la file (pareil au Add de la list)
            clients.Enqueue("Arthur");
            clients.Enqueue("Béatrice");
            clients.Enqueue("Clovis");
            AfficherFile(clients);
            // Dequeue (Défile) enlève l'élément au début de la file
            string unClient = clients.Dequeue();
            Console.WriteLine("Prochain client: " + unClient);
            // On utilise la file lorsqu'on doit conserver l'oredre des éléments tel qu'ils sont ajoutés
            // Premier arrivé, premier servi (FIFO = First In, First Out)
        }
        static void AfficherFile(Queue<string> file)
        {
            Console.WriteLine("taille de la file: " + file.Count);
            foreach (var client in file)
            {
                Console.WriteLine(client);
            }
        }
        static void TestPersonne()
        {
            List<Personne> listePersonnes = new List<Personne>();
            listePersonnes.Add(new Personne("Aristide"));
            listePersonnes.Add(new Personne("Bernadette"));
            listePersonnes.Add(new Personne("Clothilde"));
            Personne donatien = new Personne("Donatin"); // Faute d'ortographe
            // On ajoute un référence à la variable dans la liste
            listePersonnes.Add(donatien);
            foreach (var personne in listePersonnes)
            {
                Console.WriteLine(personne.Nom);
            }
            // modification de la variable donatien
            donatien.Nom = "Donatien";
            // La référence contenue dans la liste va réfléter aussi la modification
            foreach (var personne in listePersonnes)
            {
                Console.WriteLine(personne.Nom);
            }
            // On va retrouver Donatien car on utilise la même variable et ce sont les références sur l'objet qui sont comparées
            if (listePersonnes.Contains(donatien))
            {
                Console.WriteLine("La liste contient donatien");
            }
            else
            {
                Console.WriteLine("La liste NE contient PAS donatien");
            }
            // On NE va PAS retrouver Aristide car on utilise une variable différente, et donc les références sur les objets comparées sont différentes
            if (listePersonnes.Contains(new Personne("Aristide")))
            {
                Console.WriteLine("La liste contient Aristide");
            }
            else
            {
                Console.WriteLine("La liste NE contient PAS Aristide");
            }
            try
            {
                listePersonnes.Sort();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        static void TestDate()
        {
            List<DateTime> listeDates = new List<DateTime>();
            listeDates.Add(new DateTime(1995, 4, 30));
            listeDates.Add(new DateTime(1977, 10, 3));
            listeDates.Add(new DateTime(2002, 3, 1));
            listeDates.Add(new DateTime(1983, 1, 13));
            listeDates.Sort();
            foreach (var Date in listeDates)
            {
                // Différentes méthodes existent pour afficher la date de façon différente
                Console.WriteLine(Date.ToShortDateString());
            }
            // La propriété statique Now de la classe DateTime retourne une variable de type DateTime initialisée à la date et l'heure actuelle de l'ordinateur
            DateTime maintenant = DateTime.Now;
            Console.WriteLine(maintenant.ToLongDateString());
            Console.WriteLine(maintenant.ToLongTimeString());
        }
        static void TestAleatoire()
        {
            // Déclare une variable qui va permettre de générer des nombres aléatoires
            // Il est possible de spécifier une valeur d'initialisation dans le constructeur: Random(123);
            // Le constructeur par défaut initialise le générateur avec l'horloge
            Random generateurAleatoire = new Random();
            List<int> listeEntiers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                // Next va retourner un entier positif au hasard
                listeEntiers.Add(generateurAleatoire.Next());
            }
            for (int i = 0; i < 5; i++)
            {
                // Next va retourner un entier au hasard entre 0 et 99
                listeEntiers.Add(generateurAleatoire.Next(100));
            }
            for (int i = 0; i < 5; i++)
            {
                // Next va retourner un entier au hasard entre 1000 et 9999
                listeEntiers.Add(generateurAleatoire.Next(1000, 10000));
            }
            foreach (var entier in listeEntiers)
            {
                Console.WriteLine(entier);
            }
        }
        static void TestListe()
        {
            List<string> liste = new List<string>();
            // La méthode add ajoute à la fin de la liste (push_back)
            liste.Add("Un");
            liste.Add("Trois");
            liste.Add("Quatre");
            liste.Add("Trois");
            liste.Add("Quatre");
            AfficherListe(liste);
            Console.WriteLine("Insertion de Deux à la position 1");
            liste.Insert(1, "Deux");// Comme le reste en programmation, la position de la liste commence à 0, 1 est la 2e position
            AfficherListe(liste);
            Console.WriteLine("Insertion de Zéro au début de la liste");
            liste.Insert(0, "Zéro"); // Insérer à la position 0 insère au début de la liste
            AfficherListe(liste);
            Console.WriteLine("Première position de Trois: " + liste.IndexOf("Trois"));
            Console.WriteLine("Prochain position de Trois après la position 4: " + liste.IndexOf("Trois", 4));
            Console.WriteLine("Drenière position de Trois: " + liste.LastIndexOf("Trois"));
            Console.WriteLine("Position de Cinq: " + liste.IndexOf("Cinq")); // Un élément non trouvé retourne la valeur -1
            if (liste.Contains("Trois"))
            {
                Console.WriteLine("La liste contient Trois");
            }
            else
            {
                Console.WriteLine("La liste ne contient PAS Trois");
            }
            if (liste.Contains("Cinq"))
            {
                Console.WriteLine("La liste contient Cinq");
            }
            else
            {
                Console.WriteLine("La liste ne contient PAS Cinq");
            }
            Console.WriteLine("Enlève la première ossurence de Quatre");
            liste.Remove("Quatre");
            AfficherListe(liste);
            Console.WriteLine("élément à la position 4: " + liste[4]);
            Console.WriteLine("Enlève l'élément à la position 4");
            liste.RemoveAt(4);
            AfficherListe(liste);
            Console.WriteLine("Met Cinq à la position 0");
            liste[0] = "Cinq";
            AfficherListe(liste);
            Console.WriteLine("Inverse la liste");
            liste.Reverse();
            AfficherListe(liste);
            Console.WriteLine("Tri de la liste");
            liste.Sort();
            AfficherListe(liste);
            Console.WriteLine("Vide la liste");
            liste.Clear();
            AfficherListe(liste);
        }
        static void AfficherListe(List<string> liste)
        {
            Console.WriteLine("-------------------------------------");
            // La propriété Count de la liste indique le nombre d'éléments contenus dans la liste
            Console.WriteLine("Taille de la liste: {0}, contenu: ", liste.Count);
            foreach (string s in liste)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
