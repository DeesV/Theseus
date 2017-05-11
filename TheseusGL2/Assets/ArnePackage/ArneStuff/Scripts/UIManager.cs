//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    /*          NOTES   

        When you load a scene the script starts again
        In mainMenu and PauseMenu is a function that changes the scene(from mainmenu->ingame and ingame->mainmenu

        MAKE GOOD PREFAB
        Make loadingscreen!
        
        Get the scripts on the GameManager!

    


        uimanager = referentie static naar zichzelf
        gooi alle variabelen van UI er van tevoren in, sinds er geen switching van scenes is
        1 void overload functie voor elk item wat je aan / uit wilt zetten, in de ui buttons zelf kan je hem overloaden
        met 1 ui object
        die functie is letterlijk: zet alles uit, zet daarna overloaded item aan

        //ipv voor elke menuitem een aan uit voor alles custom maken
        List<Transform> all gameobjectus
        EnableMenuItem(Transform enable)
            EnableMenuItem(new List<Transform> {enable })
        een functie EnableMenuItem(List<Transform> enables)
            
            disable all
            enable those


                BUGS
        Awake function makes the script turn off




    */
    [Header("-Different menus")]
    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject titleScreenPanel;
    public GameObject creditPanel;
    public GameObject toMainMenuOptionPanel;

    public GameObject stats;
    public GameObject lvlUP;

    [Header("-Settings panels")]
    public GameObject soundOptionsPanel;
    public GameObject keyBindingsPanel;
    public GameObject controlSettingsPanel;
    public GameObject gameSettingsPanel;

    [Header("-CursorState")]
    public CursorLockMode cursorMode;
    public bool isCursorLocked;


    //Game Status Enum(Switch)
    public enum GameStatus { Mainmenu, Loading, Ingame, IngamePaused, IngameUnpaused, Credits, MainMenuSettings, IngameSettings };
    public GameStatus _GameStatus;

    //Settings Status Enum(switch)
    public enum SettingsStatus { None, Sound, Keybindings, ControlSettings, GameSettings };
    public SettingsStatus _SettingsStatus;

    public static MainMenu _MainMenu;
    public static SettingsMenu _SettingsMenu;
    public static PauseMenu _PauseMenu;
    public static UIManager _UIManager;
    public static LoadController _LoadController;

    public static GameObject gameManager;
    public GameObject canvas;

    [Header("Menus Activated")]
    public bool inMainMenu;
    public bool inCredits;
    public bool paused;
    public bool inSettings;
    public bool toTitleScreen;
    public bool loading;

    //static reference
    public static UIManager instance;

    /*
    uimanager = referentie static naar zichzelf
    gooi alle variabelen van UI er van tevoren in, sinds er geen switching van scenes is
    1 void overload functie voor elk item wat je aan / uit wilt zetten, in de ui buttons zelf kan je hem overloaden
    met 1 ui object
    die functie is letterlijk: zet alles uit, zet daarna overloaded item aan
    */

    void Awake()
    {
        instance = this;
        gameManager = GameObject.FindWithTag("GameManager");

        _MainMenu = gameManager.GetComponent<MainMenu>(); 
        _SettingsMenu = gameManager.GetComponent<SettingsMenu>();
        _PauseMenu = gameManager.GetComponent<PauseMenu>();
        _UIManager = GetComponent<UIManager>();
        _LoadController = gameManager.GetComponent<LoadController>();
        
        isCursorLocked = false;
        //CursorMode();
    }
    void Start ()
    {
        stats.SetActive(false);
        lvlUP.SetActive(false);
        CheckGameStatus();
        CheckSettingPanelStatus();
    }
    void Update()
    {
        PressEscape();
        //CursorMode();
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
                loading = false;
                isCursorLocked = false;

                _MainMenu.ActivateMainMenu();
                _MainMenu.DeActivateSettings();
                _MainMenu.DeActivateCredits();
                _PauseMenu.DeActivateInGame();

                break;

            case GameStatus.Loading:

                inMainMenu = false;
                inCredits = false;
                inSettings = false;
                paused = false;
                loading = true;
                isCursorLocked = false;

                //_LoadController.

                break;

            case GameStatus.Ingame:

                inMainMenu = false;
                inCredits = false;
                inSettings = false;
                paused = false;
                loading = false;
                isCursorLocked = true;

                _PauseMenu.ActivateInGame();
                _MainMenu.DeActivateMainMenu();
                

                break;

            case GameStatus.IngamePaused:

                inMainMenu = false;
                inCredits = false;
                inSettings = false;
                paused = true;
                loading = false;
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
                loading = false;
                isCursorLocked = true;

                _PauseMenu.ResumeIngame();
                _MainMenu.DeActivateMainMenu();
                _SettingsMenu.DeActivateSettings();


                break;

            case GameStatus.Credits:

                inMainMenu = true;
                inCredits = true;
                inSettings = false;
                paused = false;
                loading = false;
                isCursorLocked = false;

                _MainMenu.ActivateCredits();

                break;

            case GameStatus.MainMenuSettings:

                inMainMenu = true;
                inCredits = false;
                inSettings = true;
                paused = false;
                loading = false;
                isCursorLocked = false;

                _MainMenu.ActivateSettings();
                _MainMenu.DeActivateTitleScreen();

                break;

            case GameStatus.IngameSettings:

                inMainMenu = false;
                inCredits = false;
                inSettings = true;
                paused = true;
                loading = false;
                isCursorLocked = false;

                _SettingsMenu.ActivateSettings();
                _MainMenu.DeActivateMainMenu();

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
    public void LoadingDone ()
    {

    }
    /*public void CursorMode()
    {
        if (isCursorLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }*/
    public void PressEscape()
    {
        if(Input.GetButtonDown("Escape"))
        {
            if (paused == true && inSettings == false && toTitleScreen == false)  
            {
                _GameStatus = GameStatus.IngameUnpaused;
                CheckGameStatus();
            }
            else if (inMainMenu == false && paused == false && loading == false)
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
