using myGame;

public class Program
{

    public static void Main()
    {
        Player player1 = new Player("Naruto", 50, 1);
        Player player2 = new Player("Sasuke", 50, 2);
        
        Console.WriteLine("Le joueur 1 s'appelle " + player1.Name + " et il a " + player1.PV + "PV");
        Console.WriteLine("Le joueur 2 s'appelle " + player2.Name + " et il a " + player2.PV + "PV");
        
        
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("Le joueur 1 possede " +  player1.PV + "PV");
        Console.WriteLine("Le joueur 2 possede " +  player2.PV + "PV");

        if (player1.PV == 0)
        {
            Console.WriteLine(player2.Name + " l'emporte !");
        }
        else if (player2.PV == 0)
        {
            Console.WriteLine(player1.Name + " l'emporte !");
        }
    }
}