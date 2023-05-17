
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIQuitButton : MonoBehaviour
{
    private Button quitButton;
    private void Awake()
    {
        quitButton = GetComponent<Button>();
    }
    void Start()
    {
        quitButton.onClick.AddListener(() =>
        {
            QuitApp();
        });
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            QuitApp();
        }
    }

    private void QuitApp()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif        
    }
}
