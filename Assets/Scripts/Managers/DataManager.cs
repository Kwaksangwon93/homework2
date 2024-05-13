using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public CameraMove cameraMove;

    public static string playerNameInput;
    [SerializeField] private Text nickname = null;
    
    public void NameOfPlayer()
    {
        playerNameInput = nickname.text;
        if (playerNameInput.Length >= 2 && playerNameInput.Length <=10)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
