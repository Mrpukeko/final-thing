using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardnav : MonoBehaviour
{
    public int pivotPoint;
    float TimeOfDay;

    void OnTriggerEnter(Collider other)
    {
        //if(TimeOfDay == 1009){

        
        if(other.tag == "Guard")
        {
            if(pivotPoint == 12)
            {
                this.gameObject.transform.position = new Vector3(429, 1, -67);
                pivotPoint = 13;              
            }

            if(pivotPoint == 11)
            {
                this.gameObject.transform.position = new Vector3(482, 1, -67);
                pivotPoint = 12;              
            }

            if(pivotPoint == 10)
            {
                this.gameObject.transform.position = new Vector3(429, 1, -67);
                pivotPoint = 11;              
            }

            if(pivotPoint == 9)
            {
                this.gameObject.transform.position = new Vector3(410, 1, -67);
                pivotPoint = 10;              
            }

            if(pivotPoint == 8)
            {
                this.gameObject.transform.position = new Vector3(358, 1, -67);
                pivotPoint = 9;              
            }

            if(pivotPoint == 7)
            {
                this.gameObject.transform.position = new Vector3(324, 1, -52);
                pivotPoint = 8;              
            }

            if(pivotPoint == 6)
            {
                this.gameObject.transform.position = new Vector3(303, 1, -51);
                pivotPoint = 7;              
            }

            if(pivotPoint == 5)
            {
                this.gameObject.transform.position = new Vector3(281, 1, -40);
                pivotPoint = 6;              
            }
             
             if(pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(266, 1, -36);
                pivotPoint = 5;              
            }

             if(pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(245, 1, -29);
                pivotPoint = 4;              
            }

            if(pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(201, 1, -27);
                pivotPoint = 3;              
            } 

            if(pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(181, 1, -27);
                pivotPoint = 2;              
            }

            if(pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(103, 1, -27);
                pivotPoint = 1;              
            }
        }
       // }
        
    }
} 