using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
    }
}
