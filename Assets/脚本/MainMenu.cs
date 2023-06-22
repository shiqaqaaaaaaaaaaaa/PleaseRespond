using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Setting()
    {
        settingMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void ExitSettingMenu()
    {
        settingMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
