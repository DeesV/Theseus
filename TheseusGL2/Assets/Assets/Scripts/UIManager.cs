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
    public enum GameStatus {Mainmenu, Ingame, Credits, MainMenuSettings, IngameSettings};
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)


    [Header("-Script Shortcuts")]
    public MainMenu _MainMenu;
    public SettingsMenu _SettingsMenu;
    public PauseMenu _PauseMenu;

    [Header("GameManager Object")]
    public GameObject gameManager;
    public GameObject canvas;

    public bool inMainMenu;

    void Awake ()
    {
        gameManager = GameObject.Find("GameManager");
        DontDestroyOnLoad(gameManager);
        canvas = GameObject.Find("Canvas");
        DontDestroyOnLoad(canvas);

        _MainMenu = GameObject.Find("GameManager").GetComponent<MainMenu>();
        _SettingsMenu = GameObject.Find("GameManager").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("GameManager").GetComponent<PauseMenu>();
    }
    void Start ()
    {
        //Debug.Log(string.Format("Scene name is {0}", SceneManager.GetActiveScene().name));
           
    }
	void Update ()
    {
        PressEscape();
    }
    public void CheckGameStatus ()
    {
        switch (_GameStatus)
        {

            case GameStatus.Mainmenu:

                inMainMenu = true;
                _MainMenu.ActivateMainMenu();
                _MainMenu.DeActivateSettings();
                _MainMenu.DeActivateCredits();
                _PauseMenu.DeActivateInGame();
                _SettingsMenu.DeActivateSettings();
                //CursorStatus(); in main menu script een cursorstatus function en daar aanpassen?

                break;

            case GameStatus.Ingame:

                //inMainMenu = false;
                _MainMenu.DeActivateCredits();
                _MainMenu.DeActivateMainMenu();
                _SettingsMenu.DeActivateSettings();
                _PauseMenu.ActivateInGame();

                //CursorStatus();

                break;

            case GameStatus.Credits:

                //inMainMenu = true;
                _MainMenu.ActivateCredits();
                _MainMenu.DeActivateCredits();
                _SettingsMenu.DeActivateSettings();
                _PauseMenu.DeActivateInGame();
                

                //CursorStatus();

                break;

            case GameStatus.MainMenuSettings:

                //inMainMenu = true;
                _MainMenu.ActivateSettings();
                _MainMenu.DeActivateCredits();
                _MainMenu.DeActivateCredits();
                _PauseMenu.DeActivateInGame();


                break;

            case GameStatus.IngameSettings:

                //inMainMenu = false;
                _MainMenu.DeActivateCredits();
                _MainMenu.DeActivateMainMenu();
                _SettingsMenu.ActivateSettings();


                break;
        }
    }
    public void StartGame ()
    {
        _GameStatus = GameStatus.Ingame;
        CheckGameStatus();
    }
    public void MainMenuSettings ()
    {
        _GameStatus = GameStatus.MainMenuSettings;
        CheckGameStatus();
    }
    public void IngameSettings ()
    {
        _GameStatus = GameStatus.IngameSettings;
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
        _MainMenu.ExitGame();
    }
    public void CursorStatus (int cursormode)
    {

    }
    public void PressEscape ()
    {
        if(Input.GetButtonDown("Escape"))
        {
            pauseMenuPanel.SetActive(true);
        }
    }  
}
