using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardanimate : MonoBehaviour
{

    private Animator anim;

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(4);

            anim.SetInteger("idleindex", Random.Range(0, 10));
            anim.SetTrigger("idle");
        }
    }
   

   
}
