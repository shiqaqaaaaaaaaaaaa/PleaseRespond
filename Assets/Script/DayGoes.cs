using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DayGoes : MonoBehaviour
{
    public Text DayNum;
    public GameObject black;
    public GameObject menu;

    public void Click()
    {
        black.SetActive(true);
    }
    public void DayGo(UI nextday)
    {
        nextday.Day += 1;
        DayNum.text= nextday.Day.ToString();
        
    }
    public void Close()
    {
        menu.SetActive(false);
        black.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
