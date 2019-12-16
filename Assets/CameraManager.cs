using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
/// <summary>
/// Manager delle camere
/// </summary>
public class CameraManager : MonoBehaviour
{
    /// <summary>
    /// Le virtual cameras in scena
    /// </summary>
    public List<CinemachineVirtualCamera> virtualCameras = new List<CinemachineVirtualCamera>();
    public CinemachineVirtualCamera currentCamera;
}
