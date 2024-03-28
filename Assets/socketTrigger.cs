using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socketTrigger : MonoBehaviour
{
    public GameObject keyObject; // Référence à l'objet "staaar"
    public Animator anim; // Animation à déclencher

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == keyObject)
        {
            // L'objet "staaar" a été placé dans la socket
            // Déclencher l'animation
            anim.SetTrigger("key");
        }
    }
}
