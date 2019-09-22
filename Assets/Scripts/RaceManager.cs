using UnityEngine;
using System.Collections;

public class RaceManager : MonoBehaviour
{
    [SerializeField] private HUD hud;
    public Car[] allCars;
    public Car[] carOrder;

    public void Start()
    {
        carOrder = new Car[allCars.Length];
        InvokeRepeating("ManualUpdate", 0.5f, 0.5f); //for start update classification cars
    }

    // this gets called every frame
    public void ManualUpdate()
    {
        foreach (Car car in allCars)
        {
            carOrder[car.GetCarPosition(allCars) - 1] = car;
        }

        hud.HudUpdate("1º - " + carOrder[0].name + "\n" + 
                      "2º - " + carOrder[1].name + "\n" +
                      "3º - " + carOrder[2].name + "\n" +
                      "4º - " + carOrder[3].name);
    }
}

