﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Op dit moment dient dit script vooral voor de stats. In dit script worden alle huidige statistics van de player opgeslagen. DIT SCRIPT STAAT OP DE SPELER.
public class Player : MonoBehaviour {


    public int playerCurrentHP;
    public int playerMaxHP;
    public int playerLevel;
    public float playerXP;
    public int playerXPNeeded;
    public int clickXP;
   
    GameObject statScreen;
    GameObject levelUp;

	// Use this for initialization
	void Awake () {
        statScreen = GameObject.FindGameObjectWithTag("StatScreen");
        levelUp = GameObject.FindGameObjectWithTag("LevelUpText");
        playerMaxHP = 100;
        playerCurrentHP = playerMaxHP;
        playerLevel = 1;
        playerXP = 0;
        playerXPNeeded = 100;
	}
	
	// Update is called once per frame
	void Update () {
        PlayerLevelManager();
        PlayerHPManager();
    }

    void PlayerLevelManager() {
        statScreen.transform.GetChild(4).GetComponent<Text>().text = playerXP.ToString();
        statScreen.transform.GetChild(5).GetComponent<Text>().text = playerXPNeeded.ToString();
        statScreen.transform.GetChild(3).GetComponent<Text>().text = playerLevel.ToString();
        if (Input.GetButtonDown("Fire1"))
            playerXP += clickXP;
        if (playerXP >= playerXPNeeded) {
            StartCoroutine(NewLevelShow());
            levelUp.transform.GetComponent<Text>().text = ("Level Up! Current level:" + (playerLevel + 1));
            playerXPNeeded = Mathf.RoundToInt(playerXPNeeded * 1.15f);
            playerLevel += 1;
            playerXP = 0;
            clickXP += 5;
        }

    }

    IEnumerator NewLevelShow(){
        levelUp.SetActive(true);
        yield return new WaitForSeconds(3);
        levelUp.SetActive(false);
    }

    void PlayerHPManager() {
        statScreen.transform.GetChild(1).GetComponent<Text>().text = playerCurrentHP.ToString();
        statScreen.transform.GetChild(2).GetComponent<Text>().text = playerMaxHP.ToString();
    }

}
