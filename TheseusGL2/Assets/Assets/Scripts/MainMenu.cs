using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject bgImagePanel;
    public GameObject titleScreenPanel;
    public GameObject pressEnterPanel;

    public GameObject settingsPanel;
    public GameObject creditPanel;

    //Only needed when I make a complete MainMenu with options etc
    void Awake ()
    {
        bgImagePanel.SetActive(true);
        titleScreenPanel.SetActive(true);
        //pressEnterPanel.SetActive(true);

        settingsPanel.SetActive(false);
        creditPanel.SetActive(false);
    }
	void Update ()
    {
        if(Input.GetButtonDown("Escape"))
        {
            if (settingsPanel.activeSelf)
            {
                settingsPanel.SetActive(false);
            }
            if (creditPanel.activeSelf)
            {
                creditPanel.SetActive(false);
            }
        }//to be able to press enter to play
        /*if (Input.GetButtonDown("Enter"))
        {
            SceneManager.LoadScene("ArneScene2");
        }*/
	}
    public void StartGame ()
    {
        SceneManager.LoadScene("ArneScene2");
    }
    public void Settings ()
    {
        settingsPanel.SetActive(true);
    }
    public void Credits ()
    {
        creditPanel.SetActive(true);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
}
