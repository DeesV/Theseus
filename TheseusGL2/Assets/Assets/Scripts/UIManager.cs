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
    
    //Game Status Enum(Switch)
    public enum GameStatus {Mainmenu, Ingame, Credits, Settings};
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)


    [Header("-Script Shortcuts")]
    public MainMenu _MainMenu;
    public SettingsMenu _Settings;
    public PauseMenu _PauseMenu;

    [Header("GameManager Object")]
    public GameObject gameManager;
    public GameObject canvas;

    void Awake ()
    {
        gameManager = GameObject.Find("GameManager");
        DontDestroyOnLoad(gameManager);
        canvas = GameObject.Find("Canvas");
        DontDestroyOnLoad(canvas);

        _MainMenu = GameObject.Find("GameManager").GetComponent<MainMenu>();
        _Settings = GameObject.Find("GameManager").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("GameManager").GetComponent<PauseMenu>();
    }
    void Start ()
    {
        //Debug.Log(string.Format("Scene name is {0}", SceneManager.GetActiveScene().name));
           
    }
	void Update ()
    {
        
    }
    public void CheckGameStatus ()
    {
        switch (_GameStatus)
        {

            case GameStatus.Mainmenu:

                _MainMenu.ActivateMainMenu();
                //CursorStatus(); in main menu script een cursorstatus function en daar aanpassen?

                break;

            case GameStatus.Ingame:

                _MainMenu.DeActivateMainMenu();
                _PauseMenu.ActivateInGame();
                
                //CursorStatus();

                break;

            case GameStatus.Credits:
                
                //CursorStatus();

                break;

            case GameStatus.Settings:

                //CursorStatus();


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
    public void ExitGame ()
    {

    }
    public void CursorStatus ()
    {

    }
    public void PressEscape ()
    {

    }  
}
