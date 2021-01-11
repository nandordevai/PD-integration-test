using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public LibPdInstance pdPatch;

    void OnCollisionEnter(Collision c)
    {
        pdPatch.SendBang("Trigger");
    }
}
