namespace myGame;


// Class player --------------------------------------------------------------------------------------------------------
public class Player
{
    // Attributs
    public string Name;
    public int Pv;
    
    
    // Constructeur
    public Player(string name)
    {
        this.Name = name;
        this.Pv = 75;
    }
    
    
    // Méthode attaquer
    public void Attaquer(Player player, Attaque attaque)
    {
        if (this.Name != player.Name)
        {
            player.Pv = player.Pv - attaque.Puissance;
            
        }
        else
        {
            Console.WriteLine("Impossible de s'attaquer soi-même !!");
        }
    }

    public void Soigner(Player player, Soins soins)
    {
        if (this.Name == player.Name)
        {
            player.Pv = player.Pv + soins.Puissance;
            
        }
        else
        {
            Console.WriteLine("Impossible de soigner l'adversaire !!");
        }
    }
    
}