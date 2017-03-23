using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {

    [Header("-Main panels")]
    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;

    [Header("-Side options")]
    public GameObject soundOptionsPanel;
    public GameObject keyBindingsPanel;
    public GameObject controlSettingsPanel;
    public GameObject gameSettingsPanel;

    public bool inMainMenu;

    void Awake ()
    {
   

    }
    public void ActivateSettings ()
    {
        settingsMenuPanel.SetActive(true);
        hudPanel.SetActive(false);
    }
    public void DeActivateSettings ()
    {
        if(inMainMenu == false)
        {
            settingsMenuPanel.SetActive(false);
            hudPanel.SetActive(true);
        }
        else
        {
            return;
        }
    }    
    public void Sound ()
    {
    
    }
    public void Keybindings ()
    {
 
    }
    public void ControlSettings ()
    {
    
    }
    public void GameSettings ()
    {
   
    }
}
