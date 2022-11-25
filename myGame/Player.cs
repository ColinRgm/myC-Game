namespace myGame;


// Class player --------------------------------------------------------------------------------------------------------
public class Player
{
    // Attributs
    public string Name;
    public int Pv;
    public int PossedeBouclier;
    
    
    // Constructeur
    public Player(string name)
    {
        this.Name = name;
        this.Pv = 75;

        this.PossedeBouclier = 0;
    }
    
    
    // Méthode attaquer
    public void Attaque(Player player, Attaque attaque)
    {
        if (this.Name != player.Name)
        {
            if (player.PossedeBouclier != 1)
            {
                player.Pv = player.Pv - attaque.Puissance;
            }
        }
        else
        {
            Console.WriteLine("Impossible de s'attaquer soi-même !!");
        }
    }

    
    // Méthode soigner
    public void seSoigne(Player player, Soin soin)
    {
        if (this.Name == player.Name)
        {
            player.Pv = player.Pv + soin.Puissance;
            
        }
        else
        {
            Console.WriteLine("Impossible de soigner l'adversaire !!");
        }
    }


    // Méthode defendre
    public void seDefend()
    {
        this.PossedeBouclier = 1;
    }

    
}