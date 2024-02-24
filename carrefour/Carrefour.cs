using System.Collections.Generic;
using System.Drawing;
using carrefour;

public class Carrefour
{
    public List<Vehicule> Vehicules { get; set; }

    public Carrefour()
    {
        Vehicules = new List<Vehicule>();
        Vehicules.Add(new VehiculeA(50, 100));
        Vehicules.Add(new VehiculeB(100, 50));
        Vehicules.Add(new VehiculeC(150, 100));
        Vehicules.Add(new VehiculeD(100, 150));
    }

    public void DeplacerVehicules()
    {
        foreach (var vehicule in Vehicules)
        {
            if (vehicule.PrioriteADroite(this))
            {
                vehicule.Vitesse = 0; // Arrêter le véhicule s'il doit donner la priorité
            }
            else
            {
                vehicule.Vitesse = 2; // Sinon, continuer à avancer
            }
            vehicule.Avancer();
        }
    }

    public void Dessiner(Graphics g)
    {
        foreach (var vehicule in Vehicules)
        {
            vehicule.Dessiner(g);
        }
    }
}
