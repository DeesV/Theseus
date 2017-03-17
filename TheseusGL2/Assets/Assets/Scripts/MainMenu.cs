using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject bgImagePanel;
    public GameObject titleScreenPanel;
    public GameObject pressEnterPanel;

    public GameObject settingsPanel;
    public GameObject creditPanel;

    public UIManager _UImanager;
    public SettingsMenu _Settings;
    public PauseMenu _PauseMenu;

    void Awake ()
    {
        _UImanager = GameObject.Find("GameManager").GetComponent<UIManager>();
        _Settings = GameObject.Find("GameManager").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("GameManager").GetComponent<PauseMenu>();
        /*if(_UImanager.inMainMenu == false)
        {

        }
        else*/
        _UImanager.inMainMenu = true;

       
    }
	void Update ()
    {
        
	}
    public void StartGame ()
    {
        //_UImanager.inMainMenu = false;
        SceneManager.LoadScene("ArneScene2");
        _UImanager.inMainMenu = false;
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
