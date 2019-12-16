using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovState : StateBase
{
    public override void GoForward()
    {
        Player.transform.Translate(Player.transform.forward * Player.WalkSpeed * Time.deltaTime);
    }

    public override void GoBack()
    {
        Player.transform.Translate(Player.transform.forward * -Player.WalkSpeed * Time.deltaTime);
    }

    public override void GoLeft()
    {
        Player.transform.Translate(Player.transform.right * -Player.WalkSpeed * Time.deltaTime);
    }

    public override void GoRight()
    {
        Player.transform.Translate(Player.transform.right * Player.WalkSpeed * Time.deltaTime);
    }
}