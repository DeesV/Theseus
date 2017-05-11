//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadController : MonoBehaviour {


    AsyncOperation async;

    public GameObject loadingScreen;

    public Slider loadSlider;

    public UIManager _UIManager;


    void Start ()
    {
        _UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }
    void Update ()
    {
   
    }
    public void LoadScene (string sceneName)
    {

    }
    public void IsSceneReady ()
    {
        while(async.isDone == false)
        {
            loadSlider.value = async.progress;
        }
        if(async.isDone == true)
        {
            _UIManager.LoadingDone();
        }
    }
}
