using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInterface : MonoBehaviour
{
    [SerializeField] private GameObject buildInterface;
    [SerializeField] private GameObject mainUI;
    public void Exit()
    {
        buildInterface.SetActive(false);
        mainUI.SetActive(true);
    }
}
