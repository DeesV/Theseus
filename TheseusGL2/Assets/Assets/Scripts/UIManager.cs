using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

   
    //Different menus
    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;

    //Settings panels
    public GameObject soundOptionsPanel;
    public GameObject keyBindingsPanel;
    public GameObject controlSettingsPanel;
    public GameObject gameSettingsPanel;

    //Cursor
    public CursorLockMode cursorMode;

    //Game Status
    public bool inMainMenu;//false not in main menu, true in main menu.
    public bool gamePaused;//false is game not paused, true is game paused.
    public bool inSettings;//false when not in settings, true if in settings.

    //Game Status Enum(Switch)
    public enum GameStatus {Mainmenu, Ingame, Paused, Settings};
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)


    //Script Shortcuts
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
		
	}
	void Update ()
    {
        switch (_GameStatus)
        {

            case GameStatus.Mainmenu:
                inMainMenu = true;
                gamePaused = false;
                inSettings = false;
                _MainMenu.MainMenuActive();
                CursorStatus();

                break;

            case GameStatus.Ingame:
                inMainMenu = false;
                gamePaused = false;
                inSettings = false;
                _PauseMenu.InGame();
                CursorStatus();

                break;

            case GameStatus.Paused:
                inMainMenu = false;
                gamePaused = true;
                inSettings = false;
                Paused();
                CursorStatus();

                break;

            case GameStatus.Settings:
                inMainMenu = false;
                gamePaused = true;
                inSettings = true;
                _Settings.SettingsOpen();
                

                break;
        }
	}
    public void Paused ()
    {

    }
    public void Unpause ()
    {

    }
    public void CursorStatus ()
    {

    }
    public void PressEscape ()
    {

    }  
}
