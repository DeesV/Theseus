using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

   
    [Header("-Different menus")]
    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;

    [Header("-Settings panels")]
    public GameObject soundOptionsPanel;
    public GameObject keyBindingsPanel;
    public GameObject controlSettingsPanel;
    public GameObject gameSettingsPanel;

    [Header("-CursorState")]
    public CursorLockMode cursorMode;

    //[Header("-Game Status Enum(Switch)")]
    public enum GameStatus {Mainmenu, Ingame, Credits, Settings};
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)


    [Header("-Script Shortcuts")]
    public MainMenu _MainMenu;
    public SettingsMenu _Settings;
    public PauseMenu _PauseMenu;


    void Awake ()
    {
        _MainMenu = GameObject.Find("GameManager").GetComponent<MainMenu>();
        _Settings = GameObject.Find("GameManager").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("GameManager").GetComponent<PauseMenu>();
    }
    void Start ()
    {
        /*Debug.Log(string.Format("Scene name is {0}", SceneManager.GetActiveScene().name));
        if(SceneManager.GetActiveScene().name == "ArneScene2")
        {
            _GameStatus = GameStatus.Ingame;
        }
        else if(SceneManager.GetActiveScene().name == "ArneScene")
        {
            _GameStatus = GameStatus.Mainmenu;
        }*/
           
    }
	void Update ()
    {
        
    }
    public void CheckGameStatus ()
    {
        switch (_GameStatus)
        {

            case GameStatus.Mainmenu:
                
                //_MainMenu.
                CursorStatus();

                break;

            case GameStatus.Ingame:
                
                
                CursorStatus();

                break;

            case GameStatus.Credits:
                
                CursorStatus();

                break;

            case GameStatus.Settings:

                CursorStatus();


                break;
        }
    }
    public void StartGame ()
    {
        _GameStatus = GameStatus.Ingame;
        CheckGameStatus();
    }
    public void Settings ()
    {
        _GameStatus = GameStatus.Settings;
        CheckGameStatus();
    }
    public void Credits ()
    {
        _GameStatus = GameStatus.Credits;
        CheckGameStatus();
    }
    public void ToMainMenu ()
    {
        _GameStatus = GameStatus.Mainmenu;
        CheckGameStatus();
    }
    public void CursorStatus ()
    {

    }
    public void PressEscape ()
    {

    }  
}
