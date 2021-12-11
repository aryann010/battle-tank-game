using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankController 
{
   public tankController(tankModel TankModel, tankView tankPrefab)
    {
        tankModel = TankModel;
        tankView = GameObject.Instantiate<tankView>(tankPrefab);
        Debug.Log("tank view created");
    }
    public tankModel tankModel { get; }
    public tankView tankView { get; }
}
