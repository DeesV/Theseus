using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [Header("-Main Menu")] 
    public GameObject bgImagePanel;
    public GameObject titleScreenPanel;
    //public GameObject pressEnterPanel;

    public GameObject settingsPanel;
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
        bgImagePanel.SetActive(true);

    }
}
