using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {

    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;

    public GameObject soundOptionsPanel;
    public GameObject keyBindingsPanel;
    public GameObject controlSettingsPanel;
    public GameObject gameSettingsPanel;

    void Awake ()
    {
        settingsMenuPanel.SetActive(false);
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(false);
    }
    public void SettingsBack ()
    {
        settingsMenuPanel.SetActive(false);
        pauseMenuPanel.SetActive(true);
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
