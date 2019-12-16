using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public static GameManager instance = null;

    public PlayerController PlayerController;

    [HideInInspector]
    public InputManager inputManager;

    [HideInInspector]
    public CameraManager cameraManager;

    public int CurrentSceneIndex, NextSceneIndex;

    //Awake is always called before any Start functions
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        Init();
    }
    private void Init()
    {
        inputManager = GetComponentInChildren<InputManager>();
        cameraManager = GetComponentInChildren<CameraManager>();

        InitManagers();
    }
    public void InitManagers()
    {
        inputManager.Init();
    }
}
