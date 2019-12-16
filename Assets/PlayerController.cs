using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Controller per il movimento del player
/// </summary>
public class PlayerController : MonoBehaviour
{
    public float WalkSpeed;
    public KeyCode LeftKey, RightKey, UpKey, DownKey;
    public NavMeshAgent agent;
    public int Deltadist;
    // Start is called before the first frame update
    private void Start()
    {
        //Fermo il player
        agent.destination = agent.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        //Controllo gli input
        CheckInput();
    }

    private void CheckInput()
    {
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(LeftKey))
        {
            agent.destination = new Vector3(agent.destination.x - Deltadist * GameManager.instance.cameraManager.currentCamera.transform.right.x, agent.destination.y, agent.destination.z);
        }
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(RightKey))
        {
            agent.destination = new Vector3(agent.destination.x + Deltadist * GameManager.instance.cameraManager.currentCamera.transform.right.x, agent.destination.y, agent.destination.z);
        }
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(UpKey))
        {
            agent.destination = new Vector3(agent.destination.x, agent.destination.y, agent.destination.z + Deltadist * GameManager.instance.cameraManager.currentCamera.transform.forward.z);
        }
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(DownKey))
        {
            agent.destination = new Vector3(agent.destination.x, agent.destination.y, agent.destination.z - Deltadist * GameManager.instance.cameraManager.currentCamera.transform.forward.z);
        }
        //Fermo il movimento del player nella in base al tasto che non viene più premuto
        if (Input.GetKeyUp(LeftKey))
        {
            agent.destination = new Vector3(agent.transform.position.x, agent.destination.y, agent.destination.z);
        }
        //Fermo il movimento del player nella in base al tasto che non viene più premuto
        if (Input.GetKeyUp(RightKey))
        {
            agent.destination = new Vector3(agent.transform.position.x, agent.destination.y, agent.destination.z);
        }
        //Fermo il movimento del player nella in base al tasto che non viene più premuto
        if (Input.GetKeyUp(UpKey))
        {
            agent.destination = new Vector3(agent.destination.x, agent.destination.y, agent.transform.position.z);
        }
        //Fermo il movimento del player nella in base al tasto che non viene più premuto
        if (Input.GetKeyUp(DownKey))
        {
            agent.destination = new Vector3(agent.destination.x, agent.destination.y, agent.transform.position.z);
        }
    }
}
