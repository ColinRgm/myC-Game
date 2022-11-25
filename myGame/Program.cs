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

        
        // Séléction des techniques player1 ----------------------------------------------------------------------------
        Console.WriteLine("Joueur 1, veuillez séléctionner votre technique :");
        Console.WriteLine("[1] -> Katon");
        Console.WriteLine("[2] -> Rasengan");
        Console.WriteLine("[3] -> Amaterasu");
        Console.WriteLine("[4] -> Chidori");
        
        string choixAttaque = Console.ReadLine();
        
        if (choixAttaque == "1")
        {
            player1.Attaquer(player2, Katon);
        }
        else if (choixAttaque == "2")
        {
            player1.Attaquer(player2, Rasengan);
        }
        else if (choixAttaque == "3")
        {
            player1.Attaquer(player2, Amaterasu);
        }
        else if (choixAttaque == "4")
        {
            player1.Attaquer(player2, Chidori);
        }
        
        
        // Boucler jusqu'à ce qu'un joueur arrive à 0 Pv ---------------------------------------------------------------
        while (player1.Pv != 0 || player2.Pv != 0)
        {
                 Console.WriteLine("Personne n'a gagné");
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