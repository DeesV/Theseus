using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Main Menu 
    public GameObject bgImagePanel;
    public GameObject titleScreenPanel;
    //public GameObject pressEnterPanel;

    public GameObject settingsPanel;
    public GameObject creditPanel;

    //Game Status
    public UIManager _Uimanager;
    public SettingsMenu _Settings;
    public PauseMenu _PauseMenu;


    void Awake ()
    {
        _Uimanager = GameObject.Find("GameManager").GetComponent<UIManager>();
        _Settings = GameObject.Find("GameManager").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("GameManager").GetComponent<PauseMenu>();
        
        
        
        /*if(_Uimanager.inMainMenu == false)
        {

        }
        else*/
        //_UImanager.inMainMenu = true;

       
    }
	void Update ()
    {
        
	}
    public void MainMenuActive ()
    {
        //print("hi");
    }
    public void StartGame ()
    {
        //_UImanager.inMainMenu = false;
        SceneManager.LoadScene("ArneScene2");
        _Uimanager.inMainMenu = false;
    }
    public void Settings ()
    {
        
    }
    public void Credits ()
    {
        
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
}
