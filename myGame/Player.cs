namespace myGame;

public class Player
{
    // Attributs
    public int Id;
    public string Name;
    public int PV;
    
    
    // Constructeur
    public Player(string name, int pv, int id)
    {
        this.Id = id;
        this.Name = name;
        this.PV = pv;
    }

    
    // Méthodes
    public void bouleDeFeu(Player player)
    {
        if (this.Name != player.Name)
        {
            player.PV = player.PV - 10;
        }
    }

    public void rasengan(Player player)
    {
        if (this.Name != player.Name)
        {
            player.PV = player.PV - 20;
        }
    }

    public void soigner(Player player)
    {
        if (this.Name == player.Name)
        {
            player.PV = player.PV + 15;
        }
    }
    
    public void defendre()
    {
        
    }

    

}