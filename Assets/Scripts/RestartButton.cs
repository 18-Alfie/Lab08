﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}