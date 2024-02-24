using System.Drawing;

public class Vehicule
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Vitesse { get; set; }
    public Color Couleur { get; set; }

    public Vehicule(int x, int y, int vitesse, Color couleur)
    {
        X = x;
        Y = y;
        Vitesse = vitesse;
        Couleur = couleur;
    }

    public virtual void Avancer()
    {
        X += Vitesse;
    }

    public virtual void Dessiner(Graphics g)
    {
        g.FillRectangle(new SolidBrush(Couleur), X, Y, 20, 20);
    }

    public bool PrioriteADroite(Carrefour carrefour)
    {
        foreach (var autreVehicule in carrefour.Vehicules)
        {
            if (autreVehicule.X > X && autreVehicule.Y == Y && autreVehicule.Vitesse > Vitesse)
            {
                return true; // Il y a un véhicule à droite avec la priorité
            }
        }
        return false; // Pas de véhicule à droite avec la priorité
    }
}
