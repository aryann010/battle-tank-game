using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankService : MonoBehaviour
{
    public tankView TankView;

    private void Start()
    {
        startGame();

    }
    private void startGame()
    {
        for(int i = 0; i < 4; i++)
        {
            createNewTank();
        }
    }
    private tankController createNewTank()
    {
        tankModel model = new tankModel(5, 100f);
        tankController tank = new tankController(model, TankView);
        return tank;
    }
}
