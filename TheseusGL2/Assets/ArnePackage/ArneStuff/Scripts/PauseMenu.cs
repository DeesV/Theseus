//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject titleScreenPanel;
    public GameObject MainMenuPanel;

    public UIManager _UIManager;


    void Awake ()
    {
        _UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }
    //to ingame
    public void ActivateInGame ()
    {
        if (SceneManager.GetActiveScene().name == "MainMenuTest")
        {
            SceneManager.LoadScene("Test Arne Sandbox"); //InGameTest
        }//    Test Arne Sandbox
        hudPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);
    }
    //out of the game
    public void DeActivateInGame ()
    {
        hudPanel.SetActive(false);
        pauseMenuPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        //SceneManager.LoadScene("MainMenuTest");  //CAUSES A ERROR WHEN ACTIVATED; MULTIPLE EVENTSYSTEMS IN SCENE, THIS IS NOT SUPPORTED.
    }
    public void ResumeIngame ()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void ToPauseMenu ()
    {
        pauseMenuPanel.SetActive(true);
        settingsMenuPanel.SetActive(false);
        Time.timeScale = 0;
    }
    public void ActivateToMainMenu ()
    {
        MainMenuPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);
    }
    public void DeActivateToMainMenu ()
    {
        pauseMenuPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }
}
