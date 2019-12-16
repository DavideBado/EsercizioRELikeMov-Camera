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
        Vector3 forwardpos = Vector3.zero;
        Vector3 rightpos = Vector3.zero;

        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(LeftKey))
        {
            rightpos = - transform.right;
        }
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(RightKey))
        {
            rightpos = transform.right;
        }
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(UpKey))
        {
            forwardpos = transform.forward;
        }
        //Modifico la destinazione del player in base al tasto che  viene premuto
        if (Input.GetKey(DownKey))
        {
            forwardpos = - transform.forward;
        }

        agent.destination = transform.position + forwardpos + rightpos;
        
    }
}
