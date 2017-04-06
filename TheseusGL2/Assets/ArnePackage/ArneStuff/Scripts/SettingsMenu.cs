using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{

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

    public UIManager _UIManager;

    public bool inCredits;


    void Awake()
    {
        _UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }
    public void Update()
    {

    }
    public void ActivateSettings()
    {
        settingsMenuPanel.SetActive(true);
        hudPanel.SetActive(false);
    }
    public void DeActivateSettings()
    {
        if(_UIManager.inMainMenu == false)
        {
            settingsMenuPanel.SetActive(false);
            hudPanel.SetActive(true);
        }
        else
        {
            return;
        }
    }
    public void Sound()
    {
        soundOptionsPanel.SetActive(true);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(false);
    }
    public void Keybindings()
    {
        keyBindingsPanel.SetActive(true);
        soundOptionsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(false);
    }
    public void ControlSettings()
    {
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(true);
        gameSettingsPanel.SetActive(false);
    }
    public void GameSettings()
    {
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(true);
    }
    public void InActiveSettings ()
    {
        soundOptionsPanel.SetActive(false);
        keyBindingsPanel.SetActive(false);
        controlSettingsPanel.SetActive(false);
        gameSettingsPanel.SetActive(false);
    }
}
