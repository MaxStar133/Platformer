using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontRestart : MonoBehaviour
{
    private static DontRestart instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}