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
    public bool inMainMenu;
    public bool inGame;
    public bool gamePaused;

    //Game Status Enum(Switch)




    void Awake ()
    {

    }
    void Start () {
		
	}
	void Update () {
		
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
