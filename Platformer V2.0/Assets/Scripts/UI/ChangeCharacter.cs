using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] private Button prevButton;
    [SerializeField] private Button nextButton;
    public static int currentCharacter;

    private void Awake()
    {
        SelectCharacter(0);
    }
    private void SelectCharacter(int index)
    {
        
        
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }


    public void ChangeChar(int change)
    {
        
        currentCharacter += change;
        if (currentCharacter == -1) currentCharacter = transform.childCount - 1;
        if (currentCharacter == transform.childCount) currentCharacter = 0;
        Debug.Log(currentCharacter);
        SelectCharacter(currentCharacter);
    }
}