using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject settingMenu;
    public GameObject Vague;
    public GameObject AdventureMenu;
    public GameObject PackageMenu;
    public GameObject TimeGo;
    public AudioMixer audioMixer;
    [SerializeField] private GameObject CharaBG1;
    [SerializeField] private GameObject CharaBG2;
    [SerializeField] private GameObject CharaBG3;
    [SerializeField] private GameObject CharaBG4;


    public void UIenable()
    {
        GameObject.Find("Canvus/menu/UI").SetActive(true);
    }

    public void pauseGame()
    {
        PauseMenu.SetActive(true);
        Vague.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resumeGame()
    {
        PauseMenu.SetActive(false);
        Vague.SetActive(false);
        Time.timeScale = 1f;
    }

    public void setVolume(float value)
    {
        audioMixer.SetFloat("mainVolume", value);
    }
    public void SettingOpen()
    {
        PauseMenu.SetActive(false);
        settingMenu.SetActive(true);

    }

    public void SettingClose()
    {
        settingMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }
    public void AdventureOpen()
    {
        AdventureMenu.SetActive(true);
        Vague.SetActive(true);
    }

    public void AdventureClose()
    {
        AdventureMenu.SetActive(false);
        Vague.SetActive(false);
    }

    public void AdventureStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PackageOpen()
    {
        PackageMenu.SetActive(true);
        Vague.SetActive(true);
    }

    public void PackageClose()
    {
        PackageMenu.SetActive(false);
        Vague.SetActive(false);
    }
    public void TimeGoOpen()
    {
        TimeGo.SetActive(true);
        Vague.SetActive(true);
    }
    public void TimeGoClose()
    {
        TimeGo.SetActive(false);
        Vague.SetActive(false);
    }

    public void CharaBG01()
    {
        CharaBG1.SetActive(true);
        Vague.SetActive(true);
    }
    public void CharaBGClose01()
    {
        CharaBG1.SetActive(false);
        Vague.SetActive(false);
    }
    public void CharaBG02()
    {
        CharaBG2.SetActive(true);
        Vague.SetActive(true);
    }
    public void CharaBGClose02()
    {
        CharaBG2.SetActive(false);
        Vague.SetActive(false);
    }
    public void CharaBG03()
    {
        CharaBG3.SetActive(true);
        Vague.SetActive(true);
    }
    public void CharaBGClose03()
    {
        CharaBG3.SetActive(false);
        Vague.SetActive(false);
    }
    public void CharaBG04()
    {
        CharaBG4.SetActive(true);
        Vague.SetActive(true);
    }
    public void CharaBGClose04()
    {
        CharaBG4.SetActive(false);
        Vague.SetActive(false);
    }

}

