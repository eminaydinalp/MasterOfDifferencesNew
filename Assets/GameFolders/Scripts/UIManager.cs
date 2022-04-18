using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    
    public Text jokerText;
    public Text healthText;
    public Text levelText;
    public Text totalLevelText;

    public GameObject[] complateUIs;
    public GameObject failUI;

    private void Awake()
    {
        instance = this;
    }
}
