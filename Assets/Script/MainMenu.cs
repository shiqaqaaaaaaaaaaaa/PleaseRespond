using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public GameObject SetMenu;
    public AudioMixer audioMixer;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void SetBgm(float Value)
    {
        audioMixer.SetFloat("Bgm", Value);
    }
   public void SetOpen()
    {
        SetMenu.SetActive(true);
    }
    public void SetClose()
    {
        SetMenu.SetActive(false);
    }
}
