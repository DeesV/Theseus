using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //public GameObject bgImagePanel;
    //public GameObject titleScreenPanel;
    //public GameObject pressEnterPanel;
    
    //Only needed when I make a complete MainMenu with options etc
    /*void Awake ()
    {
        bgImagePanel.SetActive(true);
        titleScreenPanel.SetActive(true);
        pressEnterPanel.SetActive(true);
    }*/
	void Update ()
    {
        if (Input.GetButtonDown("Enter"))
        {
            SceneManager.LoadScene("ArneScene2");
        }
	}
}
