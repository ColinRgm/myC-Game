namespace myGame;


// Class player --------------------------------------------------------------------------------------------------------
public class Player
{
    // Attributs
    public string Name;
    public int Pv;
    
    
    // Constructeur
    public Player(string name, int pv)
    {
        this.Name = name;
        this.Pv = pv;
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
    
}