using myGame;

public class Program
{

    public static void Main()
    {
        // Instanciation des deux joueurs ------------------------------------------------------------------------------
        // Joueur 1
        Console.WriteLine(" ");
        Console.Write("Joueur 1 choisissez votre nom : ");
        Player player1 = new Player(Console.ReadLine());
        Console.WriteLine(player1.Name + " " + player1.Pv + "PV");
        
        // Joueur 2
        Console.WriteLine(" ");
        Console.Write("Joueur 2 choisissez votre nom : ");
        Player player2 = new Player(Console.ReadLine());
        Console.WriteLine(player2.Name + " " + player2.Pv + "PV");
        
        Console.WriteLine(" ");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine(" ");
        
        
        
        
        // Création des attaques ---------------------------------------------------------------------------------------
        Attaque Rasengan = new Attaque("Rasengan", 15);
        Attaque Chidori = new Attaque("Eclair pourfendeur", 15);
        Attaque Katon = new Attaque("Boule de feu", 10);
        Attaque Amaterasu = new Attaque("Lumière céleste", 30);
        
        
        
        
        // Création des défenses ---------------------------------------------------------------------------------------
        Soin Ramen = new Soin("Ichiraku ramen", 10);
        Soin Autre = new Soin("Je sais pas encore", 10); // -----------------------------------------
        
        
        
        
        // Création du bouclier
        Bouclier Shield = new Bouclier();


        
        
        // Boucler jusqu'à ce qu'un joueur arrive à 0 Pv ---------------------------------------------------------------
        while (player1.Pv >= 0 && player2.Pv >= 0)
        {
            // Séléction des techniques player1 ------------------------------------------------------------------------
            Console.WriteLine(player1.Name + ", veuillez séléctionner votre technique :");
            Console.WriteLine("Attaques :");
            Console.WriteLine("[1] -> Katon || [2] -> Rasengan || [3] -> Amaterasu || [4] -> Chidori");
            Console.WriteLine("Soins :");
            Console.WriteLine("[5] -> Ramen");
            Console.WriteLine("Défenses :");
            Console.WriteLine("[6] -> Esquive");
            
            string choixJoueur = Console.ReadLine();

            switch (choixJoueur)
            {
                case "1":
                    player1.Attaque(player2, Katon);
                    break;
                case "2":
                    player1.Attaque(player2, Rasengan);
                    break;
                case "3":
                    player1.Attaque(player2, Amaterasu);
                    break;
                case "4":
                    player1.Attaque(player2, Chidori);
                    break;
                case "5":
                    player1.seSoigne(player1, Ramen);
                    break;
                case "6":
                    player1.seDefend();
                    break;
            }

            Console.WriteLine(" ");
            
            
            
            
            // Séléction des techniques player2 ------------------------------------------------------------------------
            Console.WriteLine(player2.Name + ", veuillez séléctionner votre technique :");
            Console.WriteLine("Attaques :");
            Console.WriteLine("[1] -> Katon || [2] -> Rasengan || [3] -> Amaterasu || [4] -> Chidori");
            Console.WriteLine("Soins :");
            Console.WriteLine("[5] -> Ramen");
            Console.WriteLine("Défenses :");
            Console.WriteLine("[6] -> Esquive");

            string choixJoueur2 = Console.ReadLine();
            
            switch (choixJoueur2)
            {
                case "1":
                    player2.Attaque(player1, Katon);
                    break;
                case "2":
                    player2.Attaque(player1, Rasengan);
                    break;
                case "3":
                    player2.Attaque(player1, Amaterasu);
                    break;
                case "4":
                    player2.Attaque(player1, Chidori);
                    break;
                case "5":
                    player2.seSoigne(player2, Ramen);
                    break;
                case "6":
                    player2.seDefend();
                    break;
            }
            

            
            // Combat de la vallée de la fin ---------------------------------------------------------------------------
            if (choixJoueur == "2" || choixJoueur2 == "4")
            {
                player1.Pv = player1.Pv / 2;
                player2.Pv = player2.Pv / 2;
            }
            
            
            
            
            
            // Affichage des Pv de chaque joueurs ----------------------------------------------------------------------
            Console.WriteLine("Il reste " +  player1.Pv + "PV à " + player1.Name); 
            Console.WriteLine("Il reste " +  player2.Pv + "PV à " + player2.Name);
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" ");
            
            
            
            
            // Condition pour savoir si l'un ou l'autre l'emporte ------------------------------------------------------
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
            
            
            
            // Seter bouclier à zéro
            player1.PossedeBouclier = 0;
            player2.PossedeBouclier = 0;
        }
    }
}