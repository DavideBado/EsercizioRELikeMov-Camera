﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public abstract class StateBase : StateMachineBehaviour, IStateInputCheck
    {
        protected InputManager inputManager;
        protected PlayerController Player;

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            inputManager = GameManager.instance.inputManager;            
            Player = GameManager.instance.PlayerController;
            inputManager.LeftKeyCall += GoLeft;
            inputManager.LeftKeyDownCall += GoLeft_KDown;
            inputManager.RightKeyCall += GoRight;
            inputManager.RightKeyDownCall += GoRight_KDown;
            inputManager.UpKeyCall += GoForward;
            inputManager.UpKeyDownCall += GoForward_KDown;
            inputManager.DownKeyCall += GoBack;
            inputManager.DownKeyDownCall += GoBack_KDown;
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        //{

        //}

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            inputManager.LeftKeyCall -= GoLeft;
            inputManager.LeftKeyDownCall -= GoLeft_KDown;
            inputManager.RightKeyCall -= GoRight;
            inputManager.RightKeyDownCall -= GoRight_KDown;
            inputManager.UpKeyCall -= GoForward;
            inputManager.UpKeyDownCall -= GoForward_KDown;
            inputManager.DownKeyCall -= GoBack;
            inputManager.DownKeyDownCall -= GoBack_KDown;
        }

        public virtual void GoBack_KDown()
        {

        }

        public virtual void GoForward_KDown()
        {

        }

        public virtual void GoLeft()
        {

        }

        public virtual void GoRight()
        {

        }
        public virtual void GoLeft_KDown()
        {

        }

        public virtual void GoRight_KDown()
        {

        }

        public virtual void OnSubmit()
        {

        }

        public virtual void GoForward()
        {

        }

        public virtual void GoBack()
        {

        }
    }