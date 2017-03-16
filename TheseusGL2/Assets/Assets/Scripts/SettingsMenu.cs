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
        soundOptionsPanel.SetActive(true);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(false);
    }
    public void Keybindings ()
    {
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(true);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(false);
    }
    public void ControlSettings ()
    {
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(true);
        gameSettingsPanel.SetActive(false);
    }
    public void GameSettings ()
    {
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(true);
    }
}
