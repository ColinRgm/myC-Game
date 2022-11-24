namespace myGame;

public class Player
{
    // Attributs
    public int PV = 50;

    public string Name;

    // Constructeur
    public Player(string name, int pv)
    {
        this.Name = name;
        this.PV = pv;
    }

    // Méthodes
    public string attaque1;

    public string attaque2;

    public string defendre;

    public string soigner;

}