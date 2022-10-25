using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundry : MonoBehaviour
{
    public float TheDistance;
    public GameObject thePlayer;


    void OnTriggerEnter(Collider other)
    {
        if (TheDistance <= 3)
        {
            this.transform.LookAt(thePlayer.transform);
        }
    }
}
