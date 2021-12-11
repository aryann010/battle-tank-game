using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoSingletonGeneric<T> : MonoBehaviour where T: monoSingletonGeneric<T>
{
    private static T instance;
    public static T Instance { get { return Instance; } }
    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Debug.Log("error! duplicate singleton can't be created");
            Destroy(this);
        }
    }
}
 public class GameWorldNew : monoSingletonGeneric<GameWorldNew>
{
    protected override void Awake()
    {
        base.Awake();
    }
    public void StartGameNew() { }
}
public class WorldNew: MonoBehaviour
{
    private void Start()
    {
        GameWorldNew.Instance.StartGameNew();
    }
}
public class playerTank : monoSingletonGeneric<playerTank>
{

}
public class enemyTank : monoSingletonGeneric<enemyTank>
{

}