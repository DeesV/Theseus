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

    //Game Status Enum(Switch)
    public enum GameStatus {Mainmenu, Ingame, Paused, Settings};
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)
    


    void Awake ()
    {

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



                break;

            case GameStatus.Ingame:
                inMainMenu = false;
                gamePaused = false;



                break;

            case GameStatus.Paused:
                inMainMenu = false;
                gamePaused = true;



                break;

            case GameStatus.Settings:
                inMainMenu = false;
                gamePaused = true;



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
