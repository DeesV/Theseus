//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [Header("-Main Menu")] 
    public GameObject bgImagePanel;
    public GameObject titleScreenPanel;
    //public GameObject pressEnterPanel;

    public GameObject settingsMenuPanel;
    public GameObject creditPanel;

    [Header("-Game Status")]
    public UIManager _UIManager;


    void Awake ()
    {
        _UIManager = UIManager.instance;
    }
    public void ActivateMainMenu ()
    {
        if(SceneManager.GetActiveScene().name == "Test Arne Sandbox") //Test Arne Sandbox //InGameTest
        {
            SceneManager.LoadScene("MainMenuTest");
        }
        bgImagePanel.SetActive(true);
        titleScreenPanel.SetActive(true);
    }
    public void DeActivateMainMenu ()
    {
        bgImagePanel.SetActive(false);
        titleScreenPanel.SetActive(false);
    }
    public void ActivateSettings ()
    {
        settingsMenuPanel.SetActive(true);
    }
    public void DeActivateSettings ()
    {
        if (_UIManager.inMainMenu == true)
        {
            settingsMenuPanel.SetActive(false);
            bgImagePanel.SetActive(true);
            titleScreenPanel.SetActive(true);
        }
    }
    public void ActivateCredits ()
    {
        creditPanel.SetActive(true);
    }
    public void DeActivateCredits ()
    {
        creditPanel.SetActive(false);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
    public void DeActivateTitleScreen ()
    {
        titleScreenPanel.SetActive(false);
    }
}
