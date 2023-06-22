using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canteen : MonoBehaviour
{
    private void Start()
    {
        ProvideFood();
    }
    /// <summary>
    ///提供食物 
    /// </summary>
    public void ProvideFood()
    {
        GameManager.instance.ChangeFood(2);
    }
}
