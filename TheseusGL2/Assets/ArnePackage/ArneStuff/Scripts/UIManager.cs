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
    public GameObject creditPanel;
    public GameObject toMainMenuOptionPanel;

    [Header("-Settings panels")]
    public GameObject soundOptionsPanel;
    public GameObject keyBindingsPanel;
    public GameObject controlSettingsPanel;
    public GameObject gameSettingsPanel;

    [Header("-CursorState")]
    public CursorLockMode cursorMode;
    public bool isCursorLocked;


    //Game Status Enum(Switch)
    public enum GameStatus { Mainmenu, Ingame, IngamePaused, IngameUnpaused, Credits, MainMenuSettings, IngameSettings };
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)
    public enum SettingsStatus { None, Sound, Keybindings, ControlSettings, GameSettings };
    public SettingsStatus _SettingsStatus;

    [Header("-Script Shortcuts")]
    public MainMenu _MainMenu;
    public SettingsMenu _SettingsMenu;
    public PauseMenu _PauseMenu;
    public UIManager _UIManager;

    [Header("GameManager Object")]
    public GameObject gameManager;
    public GameObject canvas;

    [Header("Menus Activated")]
    public bool inMainMenu;
    public bool inCredits;
    public bool paused;
    public bool inSettings;
    public bool toTitleScreen;

    void Awake()
    {
        _MainMenu = GameObject.Find("Canvas").GetComponent<MainMenu>();
        _SettingsMenu = GameObject.Find("Canvas").GetComponent<SettingsMenu>();
        _PauseMenu = GameObject.Find("Canvas").GetComponent<PauseMenu>();
        _UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        isCursorLocked = false;
        CursorMode();
    }
    void Start ()
    {
        CheckGameStatus();
        CheckSettingPanelStatus();
    }
    void Update()
    {
        PressEscape();
        CursorMode();
    }
    public void CheckGameStatus()
    {
        switch (_GameStatus)
        {

            case GameStatus.Mainmenu:

                inMainMenu = true;
                inCredits = false;
                inSettings = false;
                paused = false;
                isCursorLocked = false;

                _MainMenu.ActivateMainMenu();
                _MainMenu.DeActivateSettings();
                _MainMenu.DeActivateCredits();
                _PauseMenu.DeActivateInGame();

                break;

            case GameStatus.Ingame:

                inMainMenu = false;
                inCredits = false;
                inSettings = false;
                paused = false;
                isCursorLocked = true;

                _PauseMenu.ActivateInGame();
                _MainMenu.DeActivateMainMenu();

                break;

            case GameStatus.IngamePaused:

                inMainMenu = false;
                inCredits = false;
                inSettings = false;
                paused = true;
                isCursorLocked = false;
                toTitleScreen = false;

                _PauseMenu.ToPauseMenu();
                _MainMenu.DeActivateMainMenu();
                _SettingsMenu.DeActivateSettings();
                _PauseMenu.DeActivateToMainMenu();


                break;

            case GameStatus.IngameUnpaused:

                inMainMenu = false;
                inCredits = false;
                inSettings = false;
                paused = false;
                isCursorLocked = true;

                _PauseMenu.ResumeIngame();
                _MainMenu.DeActivateMainMenu();
                _SettingsMenu.DeActivateSettings();

                isCursorLocked = false;

                break;

            case GameStatus.Credits:

                inMainMenu = true;
                inCredits = true;
                inSettings = false;
                paused = false;
                isCursorLocked = false;

                _MainMenu.ActivateCredits();

                break;

            case GameStatus.MainMenuSettings:

                inMainMenu = true;
                inCredits = false;
                inSettings = true;
                paused = false;
                isCursorLocked = false;

                _MainMenu.ActivateSettings();
                _MainMenu.DeActivateTitleScreen();

                break;

            case GameStatus.IngameSettings:

                inMainMenu = false;
                inCredits = false;
                inSettings = true;
                paused = true;
                isCursorLocked = false;

                _SettingsMenu.ActivateSettings();

                break;
        }
    }
    public void CheckSettingPanelStatus()
    {
        switch (_SettingsStatus) //SETTINGS GAAT VERDER WAAR JE HEM DE LAATSTE KEER HEBT AFGESLOTEN!!!!!!!!!!!!!!!!!!!!
        {

            case SettingsStatus.None:

                _SettingsMenu.InActiveSettings();

                break;

            case SettingsStatus.Sound:

                _SettingsMenu.Sound();

                break;

            case SettingsStatus.Keybindings:

                _SettingsMenu.Keybindings();

                break;

            case SettingsStatus.ControlSettings:

                _SettingsMenu.ControlSettings();

                break;

            case SettingsStatus.GameSettings:

                _SettingsMenu.GameSettings();

                break;

        }
    }
    public void StartGame()
    {
        _GameStatus = GameStatus.Ingame;
        CheckGameStatus();
    }
    public void MainMenuSettings()
    {
        _GameStatus = GameStatus.MainMenuSettings;
        CheckGameStatus();
    }
    public void Credits()
    {
        _GameStatus = GameStatus.Credits;
        CheckGameStatus();
    }
    public void EscapeCredits ()
    {
        _GameStatus = GameStatus.Mainmenu;
        CheckGameStatus();
    }
    public void ExitGame()
    {
        _MainMenu.ExitGame();
    }
    public void ContinueGame()
    {
        _GameStatus = GameStatus.IngameUnpaused;
        CheckGameStatus();
    }
    public void PauseGame()
    {
        _GameStatus = GameStatus.IngamePaused;
        CheckGameStatus();
    }
    public void IngameSettings()
    {
        _GameStatus = GameStatus.IngameSettings;
        CheckGameStatus();
    }
    public void SoundSettings()
    {
        _SettingsStatus = SettingsStatus.Sound;
        CheckSettingPanelStatus();
    }
    public void KeyBindingsSettings()
    {
        _SettingsStatus = SettingsStatus.Keybindings;
        CheckSettingPanelStatus();
    }
    public void ControlSettings()
    {
        _SettingsStatus = SettingsStatus.ControlSettings;
        CheckSettingPanelStatus();
    }
    public void GameSettings()
    {
        _SettingsStatus = SettingsStatus.GameSettings;
        CheckSettingPanelStatus();
    }
    public void OpenBackToTitleScreenOption()
    {
        _PauseMenu.ActivateToMainMenu();
        toTitleScreen = true;
    }
    public void BackToTitleScreen()
    {
        _GameStatus = GameStatus.Mainmenu;
        CheckGameStatus();
    }
    public void InActiveSettingsMenu()
    {
        _SettingsStatus = SettingsStatus.None;
        CheckSettingPanelStatus();
    }
    public void SettingsToMainMenu()
    {
        if (inMainMenu == true)
        {
            _GameStatus = GameStatus.Mainmenu;
            CheckGameStatus();
            _SettingsStatus = SettingsStatus.None;
            CheckSettingPanelStatus();
        }
    }
    public void SettingsToPauseMenu()
    {
        if (inMainMenu == false)
        {
            _GameStatus = GameStatus.IngamePaused;
            CheckGameStatus();
            _SettingsStatus = SettingsStatus.None;
            CheckSettingPanelStatus();

        }
    }
    public void ToTitleScreenToPauseMenu()
    {
        _PauseMenu.DeActivateToMainMenu();
        toTitleScreen = false;
    }
    public void CursorMode()
    {
        if (isCursorLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    public void PressEscape()
    {
        if(Input.GetButtonDown("Escape"))
        {
            if (paused == true && inSettings == false && toTitleScreen == false)  
            {
                _GameStatus = GameStatus.IngameUnpaused;
                CheckGameStatus();
            }
            else if (inMainMenu == false && paused == false)
            {
                _GameStatus = GameStatus.IngamePaused;
                CheckGameStatus();
            }
            else if(inSettings == true && paused == true)
            {
                _GameStatus = GameStatus.IngamePaused;
                CheckGameStatus();

                _SettingsStatus = SettingsStatus.None;
                CheckSettingPanelStatus();
            }
            else if(paused == true && toTitleScreen == true)
            {
                _GameStatus = GameStatus.IngamePaused;
                CheckGameStatus();
            }
            else if(inMainMenu == true && inSettings == true)
            {
                _GameStatus = GameStatus.Mainmenu;
                CheckGameStatus();

                _SettingsStatus = SettingsStatus.None;
                CheckSettingPanelStatus();

            }
            else if(inCredits == true)
            {
                _GameStatus = GameStatus.Mainmenu;
                CheckGameStatus();
            }
        }
    }
}
