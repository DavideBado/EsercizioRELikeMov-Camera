using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
/// <summary>
/// Classe per i trigger che modificano la priority delle virtualcameras
/// </summary>
public class SetCameraTrigger : MonoBehaviour
{
    /// <summary>
    /// La camera che vogliamo attivare
    /// </summary>
    public CinemachineVirtualCamera virtualCamera;

    private void OnTriggerEnter(Collider other)
    {
        //Se è entrato il player nel trigger
        if (other.GetComponent<PlayerController>() != null)
        {
            // Per ogni camera salvata nel manager delle camere
            for (int i = 0; i < GameManager.instance.cameraManager.virtualCameras.Count; i++)
            {
                // Se individuo la camera che voglio attivare
                // Porto la sua priority a un valore superiore a quello delle rimanenti camere 
                if (GameManager.instance.cameraManager.virtualCameras[i] == virtualCamera)
                {
                    GameManager.instance.cameraManager.virtualCameras[i].Priority = GameManager.instance.cameraManager.virtualCameras.Count;
                    GameManager.instance.cameraManager.currentCamera = GameManager.instance.cameraManager.virtualCameras[i];
                }
                else
                {
                    GameManager.instance.cameraManager.virtualCameras[i].Priority = 0;
                }
            }
        }
    }
}