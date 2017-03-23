//DontDestroyOnLoad by Jordi

using UnityEngine;
using System.Collections;

public class DontDestroyOnLoad : MonoBehaviour
{
    public static DontDestroyOnLoad Instance;

    //Adds DontDestroyOnLoad on GameObject. If object already exists delete to prevent having two
    void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
