using myGame;

public class Program
{

    public static void Main()
    {
        // Instanciation des deux joueurs ------------------------------------------------------------------------------
        // Joueur 1
        Console.Write("Joueur 1 choisissez votre nom : ");
        Player player1 = new Player(Console.ReadLine(),50);
        
        // Joueur 2
        Console.Write("Joueur 2 choisissez votre nom : ");
        Player player2 = new Player(Console.ReadLine(),50);
        
        
        
        // Création des attaques ---------------------------------------------------------------------------------------
        Attaque Rasengan = new Attaque("Rasengan", 15);
        Attaque Chidori = new Attaque("Eclair pourfendeur", 15);
        Attaque Katon = new Attaque("Boule de feu", 10);
        Attaque Amaterasu = new Attaque("Lumière céleste", 30);
        
        
        
        // Boucler jusqu'à ce qu'un joueur arrive à 0 Pv ---------------------------------------------------------------
        while (player1.Pv >= 0 && player2.Pv >= 0)
        {
            // Séléction des techniques player1 ----------------------------------------------------------------------------
            Console.WriteLine(player1.Name + ", veuillez séléctionner votre technique :");
            Console.WriteLine("[1] -> Katon || [2] -> Rasengan || [3] -> Amaterasu || [4] -> Chidori");

            string choixJoueur = Console.ReadLine();
        
            if (choixJoueur == "1")
            {
                player1.Attaquer(player2, Katon);
            }
            else if (choixJoueur == "2")
            {
                player1.Attaquer(player2, Rasengan);
            }
            else if (choixJoueur == "3")
            {
                player1.Attaquer(player2, Amaterasu);
            }
            else if (choixJoueur == "4")
            {
                player1.Attaquer(player2, Chidori);
            }
            
            
            
            // Séléction des techniques player2 ----------------------------------------------------------------------------
            Console.WriteLine(player2.Name + ", veuillez séléctionner votre technique :");
            Console.WriteLine("[1] -> Katon || [2] -> Rasengan || [3] -> Amaterasu || [4] -> Chidori");

            string choixJoueur2 = Console.ReadLine();
            
            if (choixJoueur2 == "1")
            {
                player2.Attaquer(player1, Katon);
            }
            else if (choixJoueur2 == "2")
            {
                player2.Attaquer(player1, Rasengan);
            }
            else if (choixJoueur2 == "3")
            {
                player2.Attaquer(player1, Amaterasu);
            }
            else if (choixJoueur2 == "4")
            {
                player2.Attaquer(player1, Chidori);
            }
            
            
            
            // Affichage des Pv de chaque joueurs --------------------------------------------------------------------------
            Console.WriteLine("Il reste " +  player1.Pv + "PV à " + player1.Name); 
            Console.WriteLine("Il reste " +  player2.Pv + "PV à " + player2.Name);
            
            
            
            // Condition pour savoir si l'un ou l'autre l'emporte ----------------------------------------------------------
            if (player1.Pv <= 0)
            {
                Console.WriteLine(player2.Name + " l'emporte !");
            }
            else if (player2.Pv <= 0)
            {
                Console.WriteLine(player1.Name + " l'emporte !");
            }
            else if (player1.Pv == 0 && player2.Pv == 0)
            {
                Console.WriteLine("Egalité !");
            }
        }
    }
}