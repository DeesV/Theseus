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
    public UIManager _Uimanager;
    public SettingsMenu _Settings;
    public PauseMenu _PauseMenu;


    void Awake ()
    {
        _Uimanager = GameObject.Find("GameManager").GetComponent<UIManager>();
        _Settings = GameObject.Find("GameManager").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("GameManager").GetComponent<PauseMenu>();
        //bgImagePanel.SetActive(false);
        //titleScreenPanel.SetActive(false);


        /*if(_Uimanager.inMainMenu == false)
        {

        }
        else*/
        //_UImanager.inMainMenu = true;


    }
	void Update ()
    {
        
	}
    public void ActivateMainMenu ()
    {
        bgImagePanel.SetActive(true);
        titleScreenPanel.SetActive(true);
    }
    public void DeActivateMainMenu ()
    {
        bgImagePanel.SetActive(false);
        titleScreenPanel.SetActive(false);
    }
    public void ActivateSettings()
    {
        settingsMenuPanel.SetActive(true);
    }
    public void DeActivateSettings ()
    {
        settingsMenuPanel.SetActive(false);
    }
    public void ActivateCredits ()
    {
        creditPanel.SetActive(true);
    }
    public void DeActivateCredits()
    {
        creditPanel.SetActive(false);
    }
    public void ExitGame ()
    {
        //Application.Quit();
        print("game quit");
    }
}
