using myGame;

public class Program
{

    static void Main()
    {
        Player player1 = new Player("Joris", 50);
        Player player2 = new Player("Bryan", 50);
        
        Console.WriteLine("Le joueur 1 s'appelle " + player1.Name + " et il a " + player1.PV + "PV");
        Console.WriteLine("Le joueur 2 s'appelle " + player2.Name + " et il a " + player2.PV + "PV");
        
        Console.WriteLine("3");
        Console.WriteLine("2");
        Console.WriteLine("1");
        Console.WriteLine("Fight !");
    }
}