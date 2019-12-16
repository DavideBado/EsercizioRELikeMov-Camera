using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public KeyCode LeftKey, RightKey, UpKey, DownKey;
   
    #region Actions
    public Action LeftKeyCall;
    public Action RightKeyCall;
    public Action LeftKeyDownCall;
    public Action RightKeyDownCall;
    public Action UpKeyDownCall;
    public Action DownKeyDownCall;
    public Action UpKeyCall;
    public Action DownKeyCall;
    #endregion

    public void Init()
    {

    }

    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKey(LeftKey))
        {
            LeftKeyCall?.Invoke();
        }
        if (Input.GetKeyDown(LeftKey))
        {
            LeftKeyDownCall?.Invoke();
        }
        if (Input.GetKey(RightKey))
        {
            RightKeyCall?.Invoke();
        }
        if (Input.GetKeyDown(RightKey))
        {
            RightKeyDownCall?.Invoke();
        }
        if (Input.GetKey(UpKey))
        {
            UpKeyCall?.Invoke();
        }
        if (Input.GetKeyDown(UpKey))
        {
            UpKeyDownCall?.Invoke();
        }
        if (Input.GetKey(DownKey))
        {
            DownKeyCall?.Invoke();
        }
        if (Input.GetKeyDown(DownKey))
        {
            DownKeyDownCall?.Invoke();
        }           
    }
}